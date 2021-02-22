using System;
using System.Collections.Generic;
using System.Threading;
using GC.Library.Objects;
using MySql.Data.MySqlClient;
using GC.Library.Translators;
using GC.Library.Objects.SubObjects.Product;
using GC.Library.Entities;
using GC.Library.Objects.SubObjects.Request;

namespace GC.Library.Database
{
    internal static class MySqlNonQuery
    {
        internal static bool TestConnection(bool showErrorModal)
        {
            bool result;
            try
            {
                GlobalVariables.MySqlConnection.Open();
                result = true;
            }
            catch (MySqlException ex)
            {
                result = false;

                Errors.Care.AppendOnErrorLogFile(ex.Message);

                if (showErrorModal)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Ocorreu um erro ao tentar verificar sua conexão com a internet. Verifique se seu computador está conectado com a internet e tente novamente. Se o erro continuar, por favor, entre em contato com a administração.", 2);
                    messOk.ShowDialog();
                }                
            }
            finally
            {
                GlobalVariables.MySqlConnection.Close();
            }

            return result;
        }

        private static bool TryReconnect()
        {
            GlobalModals.FRM_MessageAndProgressBar tryAgain = new GlobalModals.FRM_MessageAndProgressBar("O programa perdeu a conexão com a internet. Por favor, aguarde enquanto o programa tenta restabelecer a conexão...", 2);
            tryAgain.Show();

            bool success = false;
            byte counter = 0;

            while (!success)
            {
                counter++;

                if (counter == 4)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Infelizmente não foi possível conectar o programa com a internet. Por favor, verifique o que deve estar causando este erro. Caso seu computador tenha acesso à internet e ainda assim você estiver recebendo essa mensagem entre em contato com a administração por favor.", 2);
                    messOk.Show();

                    tryAgain.CustomClose();

                    Environment.Exit(0);
                }

                Thread.Sleep(30000);
                success = TestConnection(false);
            }

            tryAgain.CustomClose();

            GlobalModals.FRM_Message msg = new GlobalModals.FRM_Message("Conexão com a internet restaurada com sucesso!", 5, 6000);
            msg.Show();

            return success;
        }

        /// <summary>
        /// Generic insert command.
        /// </summary>
        /// <param name="table">The table's name to be affected</param>
        /// <param name="values">An array with the new user's values to be insert on database.</param>
        /// <returns>A result of the sql command.</returns>
        private static void GenericCreate(string table, string[] columns, string[] values)
        {
            bool reconnect = true;
            int counter = 1;
            string command = "INSERT INTO " + table + "(";

            foreach (string item in columns)
            {
                command += item;
                if (values.Length != counter)
                {
                    command += ",";
                }
                counter++;
            }
            command += ") VALUES(";

            counter = 1;
            foreach (string item in values)
            {
                command += "@value" + counter.ToString();
                if (values.Length != counter)
                {
                    command += ",";
                }
                counter++;
            }
            command += ");";

            MySqlCommand sqlCommand = new MySqlCommand(command, GlobalVariables.MySqlConnection);
            
            if (reconnect)
            {             
                try
                {                                   
                    counter = 1;
                    foreach (string item in values)
                    {
                        sqlCommand.Parameters.AddWithValue("value" + counter.ToString(), item);
                        counter++;
                    }

                    GlobalVariables.MySqlConnection.Open();

                    int rowsAff = sqlCommand.ExecuteNonQuery();
                    if (rowsAff < 1)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    GlobalVariables.MySqlConnection.Close();

                    Errors.Care.AppendOnErrorLogFile(ex.Message);
                    reconnect = TryReconnect();
                    if (reconnect)
                    {
                        GlobalVariables.MySqlConnection.Open();

                        int rowsAff = sqlCommand.ExecuteNonQuery();
                        if (rowsAff < 1)
                        {
                            GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Houve um erro fatal ao tentar reconectar o programa à internet. Por favor, tente novamente mais tarde!", 2);
                            messOk.ShowDialog();
                            Environment.Exit(0);
                        }
                    }
                }
                finally
                {
                    GlobalVariables.MySqlConnection.Close();
                }
            }            
        }

        private static void GenericUpdate(string table, string[] columns, string[] values, string[] conditonColumn, string[] conditonValue, string[] conditionalAndOr, bool[] conditonValueQuotes, bool ignoreAffRows)
        {
            bool reconnect = true;
            int counter = 0;
            string command = "UPDATE " + table + " SET ";

            //First Assembly of the new values
            while (counter < columns.Length)
            {
                command += columns[counter] + " = @value" + counter;
                if (counter != columns.Length - 1) command += ", ";
                counter++;
            }
            command += " WHERE ";

            //First Assembly of the conditions of the query
            counter = 0;
            while (counter < conditonColumn.Length)
            {
                if (conditonColumn.Length > 1)
                {
                    if (conditonValue[counter] == null)
                    {
                        command += conditonColumn[counter] + " IS NULL";
                    }
                    else
                    {
                        if (conditonValueQuotes[counter])
                        {
                            command += conditonColumn[counter] + " = '" + conditonValue[counter] + "'";
                        }
                        else
                        {
                            command += conditonColumn[counter] + " = @condition" + counter;
                        }
                    }
                    if (counter < conditionalAndOr.Length) command += " " + conditionalAndOr[counter] + " ";
                }
                else
                {
                    if (conditonValueQuotes[counter])
                    {
                        command += conditonColumn[counter] + " = '" + conditonValue[counter] + "'";
                    }
                    else
                    {
                        command += conditonColumn[counter] + " = @condition" + counter;
                    }
                }
                counter++;
            }
            command += " ;";

            MySqlCommand sqlCommand = new MySqlCommand(command, GlobalVariables.MySqlConnection);

            if (reconnect)
            {
                try
                {                   
                    //Last assembly of the new values
                    counter = 0;
                    foreach (string item in values)
                    {
                        sqlCommand.Parameters.AddWithValue("value" + counter.ToString(), item);
                        counter++;
                    }

                    //Last assembly of the conditions
                    counter = 0;
                    while (counter < conditonValue.Length)
                    {
                        if (conditonValue[counter] != null)
                        {
                            if (!conditonValueQuotes[counter])
                            {
                                sqlCommand.Parameters.AddWithValue("condition" + counter, conditonValue[counter]);
                            }
                        }

                        counter++;
                    }

                    GlobalVariables.MySqlConnection.Open();

                    int rowsAff = sqlCommand.ExecuteNonQuery();
                    if (rowsAff < 1 && !ignoreAffRows)
                    {
                        throw new Exception("Nenhuma linha foi alterada.");
                    }
                }
                catch (Exception ex)
                {
                    GlobalVariables.MySqlConnection.Close();

                    Errors.Care.AppendOnErrorLogFile(ex.Message);
                    reconnect = TryReconnect();
                    if (reconnect)
                    {
                        GlobalVariables.MySqlConnection.Open();

                        int rowsAff = sqlCommand.ExecuteNonQuery();
                        if (rowsAff < 1 && !ignoreAffRows)
                        {
                            GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Houve um erro fatal ao tentar reconectar o programa à internet. Por favor, tente novamente mais tarde!", 2);
                            messOk.ShowDialog();
                            Environment.Exit(0);
                        }
                    }
                }
                finally
                {
                    GlobalVariables.MySqlConnection.Close();
                }
            }            
        }

        private static void GenericUpdate(string table, string[] columns, string[] values, string comparatorColumn, string comparatorValue, bool ignoreAffRows)
        {
            bool reconnect = true;
            int counter = 0;
            string command = "UPDATE " + table + " SET ";

            while (counter < columns.Length)
            {
                command += columns[counter] + " = @value" + counter;
                if (counter != columns.Length - 1) command += ", ";
                counter++;
            }
            command += " WHERE " + comparatorColumn + " = @comparator ;";

            MySqlCommand sqlCommand = new MySqlCommand(command, GlobalVariables.MySqlConnection);

            if (reconnect)
            {
                try
                {                 
                    counter = 0;
                    foreach (string item in values)
                    {
                        sqlCommand.Parameters.AddWithValue("value" + counter.ToString(), item);
                        counter++;
                    }

                    sqlCommand.Parameters.AddWithValue("comparator", comparatorValue);

                    GlobalVariables.MySqlConnection.Open();

                    int rowsAff = sqlCommand.ExecuteNonQuery();
                    if (rowsAff < 1 && !ignoreAffRows)
                    {
                        throw new Exception("Nenhuma linha foi alterada.");
                    }
                }
                catch (Exception ex)
                {
                    GlobalVariables.MySqlConnection.Close();

                    Errors.Care.AppendOnErrorLogFile(ex.Message);
                    reconnect = TryReconnect();
                    if (reconnect)
                    {
                        GlobalVariables.MySqlConnection.Open();

                        int rowsAff = sqlCommand.ExecuteNonQuery();
                        if (rowsAff < 1 && !ignoreAffRows)
                        {
                            GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Houve um erro fatal ao tentar reconectar o programa à internet. Por favor, tente novamente mais tarde!", 2);
                            messOk.ShowDialog();
                            Environment.Exit(0);
                        }
                    }
                }
                finally
                {
                    GlobalVariables.MySqlConnection.Close();
                }
            }            
        }

        private static void GenericDelete(string table, string[] conditonColumn, string[] conditonValue, string[] conditionalAndOr, bool[] conditonValueQuotes, bool ignoreAffRows)
        {
            bool reconnect = true;

            string command = "DELETE FROM " + table + " WHERE ";
            int counter = 0;
            while (counter < conditonColumn.Length)
            {
                if (conditonColumn.Length > 1)
                {
                    if (conditonValue[counter] == null)
                    {
                        command += conditonColumn[counter] + " IS NULL";
                    }
                    else
                    {
                        if (conditonValueQuotes[counter])
                        {
                            command += conditonColumn[counter] + " = '" + conditonValue[counter] + "'";
                        }
                        else
                        {
                            command += conditonColumn[counter] + " = @value" + counter;
                        }
                    }
                    if (counter < conditionalAndOr.Length) command += " " + conditionalAndOr[counter] + " ";
                }
                else
                {
                    if (conditonValueQuotes[counter])
                    {
                        command += conditonColumn[counter] + " = '" + conditonValue[counter] + "'";
                    }
                    else
                    {
                        command += conditonColumn[counter] + " = @value" + counter;
                    }
                }
                counter++;
            }
            command += ";";

            MySqlCommand sqlCommand = new MySqlCommand(command, GlobalVariables.MySqlConnection);

            counter = 0;
            while (counter < conditonValue.Length)
            {
                if (conditonValue[counter] != null && conditonValue[counter] != "")
                {
                    if (!conditonValueQuotes[counter])
                    {
                        sqlCommand.Parameters.AddWithValue("value" + counter, conditonValue[counter]);
                    }
                }
                counter++;
            }

            if (reconnect)
            {
                try
                {
                    GlobalVariables.MySqlConnection.Open();

                    int rowsAff = sqlCommand.ExecuteNonQuery();
                    if (rowsAff < 1 && !ignoreAffRows)
                    {
                        throw new Exception("Nenhuma linha sofreu altereção.");
                    }
                }
                catch (Exception ex)
                {
                    GlobalVariables.MySqlConnection.Close();

                    Errors.Care.AppendOnErrorLogFile(ex.Message);

                    reconnect = TryReconnect();
                    if (reconnect)
                    {
                        GlobalVariables.MySqlConnection.Open();

                        int rowsAff = sqlCommand.ExecuteNonQuery();
                        if (rowsAff < 1 && !ignoreAffRows)
                        {
                            GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Houve um erro fatal ao tentar reconectar o programa à internet. Por favor, tente novamente mais tarde!", 2);
                            messOk.ShowDialog();
                            Environment.Exit(0);
                        }
                    }
                }
                finally
                {
                    GlobalVariables.MySqlConnection.Close();
                }
            }
        }

        private static void GenericDelete(string table, string comparatorColumn, string comparatorValue, bool isComparatorString, bool ignoreAffRows)
        {
            bool reconnect = true;
            string command = "";

            if (isComparatorString) command = "DELETE FROM " + table + " WHERE " + comparatorColumn + " = '" + comparatorValue + "';";
            else command = "DELETE FROM " + table + " WHERE " + comparatorColumn + " = " + comparatorValue + ";";

            MySqlCommand sqlCommand = new MySqlCommand(command, GlobalVariables.MySqlConnection);

            if (reconnect)
            {
                try
                {
                    GlobalVariables.MySqlConnection.Open();

                    int rowsAff = sqlCommand.ExecuteNonQuery();
                    if (rowsAff < 1 && !ignoreAffRows)
                    {
                        throw new Exception("Nenhuma linha sofreu altereção.");
                    }
                }
                catch (Exception ex)
                {
                    GlobalVariables.MySqlConnection.Close();

                    Errors.Care.AppendOnErrorLogFile(ex.Message);

                    reconnect = TryReconnect();
                    if (reconnect)
                    {
                        GlobalVariables.MySqlConnection.Open();

                        int rowsAff = sqlCommand.ExecuteNonQuery();
                        if (rowsAff < 1 && !ignoreAffRows)
                        {
                            GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Houve um erro fatal ao tentar reconectar o programa à internet. Por favor, tente novamente mais tarde!", 2);
                            messOk.ShowDialog();
                            Environment.Exit(0);
                        }
                    }
                }
                finally
                {
                    GlobalVariables.MySqlConnection.Close();
                }
            }            
        }

        //------------------------------------------------------------------------------------------------------
        //USER'S CUD BEGIN -------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Create a new User on the database.
        /// </summary>
        /// <param name="user">The User object to be created.</param>
        /// <returns>Returns true if success, false if failed.</returns>
        internal static void CreateUser(User user)
        {
            DateTime rightNowDateTime = DateTime.Now;

            string[] values = new string[13];
            string[] columns = new string[13];

            columns[0] = "iduser";
            columns[1] = "name";
            columns[2] = "email";
            columns[3] = "password";
            columns[4] = "phone_number";
            columns[5] = "cnpj";
            columns[6] = "joined";
            columns[7] = "mac";
            columns[8] = "token";
            columns[9] = "warranty_counter";
            columns[10] = "request_counter";
            columns[11] = "last_login";
            columns[12] = "last_logout";

            values[0] = null;
            values[1] = user.Name;
            values[2] = user.Email;
            values[3] = user.GetPassword();
            values[4] = user.PhoneNumber;
            values[5] = user.Cnpj;
            values[6] = ObjectToSQL.ToDateTimeSql(rightNowDateTime);
            values[7] = user.Mac;
            values[8] = null;
            values[9] = "0";
            values[10] = "0";
            values[11] = null;
            values[12] = null;

            GenericCreate("user", columns, values);            

            //USER_METADA CREATION
            int userId = Int32.Parse(MySqlReader.ReadOnlyOneColumn("user", "iduser", new string[] { "email" }, new string[] { user.Email }, null, new bool[] { false }));
            string[] columns2 = new string[11];
            string[] values2 = new string[11];

            columns2[0] = "idmd";
            columns2[1] = "last_payment";
            columns2[2] = "expiration";
            columns2[3] = "account_type";
            columns2[4] = "last_account_type_change";
            columns2[5] = "registered_costumers";
            columns2[6] = "registered_products";
            columns2[7] = "registered_jobs";
            columns2[8] = "registered_suppliers";
            columns2[9] = "id_user";

            values2[0] = null;
            values2[1] = ObjectToSQL.ToDateTimeSql(rightNowDateTime);
            values2[2] = ObjectToSQL.ToDateTimeSql(rightNowDateTime.AddMonths(1));
            values2[3] = "P";
            values2[4] = null;
            values2[5] = "0";
            values2[6] = "0";
            values2[7] = "0";
            values2[8] = "0";
            values2[9] = userId.ToString();

            GenericCreate("user_metadata", columns2, values2);

            // Creating the user account recharge table for the user
            double rechargePrice = MySqlReader.GetAccountTypePrice('P');

            string[] columns5 = new string[3];
            string[] values5 = new string[3];

            columns5[0] = "iduar";
            columns5[1] = "recharge_price";
            columns5[2] = "id_user";

            values5[0] = null;
            values5[1] = ObjectToSQL.ToDecimalSql_TwoDecimals(rechargePrice);
            values5[2] = userId.ToString();

            GenericCreate("user_account_recharge", columns5, values5);

            //COMMERCE_STATS CREATION
            string[] columns3 = new string[9];
            string[] values3 = new string[9];

            columns3[0] = "idcs";
            columns3[1] = "profits_amount";
            columns3[2] = "requests_done_counter";
            columns3[3] = "requests_done_amount";
            columns3[4] = "products_sales_counter";
            columns3[5] = "products_sales_amount";
            columns3[6] = "jobs_sales_counter";
            columns3[7] = "jobs_sales_amount ";
            columns3[8] = "id_user";

            values3[0] = null;
            values3[1] = "0";
            values3[2] = "0";
            values3[3] = "0";
            values3[4] = "0";
            values3[5] = "0";
            values3[6] = "0";
            values3[7] = "0";
            values3[8] = userId.ToString();

            GenericCreate("commerce_stats", columns3, values3);

            //USER_CONFIGURATION CREATION
            string[] values4 = new string[10];
            string[] columns4 = new string[10];

            columns4[0] = "iduc";
            columns4[1] = "enable_animations";
            columns4[2] = "enable_windows_voice_alerts";
            columns4[3] = "enable_modal_alerts";
            columns4[4] = "last_routine_operations_fortnight";
            columns4[5] = "enable_request_products_separation_helper";
            columns4[6] = "auto_clear_cancelled_req";
            columns4[7] = "days_before_expiration";
            columns4[8] = "enable_critical_stock_system";
            columns4[9] = "id_user";

            values4[0] = null;
            values4[1] = "1";
            values4[2] = "1"; 
            values4[3] = "1";
            values4[4] = null;
            values4[5] = "1";
            values4[6] = "0";
            values4[7] = "30";
            values4[8] = "1";
            values4[9] = userId.ToString();

            GenericCreate("user_configuration", columns4, values4);
        }

        internal static bool UpdateUserByEmail(string email, string columnToUpdate, string newValue)
        {
            string[] column = { columnToUpdate };
            string[] value = { newValue };

            int id = MySqlReader.GetUserId(email);

            if(id < 0) return false;
            else
            {
                GenericUpdate("user", column, value, "iduser", id.ToString(), false);
                return true;
            }            
        }

        internal static void UpdateUser(string columnToUpdate, string newValue)
        {
            string[] column = { columnToUpdate };
            string[] value = { newValue };

            GenericUpdate("user", column, value, "iduser", GlobalVariables.User.Id.ToString(), false);
        }

        internal static void UpdateUserMetadata(string columnToUpdate, string newValue)
        {
            string[] column = { columnToUpdate };
            string[] value = { newValue };

            GenericUpdate("user_metadata", column, value, "id_user", GlobalVariables.User.Id.ToString(), false);
        }

        internal static void UpdateUserConfiguration()
        {
            string[] values = new string[7];
            string[] columns = new string[7];

            columns[0] = "enable_animations";
            columns[1] = "enable_windows_voice_alerts";
            columns[2] = "enable_modal_alerts";
            columns[3] = "enable_request_products_separation_helper";
            columns[4] = "auto_clear_cancelled_req";
            columns[5] = "days_before_expiration";
            columns[6] = "enable_critical_stock_system";

            values[0] = ObjectToSQL.ToBoolSql(GlobalVariables.Configuration.Enable_animations);
            values[1] = ObjectToSQL.ToBoolSql(GlobalVariables.Configuration.Enable_windows_voice_alerts);
            values[2] = ObjectToSQL.ToBoolSql(GlobalVariables.Configuration.Enable_modal_alerts);
            values[3] = ObjectToSQL.ToBoolSql(GlobalVariables.Configuration.Enable_request_products_separation_helper);
            values[4] = ObjectToSQL.ToBoolSql(GlobalVariables.Configuration.Auto_clear_cancelled_req);
            values[5] = ObjectToSQL.ToIntSql(GlobalVariables.Configuration.Days_before_expiration);
            values[6] = ObjectToSQL.ToBoolSql(GlobalVariables.Configuration.Enable_critical_stock_system);

            GenericUpdate("user_configuration", columns, values, "id_user", GlobalVariables.User.Id.ToString(), false);
        }

        internal static void UpdateLastFortnight()
        {
            GenericUpdate("user_configuration", new string[] { "last_routine_operations_fortnight" }, new string[] { ObjectToSQL.ToDateTimeSql(GlobalVariables.Configuration.Last_routine_operations_fortnight) }, "id_user", GlobalVariables.User.Id.ToString(), false);
        }

        internal static void IncrementUserRegisteredCostumers(int value)
        {
            int newValue = GlobalVariables.FragileData.RegisteredCostumers + value;
            GenericUpdate("user_metadata", new string[] { "registered_costumers" }, new string[] { newValue.ToString() }, "id_user", GlobalVariables.User.Id.ToString(), false);
            GlobalVariables.FragileData.RegisteredCostumers = newValue;
        }

        internal static void IncrementUserRegisteredProducts(int value)
        {
            int newValue = GlobalVariables.FragileData.RegisteredProducts + value;
            GenericUpdate("user_metadata", new string[] { "registered_products" }, new string[] { newValue.ToString() }, "id_user", GlobalVariables.User.Id.ToString(), false);
            GlobalVariables.FragileData.RegisteredProducts = newValue;
        }

        internal static void IncrementUserRegisteredSuppliers(int value)
        {
            int newValue = GlobalVariables.FragileData.RegisteredSuppliers + value;
            GenericUpdate("user_metadata", new string[] { "registered_suppliers" }, new string[] { newValue.ToString() }, "id_user", GlobalVariables.User.Id.ToString(), false);
            GlobalVariables.FragileData.RegisteredSuppliers = newValue;
        }

        internal static void IncrementUserRegisteredJobs(int value)
        {
            int newValue = GlobalVariables.FragileData.RegisteredJobs + value;
            GenericUpdate("user_metadata", new string[] { "registered_jobs" }, new string[] { newValue.ToString() }, "id_user", GlobalVariables.User.Id.ToString(), false);
            GlobalVariables.FragileData.RegisteredJobs = newValue;
        }

        internal static void UpdateLastRenewRequest()
        {
            GenericUpdate("user", new string[] { "last_renew_request" }, new string[] { ObjectToSQL.ToDateTimeSql(DateTime.Now) }, "iduser", GlobalVariables.User.Id.ToString(), false);
        }

        //------------------------------------------------------------------------------------------------------
        //REMINDER'S CUD BEGIN -------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------
        internal static int CreateReminder(Reminder reminder)
        {
            string[] values = new string[10];
            string[] columns = new string[10];

            columns[0] = "idreminder";
            columns[1] = "start";
            columns[2] = "end";
            columns[3] = "title";
            columns[4] = "observations";
            columns[5] = "red";
            columns[6] = "green";
            columns[7] = "blue";
            columns[8] = "created_in";
            columns[9] = "id_user";

            values[0] = null;
            values[1] = ObjectToSQL.ToDateTimeSql(reminder.Start);
            values[2] = ObjectToSQL.ToDateTimeSql(reminder.End);
            values[3] = reminder.Title;
            values[4] = reminder.Observations;
            values[5] = ObjectToSQL.ToTinyIntSql(reminder.Red);
            values[6] = ObjectToSQL.ToTinyIntSql(reminder.Green);
            values[7] = ObjectToSQL.ToTinyIntSql(reminder.Blue);
            values[8] = ObjectToSQL.ToDateTimeSql(DateTime.Now);
            values[9] = GlobalVariables.User.Id.ToString();

            GenericCreate("reminder", columns, values);

            return Int32.Parse(MySqlReader.ReadOnlyOneColumn("reminder", "idreminder", new string[] { "title", "start", "id_user" }, new string[] { reminder.Title, reminder.Start.ToString("yyyy/MM/dd HH:mm:ss"), GlobalVariables.User.Id.ToString() }, new string[] { "AND", "AND" }, new bool[] { false, true, false }));
        }

        internal static void UpdateReminder(Reminder reminder)
        {
            string[] columns = new string[7];
            string[] values = new string[7];

            columns[0] = "start";
            columns[1] = "end";
            columns[2] = "title";
            columns[3] = "observations";
            columns[4] = "red";
            columns[5] = "green";
            columns[6] = "blue";

            values[0] = ObjectToSQL.ToDateTimeSql(reminder.Start);
            values[1] = ObjectToSQL.ToDateTimeSql(reminder.End);
            values[2] = reminder.Title;
            values[3] = reminder.Observations;
            values[4] = ObjectToSQL.ToTinyIntSql(reminder.Red);
            values[5] = ObjectToSQL.ToTinyIntSql(reminder.Green);
            values[6] = ObjectToSQL.ToTinyIntSql(reminder.Blue);

            GenericUpdate("reminder", columns, values, new string[] { "idreminder", "id_user" }, new string[] { reminder.Id.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }, false);
        }

        internal static void DeleteReminderById(int id)
        {
            GenericDelete("reminder", "idreminder", id.ToString(), false, false);
        }

        //------------------------------------------------------------------------------------------------------
        //PRODUCT'S CUD BEGIN -------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------
        internal static void CreateProduct(Product product)
        {
            string[] values = new string[10];
            string[] columns = new string[10];

            columns[0] = "idproduct";
            columns[1] = "code";
            columns[2] = "description";
            columns[3] = "ideal_stock";
            columns[4] = "price";
            columns[5] = "position";
            columns[6] = "pack_quantity";
            columns[7] = "weight_kg";
            columns[8] = "id_user";
            columns[9] = "id_supplier";

            values[0] = null;
            values[1] = product.Code;
            values[2] = product.Description;

            if (product.IdealStock == -1)
            {
                values[3] = null;
            }
            else
            {
                values[3] = product.IdealStock.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture);
            }

            if (product.Price == -1)
            {
                values[4] = null;
            }
            else
            {
                values[4] = product.Price.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            }

            values[5] = product.Position;

            if (product.PackQuantity == -1)
            {
                values[6] = null;
            }
            else
            {
                values[6] = product.PackQuantity.ToString();
            }

            if(product.Weight == -1)
            {
                values[7] = null;
            }
            else
            {
                values[7] = product.Weight.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture);
            }      
            
            values[8] = GlobalVariables.User.Id.ToString();

            if(product.Id_Supplier == -1)
            {
                values[9] = null;
            }
            else
            {
                values[9] = product.Id_Supplier.ToString();
            }

            GenericCreate("product", columns, values);
        }

        internal static void CreateProducts(List<Product> products)
        {
            foreach (Product item in products)
            {
                CreateProduct(item);
            }
        }

        internal static void UpdateProduct(Product product) 
        {
            string[] columns = new string[8];
            string[] values = new string[8];            

            columns[0] = "code";
            columns[1] = "description";
            columns[2] = "ideal_stock";
            columns[3] = "price";
            columns[4] = "position";
            columns[5] = "pack_quantity";
            columns[6] = "weight_kg";
            columns[7] = "id_supplier";

            values[0] = product.Code;
            values[1] = product.Description;

            if (product.IdealStock == -1)
            {
                values[2] = null;
            }
            else
            {
                values[2] = product.IdealStock.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture);
            }

            if (product.Price == -1)
            {
                values[3] = null;
            }
            else
            {
                values[3] = product.Price.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            }

            values[4] = product.Position;

            if (product.PackQuantity == -1)
            {
                values[5] = null;
            }
            else
            {
                values[5] = product.PackQuantity.ToString();
            }

            if (product.Weight == -1)
            {
                values[6] = null;
            }
            else
            {
                values[6] = product.Weight.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture);
            }

            if (product.Id_Supplier == -1)
            {
                values[7] = null;
            }
            else
            {
                values[7] = product.Id_Supplier.ToString();
            }

            GenericUpdate("product", columns, values, "idproduct", product.Id.ToString(), false);
        }

        internal static void DeleteProductById(int id)
        {
            Product product = Product.CloneProduct(id);
            string addDesc = "-O produto de código '" + product.Code + "' e descrição '" + product.Description + "', que estava " +
                "incluído neste pedido e cuja quantidade/peso era(m) '";

            int index = -1;
            string varDesc;            

            //Old Request
            if (GlobalVariables.OldRequests.Count <= 0) Files.SeekFor.OldRequest();
            foreach (Request oldReq in GlobalVariables.OldRequests)
            {               
                foreach (Request_Products por in oldReq.Products)
                {
                    if (por.Id_Product == id)
                    {
                        double totalValue = por.Price * por.Quantity;
                        varDesc = ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(por.Quantity) + "' unid./kg, foi " +
                            "excluído do sistema em " + DateTime.Now.ToString("dd/MM/yyyy") + " às " + DateTime.Now.ToString("HH:mm:ss") +
                            ". Porém, seu valor total de '" + ObjectToDetailLabel.ToMoneyLabel(totalValue) + "' continua incluso neste pedido.";

                        if (oldReq.Occurrences == null || oldReq.Occurrences == "")
                        {
                            oldReq.Occurrences = addDesc + varDesc;
                        }
                        else
                        {
                            string newOccurrences = oldReq.Occurrences += "\n\n" + addDesc + varDesc;
                            oldReq.Occurrences = newOccurrences;
                        }
                    }

                    index = oldReq.Products.IndexOf(por);
                }

                if (index != -1) oldReq.Products.RemoveAt(index);

                Serialization.SerializeRequest(oldReq);
            }

            varDesc = String.Empty;

            //New Request
            foreach (Request item in GlobalVariables.Requests)
            {
                index = -1;

                foreach (Request_Products item2 in item.Products)
                {
                    if(item2.Id_Product == id)
                    {
                        double totalValue = item2.Price * item2.Quantity;
                        varDesc = ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(item2.Quantity) + "' unid./kg, foi " +
                            "excluído do sistema em " + DateTime.Now.ToString("dd/MM/yyyy") + " às " + DateTime.Now.ToString("HH:mm:ss") +
                            ". Porém, seu valor total de '" + ObjectToDetailLabel.ToMoneyLabel(totalValue) + "' continua incluso neste pedido.";

                        if(item.Occurrences == null || item.Occurrences == "")
                        {
                            UpdateRequestOccurrences(item.Id, addDesc + varDesc);
                            item.Occurrences = addDesc + varDesc;
                        }
                        else
                        {
                            string newOccurrences = item.Occurrences += "\n\n" + addDesc + varDesc;
                            UpdateRequestOccurrences(item.Id, newOccurrences);
                            item.Occurrences = newOccurrences;
                        }
                    }

                    index = item.Products.IndexOf(item2);
                }

                if(index != -1) item.Products.RemoveAt(index);

                Serialization.SerializeRequest(item);
            }

            GenericDelete("lot", "id_product", id.ToString(), false, true);
            GenericDelete("request_products", "id_product", id.ToString(), false, true);
            GenericDelete("product", "idproduct", id.ToString(), false, false);
        }

        //----------------------------------------------------------------
        // LOT'S CUD BEGIN -----------------------------------------------
        //----------------------------------------------------------------
        internal static int CreateLot(Lot lot)
        {
            string[] values = new string[7];
            string[] columns = new string[7];

            columns[0] = "idlot";
            columns[1] = "number";
            columns[2] = "quantity";
            columns[3] = "entry";
            columns[4] = "expires_in";
            columns[5] = "id_product";
            columns[6] = "id_user";

            values[0] = null;
            values[1] = lot.Number;
            values[2] = lot.Quantity.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture);
            values[3] = lot.Entry.ToString("yyyy/MM/dd HH:mm:ss");
            values[4] = ObjectToSQL.ToDateTimeSql(lot.ExpiresIn);
            values[5] = lot.Id_Product.ToString();
            values[6] = GlobalVariables.User.Id.ToString();

            GenericCreate("lot", columns, values);

            return Int32.Parse(MySqlReader.ReadOnlyOneColumn("lot", "idlot", new string[] { "number", "quantity", "entry", "id_product", "id_user" }, new string[] { lot.Number, ObjectToSQL.ToDecimalSql_ThreeDecimals(lot.Quantity), lot.Entry.ToString("yyyy/MM/dd HH:mm:ss"), lot.Id_Product.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND", "AND", "AND", "AND" }, new bool[] { false, false, true, false, false }));
        }

        internal static void UpdateLot(Lot lot)
        {
            string[] columns = new string[3];
            string[] values = new string[3];

            columns[0] = "number";
            columns[1] = "quantity";
            columns[2] = "expires_in";

            values[0] = lot.Number;
            values[1] = lot.Quantity.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture);
            values[2] = ObjectToSQL.ToDateTimeSql(lot.ExpiresIn);

            GenericUpdate("lot", columns, values, new string[] { "idlot", "id_user" }, new string[] { lot.Id.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false}, false);
        }

        internal static void UpdateLotQuantity(int id, double quantity)
        {
            if(id.ToString() == null || id.ToString() == "")
            {
                Errors.Care.AppendOnErrorLogFile("Id do lote cuja nova quantidade iria ser " + quantity.ToString() + ", era nulo ou em branco! Talvez o usuário tentou fazer estorno/consumo " +
                    "de um lote em um computador diferente.");

                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Houve um erro fatal ao fazer o estorno/consumo de lotes! O programa precisará ser " +
                    "fechado para a segurança dos seus dados.", 2);
                messOk.ShowDialog();
                Environment.Exit(0);
            }
            
            string[] columns = new string[1];
            string[] values = new string[1];
            
            columns[0] = "quantity";
            values[0] = quantity.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture);

            GenericUpdate("lot", columns, values, new string[] { "idlot", "id_user" }, new string[] { id.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }, false);
        }

        internal static void DeleteLotById(int id)
        {
            GenericDelete("lot", new string[] { "idlot", "id_user" }, new string[] { id.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }, false);
        }

        internal static void DeleteLotsByProductId(int id)
        {
            GenericDelete("lot", new string[] { "id_product", "id_user" }, new string[] { id.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }, true);
        }

        //-----------------------------------------------------------
        // SUPPLIER'S CUD BEGIN --------------------------------------------
        //-----------------------------------------------------------
        internal static void CreateSupplier(Supplier supplier)
        {
            string[] values = new string[7];
            string[] columns = new string[7];

            columns[0] = "idsupplier";
            columns[1] = "name";
            columns[2] = "description";
            columns[3] = "email";
            columns[4] = "phone_number";
            columns[5] = "cpf_cnpj";
            columns[6] = "id_user";

            values[0] = null;
            values[1] = supplier.Name;
            values[2] = supplier.Description;
            values[3] = supplier.Email;
            values[4] = supplier.PhoneNumber;
            values[5] = supplier.CpfCnpj;
            values[6] = GlobalVariables.User.Id.ToString();
            
            GenericCreate("supplier", columns, values);
        }

        internal static void CreateSuppliers(List<Supplier> suppliers)
        {
            foreach (Supplier item in suppliers)
            {
                CreateSupplier(item);
            }
        }

        internal static void UpdateSupplier(Supplier supplier)
        {
            string[] columns = new string[5];
            string[] values = new string[5];

            columns[0] = "name";
            columns[1] = "description";
            columns[2] = "email";
            columns[3] = "phone_number";
            columns[4] = "cpf_cnpj";            

            values[0] = supplier.Name;
            values[1] = supplier.Description;
            values[2] = supplier.Email;
            values[3] = supplier.PhoneNumber;
            values[4] = supplier.CpfCnpj;

            GenericUpdate("supplier", columns, values, "idsupplier", supplier.Id.ToString(), false);
        }

        internal static void DeleteSupplierById(int id)
        {
            GenericUpdate("product", new string[] { "id_supplier" }, new string[] { null }, "id_supplier", id.ToString(), true);
            GenericDelete("supplier", "idsupplier", id.ToString(), false, false);
        }

        //------------------------------------------------------------------------------------------------------
        //JOB'S CUD BEGIN -------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------
        internal static void CreateJob(Job job)
        {
            string[] values = new string[5];
            string[] columns = new string[5];

            columns[0] = "idjob";
            columns[1] = "name";
            columns[2] = "description";
            columns[3] = "price";
            columns[4] = "id_user";

            values[0] = null;
            values[1] = job.Name;
            values[2] = job.Description;
            if (job.Price == -1)
            {
                values[3] = null;
            }
            else
            {
                values[3] = job.Price.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            }            
            values[4] = GlobalVariables.User.Id.ToString();            

            GenericCreate("job", columns, values);
        }

        internal static void CreateJobs(List<Job> jobs)
        {
            foreach (Job item in jobs)
            {
                CreateJob(item);
            }
        }

        internal static void UpdateJob(Job job)
        {
            string[] columns = new string[3];
            string[] values = new string[3];

            columns[0] = "name";
            columns[1] = "description";
            columns[2] = "price";

            values[0] = job.Name;
            values[1] = job.Description;
            if (job.Price == -1)
            {
                values[2] = null;
            }
            else
            {
                values[2] = job.Price.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            }

            GenericUpdate("job", columns, values, "idjob", job.Id.ToString(), false);
        }

        internal static void DeleteJobById(int id)
        {
            Job job = Job.CloneJob(id);
            string addDesc = "-O serviço '" + job.Name + "'";

            if(job.Description != null && job.Description != "")
            {
                addDesc += " com a descrição '" + job.Description + "'";
            }

            addDesc += ", que estava incluído neste pedido e cujo valor era '";

            string varDesc;

            //New Requests
            foreach (Request item in GlobalVariables.Requests)
            {
                int index = -1;

                foreach (Request_Jobs item2 in item.Jobs)
                {
                    if (item2.Id_Job == id)
                    {
                        varDesc = ObjectToDetailLabel.ToMoneyLabel(job.Price) + "', foi " +
                            "excluído do sistema em " + DateTime.Now.ToString("dd/MM/yyyy") + " às " + DateTime.Now.ToString("HH:mm:ss") +
                            ". Porém, seu valor continua incluso neste pedido.";

                        if (item.Occurrences == null || item.Occurrences == "")
                        {
                            UpdateRequestOccurrences(item.Id, addDesc + varDesc);
                            item.Occurrences = addDesc + varDesc;
                        }
                        else
                        {
                            string newOccurrences = item.Occurrences += "\n\n" + addDesc + varDesc;
                            UpdateRequestOccurrences(item.Id, newOccurrences);
                            item.Occurrences = newOccurrences;
                        }
                    }

                    index = item.Jobs.IndexOf(item2);
                }

                if (index != -1) item.Jobs.RemoveAt(index);
            }

            //Old Requests
            if(GlobalVariables.OldRequests.Count > 0)
            {
                foreach (Request oldRequest in GlobalVariables.OldRequests)
                {
                    int index = -1;

                    foreach (Request_Jobs item2 in oldRequest.Jobs)
                    {
                        if (item2.Id_Job == id)
                        {
                            varDesc = ObjectToDetailLabel.ToMoneyLabel(job.Price) + "', foi " +
                                "excluído do sistema em " + DateTime.Now.ToString("dd/MM/yyyy") + " às " + DateTime.Now.ToString("HH:mm:ss") +
                                ". Porém, seu valor continua incluso neste pedido.";

                            if (oldRequest.Occurrences == null || oldRequest.Occurrences == "")
                            {
                                oldRequest.Occurrences = addDesc + varDesc;
                            }
                            else
                            {
                                string newOccurrences = oldRequest.Occurrences += "\n\n" + addDesc + varDesc;
                                oldRequest.Occurrences = newOccurrences;
                            }
                        }

                        index = oldRequest.Jobs.IndexOf(item2);
                    }

                    if (index != -1) oldRequest.Jobs.RemoveAt(index);
                }
            }

            GenericDelete("request_jobs", "id_job", id.ToString(), false, true);
            GenericDelete("job", "idjob", id.ToString(), false, false);
        }

        //--------------------------------------------------------------------------
        // COSTUMER'S CUD BEGIN
        //--------------------------------------------------------------------------
        internal static void CreateCostumer(Costumer costumer)
        {
            string[] values = new string[19];
            string[] columns = new string[19];

            columns[0] = "idcostumer";
            columns[1] = "name";
            columns[2] = "email";
            columns[3] = "phone_number";
            columns[4] = "is_phone_whatsapp";
            columns[5] = "sex";
            columns[6] = "street";
            columns[7] = "number";
            columns[8] = "complement";
            columns[9] = "reference";
            columns[10] = "district";
            columns[11] = "city";
            columns[12] = "state";
            columns[13] = "country";
            columns[14] = "cep";
            columns[15] = "discount_counter";
            columns[16] = "discount_accumulated";
            columns[17] = "debt";
            columns[18] = "id_user";

            values[0] = null;
            values[1] = costumer.Name;
            values[2] = costumer.Email;
            values[3] = costumer.PhoneNumber;
            values[4] = Convert.ToInt32(costumer.IsPhoneWhatsapp).ToString();
            values[5] = costumer.Sex.ToString();
            values[6] = costumer.Street;
            values[7] = costumer.Number;
            values[8] = costumer.Complement;
            values[9] = costumer.Reference;
            values[10] = costumer.District;
            values[11] = costumer.City;
            values[12] = costumer.State;
            values[13] = costumer.Country;
            values[14] = costumer.Cep;

            if (costumer.DiscountCounter == -1)
            {
                values[15] = null;
            }
            else
            {
                values[15] = costumer.DiscountCounter.ToString();
            }

            if (costumer.DiscountAccumulated == -1)
            {
                values[16] = null;
            }
            else
            {
                values[16] = costumer.DiscountAccumulated.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            }

            values[17] = null;

            values[18] = GlobalVariables.User.Id.ToString();

            GenericCreate("costumer", columns, values);
        }

        internal static void UpdateCostumer(Costumer costumer)
        {
            string[] columns = new string[14];
            string[] values = new string[14];

            columns[0] = "name";
            columns[1] = "email";
            columns[2] = "phone_number";
            columns[3] = "is_phone_whatsapp";
            columns[4] = "sex";
            columns[5] = "street";
            columns[6] = "number";
            columns[7] = "complement";
            columns[8] = "reference";
            columns[9] = "district";
            columns[10] = "city";
            columns[11] = "state";
            columns[12] = "country";
            columns[13] = "cep";

            values[0] = costumer.Name;
            values[1] = costumer.Email;
            values[2] = costumer.PhoneNumber;
            values[3] = Convert.ToInt32(costumer.IsPhoneWhatsapp).ToString();
            values[4] = costumer.Sex.ToString();
            values[5] = costumer.Street;
            values[6] = costumer.Number;
            values[7] = costumer.Complement;
            values[8] = costumer.Reference;
            values[9] = costumer.District;
            values[10] = costumer.City;
            values[11] = costumer.State;
            values[12] = costumer.Country;
            values[13] = costumer.Cep;

            GenericUpdate("costumer", columns, values, "idcostumer", costumer.Id.ToString(), false);
        }

        internal static void UpdateCostumerDiscounts(Costumer costumer)
        {
            string[] columns = new string[2];
            string[] values = new string[2];

            columns[0] = "discount_counter";
            columns[1] = "discount_accumulated";

            if (costumer.DiscountCounter == -1)
            {
                values[0] = null;
            }
            else
            {
                values[0] = costumer.DiscountCounter.ToString();
            }

            if (costumer.DiscountAccumulated == -1)
            {
                values[1] = null;
            }
            else
            {
                values[1] = costumer.DiscountAccumulated.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            }

            GenericUpdate("costumer", columns, values, "idcostumer", costumer.Id.ToString(), false);
        }

        internal static void UpdateCostumerDebt(Costumer costumer)
        {
            string[] columns = new string[1];
            string[] values = new string[1];

            columns[0] = "debt";

            if (costumer.Debt <= 0)
            {
                values[0] = null;
            }
            else
            {
                values[0] = costumer.Debt.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            }

            GenericUpdate("costumer", columns, values, "idcostumer", costumer.Id.ToString(), false);
        }

        internal static void DeleteCostumerById(int id)
        {
            GenericUpdate("warranty", new string[] { "id_costumer" }, new string[] { null }, "id_costumer", id.ToString(), true);
            GenericUpdate("request", new string[] { "id_costumer" }, new string[] { null }, "id_costumer", id.ToString(), true);
            GenericDelete("costumer", "idcostumer", id.ToString(), false, false);
        }

        //--------------------------------------------------------------------------
        // WARRANTY'S CUD BEGIN
        //--------------------------------------------------------------------------
        internal static int CreateWarranty(Warranty warranty)
        {
            string[] values = new string[9];
            string[] columns = new string[9];

            columns[0] = "idwarranty";
            columns[1] = "number";
            columns[2] = "type";
            columns[3] = "started_in";
            columns[4] = "expires_in ";
            columns[5] = "observations ";
            columns[6] = "id_item";
            columns[7] = "id_costumer";
            columns[8] = "id_user";

            values[0] = null;
            values[1] = warranty.Number;
            values[2] = ObjectToSQL.ToBoolSql(warranty.Type);
            values[3] = ObjectToSQL.ToDateTimeSql(warranty.StartedIn);
            values[4] = ObjectToSQL.ToDateTimeSql(warranty.ExpiresIn);
            values[5] = warranty.Observations;
            values[6] = ObjectToSQL.ToIntSql(warranty.Id_Item);
            values[7] = ObjectToSQL.ToIntSql(warranty.Id_Costumer);
            values[8] = GlobalVariables.User.Id.ToString();

            GenericCreate("warranty", columns, values);

            return SqlToObject.ToInt(MySqlReader.ReadOnlyOneColumn("warranty", "idwarranty", new string[] { "number", "id_user" }, new string[] { warranty.Number, GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }));
        }

        internal static void UpdateWarranty(Warranty warranty)
        {
            string[] values = new string[5];
            string[] columns = new string[5];

            columns[0] = "type";
            columns[1] = "expires_in ";
            columns[2] = "observations ";
            columns[3] = "id_item";
            columns[4] = "id_costumer";

            values[0] = ObjectToSQL.ToBoolSql(warranty.Type);
            values[1] = ObjectToSQL.ToDateTimeSql(warranty.ExpiresIn);
            values[2] = warranty.Observations;
            values[3] = ObjectToSQL.ToIntSql(warranty.Id_Item);
            values[4] = ObjectToSQL.ToIntSql(warranty.Id_Costumer);

            GenericUpdate("warranty", columns, values, "idwarranty", warranty.Id.ToString(), false);
        }

        internal static void DeleteWarranty(int id)
        {            
            GenericDelete("warranty", "idwarranty", id.ToString(), false, false);
        }

        //--------------------------------------------------------------------------
        // REQUESTS' CUD BEGIN
        //--------------------------------------------------------------------------
        internal static int CreateRequest(Request request)
        {
            string[] values = new string[15];
            string[] columns = new string[15];

            columns[0] = "idrequest";
            columns[1] = "number";
            columns[2] = "value";
            columns[3] = "discount";
            columns[4] = "addition";
            columns[5] = "observations";
            columns[6] = "occurrences";
            columns[7] = "status";
            columns[8] = "started_in";
            columns[9] = "expires_in";
            columns[10] = "done_in";
            columns[11] = "is_delivery";
            columns[12] = "payment_type";
            columns[13] = "id_costumer ";
            columns[14] = "id_user";

            values[0] = null;
            values[1] = request.Number;
            values[2] = request.Value.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);

            if(request.Discount == -1)
            {
                values[3] = null;
            }
            else
            {
                values[3] = request.Discount.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            }

            if (request.Addition == -1)
            {
                values[4] = null;
            }
            else
            {
                values[4] = request.Addition.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            }

            values[5] = request.Observations;
            values[6] = request.Occurrences;
            values[7] = request.Status.ToString();
            values[8] = request.StartedIn.ToString("yyyy/MM/dd HH:mm:ss");

            DateTime nullDate = new DateTime(1, 1, 1, 0, 0, 0);
            if(DateTime.Compare(request.ExpiresIn, nullDate) == 0) //Return 0 equals to same Date for each one
            {
                values[9] = null;
            }
            else
            {
                values[9] = request.ExpiresIn.ToString("yyyy/MM/dd HH:mm:ss");
            }

            if (DateTime.Compare(request.DoneIn, nullDate) == 0) //Return 0 equals to same Date for each one
            {
                values[10] = null;
            }
            else
            {
                values[10] = request.DoneIn.ToString("yyyy/MM/dd HH:mm:ss");
            }

            values[11] = Convert.ToInt32(request.IsDelivery).ToString();
            values[12] = request.PaymentType.ToString();
            values[13] = request.Id_Costumer.ToString();
            values[14] = GlobalVariables.User.Id.ToString();

            GenericCreate("request", columns, values);

            string aux = MySqlReader.ReadOnlyOneColumn("request", "idrequest", new string[] { "number", "id_user" }, new string[] { request.Number.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false });
            request.Id = Int32.Parse(aux);

            if(request.Products.Count != 0)
            {
                string[] valuesRp = new string[6];
                string[] columnsRp = new string[6];

                columnsRp[0] = "idrp";
                columnsRp[1] = "id_request";
                columnsRp[2] = "id_product";
                columnsRp[3] = "quantity";
                columnsRp[4] = "price";
                columnsRp[5] = "id_user";

                valuesRp[0] = null;
                valuesRp[1] = request.Id.ToString();
                valuesRp[5] = GlobalVariables.User.Id.ToString();

                foreach (Request_Products item in request.Products)
                {
                    valuesRp[2] = item.Id_Product.ToString();

                    valuesRp[3] = item.Quantity.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture);

                    valuesRp[4] = item.Price.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);

                    GenericCreate("request_products", columnsRp, valuesRp);
                }
            }

            if(request.Jobs.Count != 0)
            {
                string[] valuesRj = new string[5];
                string[] columnsRj = new string[5];

                columnsRj[0] = "idrj";
                columnsRj[1] = "id_request";
                columnsRj[2] = "id_job";
                columnsRj[3] = "price";
                columnsRj[4] = "id_user";

                valuesRj[0] = null;
                valuesRj[1] = request.Id.ToString();
                valuesRj[4] = GlobalVariables.User.Id.ToString();

                foreach (Request_Jobs item in request.Jobs)
                {
                    valuesRj[2] = item.Id_Job.ToString();

                    valuesRj[3] = item.Price.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);

                    GenericCreate("request_jobs", columnsRj, valuesRj);
                }
            }

            return Int32.Parse(MySqlReader.ReadOnlyOneColumn("request", "idrequest", new string[] { "number", "id_user" }, new string[] { request.Number, GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }));
        }

        internal static int CreateRequestProducts(int idRequest, Request_Products por)
        {
            string[] values = new string[6];
            string[] columns = new string[6];

            columns[0] = "idrp";
            columns[1] = "id_request";
            columns[2] = "id_product";
            columns[3] = "quantity";
            columns[4] = "price";
            columns[5] = "id_user";

            values[0] = null;
            values[1] = idRequest.ToString();
            values[2] = por.Id_Product.ToString();
            values[3] = ObjectToSQL.ToDecimalSql_ThreeDecimals(por.Quantity);
            values[4] = ObjectToSQL.ToDecimalSql_TwoDecimals(por.Price);
            values[5] = GlobalVariables.User.Id.ToString();

            GenericCreate("request_products", columns, values);

            return Int32.Parse(MySqlReader.ReadOnlyOneColumn("request_products", "idrp", new string[] { "id_request", "id_product" }, new string[] { idRequest.ToString(), por.Id_Product.ToString() }, new string[] { "AND" }, new bool[] { false, false }));
        }

        internal static int CreateRequestJobs(int idRequest, Request_Jobs jor)
        {
            string[] values = new string[5];
            string[] columns = new string[5];

            columns[0] = "idrj";
            columns[1] = "id_request";
            columns[2] = "id_job";
            columns[3] = "price";
            columns[4] = "id_user";

            values[0] = null;
            values[1] = idRequest.ToString();
            values[2] = jor.Id_Job.ToString(); ;
            values[3] = ObjectToSQL.ToDecimalSql_TwoDecimals(jor.Price);
            values[4] = GlobalVariables.User.Id.ToString();

            GenericCreate("request_jobs", columns, values);

            return Int32.Parse(MySqlReader.ReadOnlyOneColumn("request_jobs", "idrj", new string[] { "id_request", "id_job" }, new string[] { idRequest.ToString(), jor.Id_Job.ToString() }, new string[] { "AND" }, new bool[] { false, false }));
        }

        internal static void UpdateRequest(Request request)
        {
            string[] values = new string[9];
            string[] columns = new string[9];

            columns[0] = "value";
            columns[1] = "discount";
            columns[2] = "addition";
            columns[3] = "observations";
            columns[4] = "occurrences";
            columns[5] = "status";
            columns[6] = "expires_in";
            columns[7] = "is_delivery";
            columns[8] = "payment_type";

            values[0] = ObjectToSQL.ToDecimalSql_TwoDecimals(request.Value);
            values[1] = ObjectToSQL.ToDecimalSql_TwoDecimals(request.Discount);           
            values[2] = ObjectToSQL.ToDecimalSql_TwoDecimals(request.Addition);
            values[3] = request.Observations;
            values[4] = request.Occurrences;
            values[5] = request.Status.ToString();

            DateTime nullDate = new DateTime(1, 1, 1, 0, 0, 0);
            if (DateTime.Compare(request.ExpiresIn, nullDate) == 0)
            {
                values[6] = null;
            }
            else
            {
                values[6] = request.ExpiresIn.ToString("yyyy/MM/dd HH:mm:ss");
            }

            values[7] = Convert.ToInt32(request.IsDelivery).ToString();
            values[8] = request.PaymentType.ToString();

            GenericUpdate("request", columns, values, new string[] { "idrequest", "id_user" }, new string[] { request.Id.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false}, false);
        }

        internal static void UpdateRequestOccurrences(int id, string newOccurrences)
        {
            GenericUpdate("request", new string[] { "occurrences" }, new string[] { newOccurrences }, new string[] { "idrequest" , "id_user" }, new string[] { id.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }, false);
        }

        internal static void UpdateRequestStatus(int id, char newStatus)
        {
            GenericUpdate("request", new string[] { "status" }, new string[] { newStatus.ToString() }, new string[] { "idrequest", "id_user" }, new string[] { id.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }, false);
        }

        internal static void UpdateRequestDoneIn(int id, DateTime newDoneIn)
        {
            GenericUpdate("request", new string[] { "done_in" }, new string[] { newDoneIn.ToString("yyyy/MM/dd HH:mm:ss") }, new string[] { "idrequest", "id_user" }, new string[] { id.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }, false);
        }

        internal static void UpdateRequestProductsQuantity(int idRequest, Request_Products por)
        {
            string result = MySqlReader.ReadOnlyOneColumn("request_products", "idrp", new string[] { "id_request", "id_product", "id_user" }, new string[] { idRequest.ToString(), por.Id_Product.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND", "AND" }, new bool[] { false, false, false });
            
            GenericUpdate("request_products", new string[] { "quantity" }, new string[] { ObjectToSQL.ToDecimalSql_ThreeDecimals(por.Quantity) }, new string[] { "idrp", "id_user" }, new string[] { result, GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }, false);
        }

        internal static void DeleteRequestById(int id)
        {
            GenericDelete("request_products", new string[] { "id_request", "id_user" }, new string[] { id.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }, true);
            GenericDelete("request_jobs", new string[] { "id_request", "id_user" }, new string[] { id.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }, true);
            GenericDelete("request", new string[] { "idrequest", "id_user" }, new string[] { id.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }, false);
        }

        internal static void DeleteRequestProducts(int id_request, Request_Products por)
        {
            GenericDelete("request_products", new string[] { "id_request", "id_product", "id_user" }, new string[] { id_request.ToString(), por.Id_Product.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND", "AND" }, new bool[] { false, false, false }, false);
        }

        internal static void DeleteRequestJobs(int id_request, Request_Jobs jor)
        {
            GenericDelete("request_jobs", new string[] { "id_request", "id_job", "id_user" }, new string[] { id_request.ToString(), jor.Id_Job.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND", "AND" }, new bool[] { false, false, false }, false);
        }

        // ---------------------------------------------------------
        //COMMERCE'S STATS UPDATE ---------------------------------
        //------------------------------------------------------------
        internal static void UpdateCommercerStats()
        {
            string[] columns = new string[7];
            string[] values = new string[7];

            columns[0] = "profits_amount";
            columns[1] = "requests_done_counter";
            columns[2] = "requests_done_amount";
            columns[3] = "products_sales_counter";
            columns[4] = "products_sales_amount";
            columns[5] = "jobs_sales_counter";
            columns[6] = "jobs_sales_amount ";

            values[0] = ObjectToSQL.ToDecimalSql_TwoDecimals(GlobalVariables.SalesRecords.Profits_amount);

            values[1] = ObjectToSQL.ToIntSql(GlobalVariables.SalesRecords.Requests_done_counter_total);
            values[2] = ObjectToSQL.ToDecimalSql_TwoDecimals(GlobalVariables.SalesRecords.Requests_done_amount_total);

            values[3] = ObjectToSQL.ToIntSql(GlobalVariables.SalesRecords.Products_sales_counter_total);
            values[4] = ObjectToSQL.ToDecimalSql_TwoDecimals(GlobalVariables.SalesRecords.Products_sales_amount_total);

            values[5] = ObjectToSQL.ToIntSql(GlobalVariables.SalesRecords.Jobs_sales_counter_total);
            values[6] = ObjectToSQL.ToDecimalSql_TwoDecimals(GlobalVariables.SalesRecords.Jobs_sales_amount_total);

            GenericUpdate("commerce_stats", columns, values, "id_user", GlobalVariables.User.Id.ToString(), false);
        }

        //------------------------------------------------------
        //DAY'S RECORD CU BEGIN -----------------------------------
        //------------------------------------------------------
        internal static int CreateDaysRecord(DayRecord dailySale)
        {
            string[] columns = new string[4];
            string[] values = new string[4];

            columns[0] = "idds";
            columns[1] = "date";
            columns[2] = "profit";
            columns[3] = "id_user";

            values[0] = null;
            values[1] = ObjectToSQL.ToDateSql(dailySale.Date);
            values[2] = ObjectToSQL.ToDecimalSql_TwoDecimals(dailySale.Profit);
            values[3] = GlobalVariables.User.Id.ToString();

            GenericCreate("daily_sale", columns, values);

            return Int32.Parse(MySqlReader.ReadOnlyOneColumn("daily_sale", "idds", new string[] { "date", "profit", "id_user" }, new string[] { ObjectToSQL.ToDateSql(dailySale.Date), ObjectToSQL.ToDecimalSql_TwoDecimals(dailySale.Profit), GlobalVariables.User.Id.ToString() }, new string[] { "AND", "AND" }, new bool[] { true, false, false }));
        }

        internal static void UpdateDaysRecordProfit(DayRecord daysRecord)
        {
            string[] columns = new string[1];
            string[] values = new string[1];

            columns[0] = "profit";
            values[0] = ObjectToSQL.ToDecimalSql_TwoDecimals(daysRecord.Profit);

            GenericUpdate("daily_sale", columns, values, "idds", daysRecord.Id.ToString(), false);
        }

        //-----------------------------------------------------------------
        //FEEDBACK C BEGIN ------------------------------------------------
        //-----------------------------------------------------------------
        internal static void CreateFeedback(string text, byte type)
        {
            string[] columns = new string[4];
            string[] values = new string[4];

            columns[0] = "iduf";
            columns[1] = "type";
            columns[2] = "text";
            columns[3] = "id_user";

            values[0] = null;
            values[1] = type.ToString();
            values[2] = text;
            values[3] = GlobalVariables.User.Id.ToString();

            GenericCreate("user_feedback", columns, values);
        }

        //-----------------------------------------------------------------
        // ADMIN MESSAGE UD BEGIN ------------------------------------------
        //-----------------------------------------------------------------
        internal static void MarkAdminMessageAsRead(int idAm)
        {
            string[] column = { "read_in" };
            string[] value = { ObjectToSQL.ToDateTimeSql(DateTime.Now) };

            GenericUpdate("admin_message", column, value, new string[] { "idam", "id_user" }, new string[] { idAm.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }, false);
        }

        internal static void DeleteAdminMessage(int idAm)
        {
            GenericDelete("admin_message", new string[] { "idam", "id_user" }, new string[] { idAm.ToString(), GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }, false);
        }
    }
}
