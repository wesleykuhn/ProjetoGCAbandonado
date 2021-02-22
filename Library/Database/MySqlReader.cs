using System;
using System.Collections.Generic;
using System.Threading;
using GC.Library.Objects;
using MySql.Data.MySqlClient;
using GC.Library.Translators;
using GC.Library.Entities;
using GC.Library.Objects.SubObjects.Product;
using GC.Library.Objects.SubObjects.Request;

namespace GC.Library.Database
{
    internal static class MySqlReader
    {
        private static MySqlDataReader ConnectionHandler(MySqlCommand sqlCommand)
        {
            MySqlDataReader reader = null;

            try
            {
                GlobalVariables.MySqlConnection.Open();

                reader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                GlobalModals.FRM_MessageAndProgressBar tryAgain = new GlobalModals.FRM_MessageAndProgressBar("Seu computador perdeu a conexão com a internet. Por favor, aguarde enquanto o programa tenta restabelecer a conexão...", 2);
                tryAgain.Show();

                bool success = false;
                byte counter = 0;

                GlobalVariables.MySqlConnection.Close();

                string errorMessage = ex.Message;
                Errors.Care.AppendOnErrorLogFile(errorMessage);

                while (!success)
                {
                    counter++;
                    if (counter == 4)
                    {
                        GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Infelizmente não foi possível recuperar sua conexão com a internet. Por favor, verifique o que deve estar causando este erro. Caso seu computador tenha acesso à internet e ainda assim você estiver recebendo essa mensagem entre em contato com a administração por favor.", 2);
                        messOk.Show();

                        tryAgain.CustomClose();

                        Environment.Exit(0);
                    }

                    Thread.Sleep(30000);

                    success = MySqlNonQuery.TestConnection(false);
                }

                tryAgain.CustomClose();

                GlobalModals.FRM_Message msg = new GlobalModals.FRM_Message("Conexão com a internet restaurada com sucesso!", 5, 6000);
                msg.Show();

                try
                {
                    GlobalVariables.MySqlConnection.Open();

                    reader = sqlCommand.ExecuteReader();
                }
                catch
                {
                    GlobalVariables.MySqlConnection.Close();

                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Houve um erro fatal ao tentar reconectar o programa à internet. Por favor, tente novamente mais tarde!", 2);
                    messOk.ShowDialog();

                    Environment.Exit(0);
                }
            }

            return reader;
        }

        internal static bool ObjectExistsInDB(string table, string idColumnName, string objectId)
        {        
            bool result = false;

            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM " + table + " WHERE " + idColumnName +
                " = @objId;", GlobalVariables.MySqlConnection);
            sqlCommand.Parameters.AddWithValue("@objId", objectId);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                if (reader[idColumnName].ToString().Length > 0) result = true;
            }

            GlobalVariables.MySqlConnection.Close();

            return result;
        }

        /// <summary>
        /// To avoid the abulse of use the account for one month and create other in other month.
        /// </summary>
        /// <returns>True if the user can create a new account or false if he/she can't.</returns>
        internal static bool AntiAccountCreationAbulse()
        {
            string mac = Collectors.MacNumber.GetEnderecoMAC1();

            //Chech if theres more than one account
            int accountsCounter = int.Parse(CountRowsOnTable("user", new string[] { "mac" }, new string[] { mac }, null, new bool[] { true }));

            if (accountsCounter < 1) return true;
            else if (accountsCounter == 1)
            {
                // <--  User can't create another account if there's one already created and he/she didn't paid it! -------->
                int idUser = -1;

                
                MySqlCommand sqlCommand = new MySqlCommand("SELECT iduser FROM user WHERE mac = '" + mac + "';", GlobalVariables.MySqlConnection);
                MySqlDataReader reader = ConnectionHandler(sqlCommand);

                while (reader.Read())
                {
                    idUser = SqlToObject.ToInt(reader["iduser"].ToString());
                }

                GlobalVariables.MySqlConnection.Close();

                DateTime dateOfExpiration = new DateTime();
               
                sqlCommand = new MySqlCommand("SELECT expiration FROM user_metadata WHERE id_user = " + idUser.ToString() + ";", GlobalVariables.MySqlConnection);
                MySqlDataReader reader2 = ConnectionHandler(sqlCommand);

                while (reader2.Read())
                {
                    dateOfExpiration = SqlToObject.ToDateTime(reader2["expiration"].ToString());
                }

                GlobalVariables.MySqlConnection.Close();

                TimeSpan aux = dateOfExpiration.Subtract(DateTime.Now);
                double dif = aux.TotalDays;
                if (dif < 0) return false;

                // <--  User can't create another account if there's one already created, paid and it's was created only 10 days ago!
                DateTime joined = new DateTime();

                
                sqlCommand = new MySqlCommand("SELECT joined FROM user WHERE iduser = " + idUser.ToString() + ";", GlobalVariables.MySqlConnection);
                MySqlDataReader reader3 = ConnectionHandler(sqlCommand);

                while (reader3.Read())
                {
                    joined = SqlToObject.ToDate(reader3["joined"].ToString());
                }

                GlobalVariables.MySqlConnection.Close();

                if (Checkers.Structs.IsDateNewerOrEqualsThanDate(joined, DateTime.Now.AddDays(-10)))
                {
                    return false;
                }

                else return true;
            }
            else
            {
                List<int> ids = new List<int>();

                // <--  User can't create another account if there's one already created and he/she didn't paid it! -------->
                
                MySqlCommand sqlCommand = new MySqlCommand("SELECT iduser FROM user WHERE mac = '" + mac + "';", GlobalVariables.MySqlConnection);
                MySqlDataReader reader = ConnectionHandler(sqlCommand);

                while (reader.Read())
                {
                    ids.Add(SqlToObject.ToInt(reader["iduser"].ToString()));
                }

                GlobalVariables.MySqlConnection.Close();

                DateTime dateOfExpiration = new DateTime();

                foreach (int id in ids)
                {
                    
                    sqlCommand = new MySqlCommand("SELECT expiration FROM user_metadata WHERE id_user = " + id.ToString() + ";", GlobalVariables.MySqlConnection);
                    MySqlDataReader reader2 = ConnectionHandler(sqlCommand);

                    while (reader2.Read())
                    {
                        dateOfExpiration = SqlToObject.ToDateTime(reader2["expiration"].ToString());
                    }

                    GlobalVariables.MySqlConnection.Close();

                    TimeSpan aux = dateOfExpiration.Subtract(DateTime.Now);
                    double dif = aux.TotalDays;
                    if (dif < 0) return false;

                    // <--  User can't create another account if there's other already created, paid and it's was created only 10 days ago!
                    DateTime joined = new DateTime();

                    
                    sqlCommand = new MySqlCommand("SELECT joined FROM user WHERE iduser = " + id.ToString() + ";", GlobalVariables.MySqlConnection);
                    MySqlDataReader reader3 = ConnectionHandler(sqlCommand);

                    while (reader3.Read())
                    {
                        joined = SqlToObject.ToDate(reader3["joined"].ToString());
                    }

                    GlobalVariables.MySqlConnection.Close();

                    if (Checkers.Structs.IsDateNewerOrEqualsThanDate(joined, DateTime.Now.AddDays(-10)))
                    {
                        return false;
                    }
                }
                
                return true;
            }         
        }

        /// <summary>
        /// This is part of the auto-update system.
        /// </summary>
        /// <returns>Returns a string with the version needed to download if there's need an update. Else returns null.</returns>
        internal static string CheckForUpdaterUpdate()
        {
            string mySqlNonQuery_updater_version = "";
            
            MySqlCommand sqlCommand = new MySqlCommand("SELECT current_version FROM updater_metadata WHERE idum = 1;", GlobalVariables.MySqlConnection);
            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                mySqlNonQuery_updater_version = reader["current_version"].ToString();
            }

            GlobalVariables.MySqlConnection.Close();

            System.Diagnostics.FileVersionInfo versionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(@".\GCUpdater.exe");
            string versionStr = versionInfo.ProductVersion;

            if (versionStr != mySqlNonQuery_updater_version)
            {
                return mySqlNonQuery_updater_version.Replace('.', '_');
            }
            else return null;         
        }

        /// <summary>
        /// This is part of the auto-update system.
        /// </summary>
        /// <returns>True if the program needs to be updates. False if doesn't.</returns>
        internal static string CheckForProgramUpdate()
        { 
            string MySqlNonQuery_current_version = "";
     
            MySqlCommand sqlCommand = new MySqlCommand("SELECT current_version FROM program_version WHERE idpv = 1;", GlobalVariables.MySqlConnection);
            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                MySqlNonQuery_current_version = reader["current_version"].ToString();
            }

            GlobalVariables.MySqlConnection.Close();

            string thisVersion = System.Windows.Forms.Application.ProductVersion; //1.0.0.0

            if (thisVersion != MySqlNonQuery_current_version)
            {
                return MySqlNonQuery_current_version;
            }
            else return null;
        }

        internal static bool CheckForNewAdminMessages()
        {
            bool hasNew = false;

            MySqlCommand sqlCommand = new MySqlCommand("SELECT idam, delivered_in, read_in, " +
                "subject, body, color FROM admin_message WHERE id_user = @userid AND read_in IS NOT NULL;", GlobalVariables.MySqlConnection);
            sqlCommand.Parameters.AddWithValue("@userid", GlobalVariables.User.Id);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            DateTime delivered_in, read_in;
            int id;
            byte color;
            string body, subject;

            while (reader.Read())
            {
                id = SqlToObject.ToInt(reader["idam"].ToString());
                delivered_in = SqlToObject.ToDateTime(reader["delivered_in"].ToString());
                read_in = SqlToObject.ToDateTime(reader["read_in"].ToString());
                subject = reader["subject"].ToString();
                body = reader["body"].ToString();
                color = SqlToObject.ToByte(reader["color"].ToString());

                if(!GlobalVariables.AdminMessages.Exists(x => x.Id == id))
                {
                    GlobalVariables.AdminMessages.Add(new AdminMessage(id, delivered_in, read_in, subject, body, color));
                    hasNew = true;
                }
            }

            GlobalVariables.MySqlConnection.Close();

            return hasNew;
        }

        internal static double GetAccountTypePrice(char accountType)
        {
            MySqlCommand sqlCommand = new MySqlCommand("SELECT recharge_price FROM user_account_recharge_constructor WHERE account_type = @type;", GlobalVariables.MySqlConnection);
            sqlCommand.Parameters.AddWithValue("@type", accountType);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            double price = 0;

            while (reader.Read())
            {
                price = SqlToObject.ToDouble(reader["recharge_price"].ToString());
            }

            GlobalVariables.MySqlConnection.Close();

            return price;
        }

        internal static bool CheckPayment()
        {
           DateTime dateOfExpiration = SqlToObject.ToDate(ReadOnlyOneColumn("user_metadata", "expiration", new string[] { "id_user" }, new string[] { GlobalVariables.User.Id.ToString() }, null, new bool[] { false }));

            TimeSpan aux = dateOfExpiration.Subtract(DateTime.Now);
            double dif = aux.TotalDays;
            
            if (dif < 0) return false;
            else return true;
        }

        internal static bool CheckActive()
        {
            return SqlToObject.ToBool(ReadOnlyOneColumn("user", "active", new string[] { "iduser" }, new string[] { GlobalVariables.User.Id.ToString() }, null, new bool[] { false }));
        }

        /// <summary>
        /// Read only one value of the database.
        /// </summary>
        /// <param name="table">The name of the table.</param>
        /// <param name="column">The name of the column.</param>
        /// <param name="conditonColumn">The value after the WHERE in the SQL Syntax.</param>
        /// <param name="conditonValue">The value after the Equals simbol in the SQL Syntax.</param>
        /// <returns>The requested value in string format.</returns>
        internal static string ReadOnlyOneColumn(string table, string column, string[] conditonColumn, string[] conditonValue, string[] conditionalAndOr, bool[] conditonValueQuotes)
        {
            string command = "SELECT " + column + " FROM " + table + " WHERE ", result = "";
            int counter = 0;
            while (counter < conditonColumn.Length)
            {
                if (conditonColumn.Length > 1)
                {
                    if(conditonValue[counter] == null)
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
                if(conditonValue[counter] != null && conditonValue[counter] != "")
                {
                    if (!conditonValueQuotes[counter])
                    {
                        sqlCommand.Parameters.AddWithValue("value" + counter, conditonValue[counter]);
                    }                    
                }
                counter++;
            }

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                result = reader[column].ToString();
            }

            GlobalVariables.MySqlConnection.Close();

            return result;
        }

        internal static string CountRowsOnTable(string table, string[] conditonColumn, string[] conditonValue, string[] conditionalAndOr, bool[] conditonValueQuotes)
        {
            string command = "SELECT COUNT(*) FROM " + table + " WHERE ";

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

            int count = -1;

            MySqlDataReader reader = ConnectionHandler(sqlCommand);
            while (reader.Read())
            {
                count = SqlToObject.ToInt(reader["count(*)"].ToString());
            }

            GlobalVariables.MySqlConnection.Close();

            return count.ToString();
        }

        /// <summary>
        /// Check if the user already made 5 feedbacks.
        /// </summary>
        /// <returns>True if the user can continue with the new feedbacks else false if not.</returns>
        internal static bool CheckFeedbackLimit()
        {   
            MySqlCommand sqlCommand = new MySqlCommand("SELECT iduf FROM user_feedback WHERE id_user = @iduser;", GlobalVariables.MySqlConnection);
            sqlCommand.Parameters.AddWithValue("@iduser", GlobalVariables.User.Id);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            byte counter = 0;
            while (reader.Read())
            {
                if (reader["iduf"].ToString().Length > 0) counter++;
            }
            
            if (counter < 5) return true;
            else return false;
        }

        //Auth and New accounts validators ---------------------------------------------->
        internal static bool IsAuthValid(string typedEmail, string typedPassword)
        {
            string password = "";
            bool result = false;
            MySqlCommand sqlCommand = new MySqlCommand("SELECT password FROM user WHERE email = @email;", GlobalVariables.MySqlConnection);
            sqlCommand.Parameters.AddWithValue("@email", typedEmail);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                password = reader["password"].ToString();
            }

            GlobalVariables.MySqlConnection.Close();

            if (typedPassword == WKCrypto.W710(password))
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Check if in the last 24 hours the user made a request to renew his account.
        /// </summary>
        /// <returns>If the user can make a request returns true else returns false.</returns>
        internal static bool CheckLastRenewRequest()
        {
            MySqlCommand sqlCommand = new MySqlCommand("SELECT last_renew_request FROM user WHERE iduser = " + GlobalVariables.User.Id.ToString() + ";", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            DateTime lastRenewRequest = new DateTime();

            bool empty = true;

            while (reader.Read())
            {
                lastRenewRequest  = SqlToObject.ToDateTime(reader["last_renew_request"].ToString());

                empty = false;
            }

            GlobalVariables.MySqlConnection.Close();

            if (empty) return false;

            if (Checkers.Structs.IsDateTimeNull(lastRenewRequest)) return true;

            TimeSpan interval = DateTime.Now.Subtract(lastRenewRequest);

            if (interval.TotalHours > 24) return true;
            else return false;
        }

        internal static bool EmailAlreadyExists(string typedEmail)
        {
            bool result = false;
            MySqlCommand sqlCommand = new MySqlCommand("SELECT email FROM user;", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                if (typedEmail == reader["email"].ToString()) result = true;
            }

            GlobalVariables.MySqlConnection.Close();

            return result;
        }

        internal static bool PhoneNumberExists(string typedNumber, string userEmail)
        {
            string result = ReadOnlyOneColumn("user", "phone_number", new string[] { "email" }, new string[] { userEmail }, null, new bool[] { false });

            if (typedNumber != result) return false;
            else return true;
        }

        internal static int MacAddressCounter(string mac)
        {       
            int counter = 0;
            MySqlCommand sqlCommand = new MySqlCommand("SELECT mac FROM user;", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);
            while (reader.Read())
            {
                if (mac == reader["mac"].ToString()) counter++;
            }

            GlobalVariables.MySqlConnection.Close();

            return counter;
        }

        // Entities readers -------------------------------------------------------------------->
        internal static  void ReadAdminMessages()
        {
            MySqlCommand sqlCommand = new MySqlCommand("SELECT idam, delivered_in, read_in, " +
                "subject, body, color FROM admin_message WHERE id_user = " + GlobalVariables.User.Id.ToString() + ";", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            DateTime delivered_in, read_in;
            int id;
            byte color;
            string body, subject;

            while (reader.Read())
            {
                id = SqlToObject.ToInt(reader["idam"].ToString());
                delivered_in = SqlToObject.ToDateTime(reader["delivered_in"].ToString());
                read_in = SqlToObject.ToDateTime(reader["read_in"].ToString());
                subject = reader["subject"].ToString();
                body = reader["body"].ToString();
                color = SqlToObject.ToByte(reader["color"].ToString());

                GlobalVariables.AdminMessages.Add(new AdminMessage(id, delivered_in, read_in, subject, body, color));
            }

            GlobalVariables.MySqlConnection.Close();
        }

        internal static void ReadAnnounce()
        {   
            MySqlCommand sqlCommand = new MySqlCommand("SELECT body FROM announce;", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            string body;

            while (reader.Read())
            {
                body = reader["body"].ToString();

                GlobalVariables.Announce = new Announce(body);
            }

            GlobalVariables.MySqlConnection.Close();
        }

        internal static void ReadUser(string email)
        {           
            string name = null, password = null, phone_number = null, cnpj = null, mac = null;
            int id = -1, request_counter = 0, warranty_counter = 0;
            DateTime joined = new DateTime();
            MySqlCommand sqlCommand = new MySqlCommand("SELECT iduser, name, password, phone_number, cnpj, joined, mac, warranty_counter, " +
            "request_counter FROM user WHERE email = @email;", GlobalVariables.MySqlConnection);
            sqlCommand.Parameters.AddWithValue("@email", email);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);      

            while (reader.Read())
            {
                id = SqlToObject.ToInt(reader["iduser"].ToString());
                name = reader["name"].ToString();
                password = WKCrypto.W710(reader["password"].ToString());
                phone_number = reader["phone_number"].ToString();
                cnpj = reader["cnpj"].ToString();
                joined = SqlToObject.ToDateTime(reader["joined"].ToString());
                mac = reader["mac"].ToString();
                warranty_counter = SqlToObject.ToInt(reader["warranty_counter"].ToString());
                request_counter = SqlToObject.ToInt(reader["request_counter"].ToString());                              
            }

            GlobalVariables.MySqlConnection.Close();

            char accountType = 'P';
            int registeredCostumers = 0, registered_products = 0, registered_jobs = 0, registered_suppliers = 0;            
            sqlCommand = new MySqlCommand("SELECT account_type, registered_costumers, registered_products, registered_jobs, registered_suppliers FROM user_metadata " +
                "WHERE id_user = " + id.ToString() + ";", GlobalVariables.MySqlConnection);
            reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                accountType = SqlToObject.ToChar(reader["account_type"].ToString());
                registeredCostumers = SqlToObject.ToInt(reader["registered_costumers"].ToString());
                registered_products = SqlToObject.ToInt(reader["registered_products"].ToString());
                registered_jobs = SqlToObject.ToInt(reader["registered_jobs"].ToString());
                registered_suppliers = SqlToObject.ToInt(reader["registered_suppliers"].ToString());

                GlobalVariables.User = new User(id, name, email, password, phone_number, cnpj, joined, mac, warranty_counter, request_counter, accountType);                           
            }

            GlobalVariables.MySqlConnection.Close();

            // Reading limits
            int temp_reminders, temp_requests, temp_warranties, temp_dailyrecords;
            int fixed_costumers, fixed_products, fixed_jobs, fixed_suppliers;         

            sqlCommand = new MySqlCommand("SELECT temp_reminders, temp_requests, temp_warranties, temp_dailyrecords, fixed_costumers, fixed_products, fixed_jobs, fixed_suppliers FROM db_storage_control WHERE account_type = '" + accountType + "';", GlobalVariables.MySqlConnection);
            reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                temp_reminders = SqlToObject.ToInt(reader["temp_reminders"].ToString());
                temp_requests = SqlToObject.ToInt(reader["temp_requests"].ToString());
                temp_warranties = SqlToObject.ToInt(reader["temp_warranties"].ToString());
                temp_dailyrecords = SqlToObject.ToInt(reader["temp_dailyrecords"].ToString());
                fixed_costumers = SqlToObject.ToInt(reader["fixed_costumers"].ToString());
                fixed_products = SqlToObject.ToInt(reader["fixed_products"].ToString());
                fixed_jobs = SqlToObject.ToInt(reader["fixed_jobs"].ToString());
                fixed_suppliers = SqlToObject.ToInt(reader["fixed_suppliers"].ToString());

                GlobalVariables.FragileData = new FragileData(registeredCostumers, registered_products, registered_jobs, registered_suppliers, fixed_costumers, fixed_products, fixed_jobs, fixed_suppliers, temp_dailyrecords, temp_warranties, temp_requests, temp_reminders);
            }            

            GlobalVariables.MySqlConnection.Close();
        }

        internal static int GetUserId(string email)
        {
            int id = -1;

            MySqlCommand sqlCommand = new MySqlCommand("SELECT iduser FROM user WHERE email = @email;", GlobalVariables.MySqlConnection);
            sqlCommand.Parameters.AddWithValue("@email", email);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                id = SqlToObject.ToInt(reader["iduser"].ToString());
            }

            GlobalVariables.MySqlConnection.Close();

            return id;
        }

        internal static void ReadConfiguration()
        {
            bool enable_animations = true, enable_windows_voice_alerts = true, enable_modal_alerts = true, enable_request_products_separation_helper = true, enable_critical_stock_system = true;
            bool auto_clear_cancelled_req = true;
            int days_before_expiration = 30;
            DateTime last_routine_operations_fortnight;

            MySqlCommand sqlCommand = new MySqlCommand("SELECT enable_animations, enable_windows_voice_alerts, enable_modal_alerts, last_routine_operations_fortnight, enable_request_products_separation_helper, auto_clear_cancelled_req, enable_critical_stock_system, days_before_expiration FROM user_configuration WHERE id_user = '" + GlobalVariables.User.Id.ToString() + "';", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);
            while (reader.Read())
            {
                enable_animations = SqlToObject.ToBool(reader["enable_animations"].ToString());
                enable_windows_voice_alerts = SqlToObject.ToBool(reader["enable_windows_voice_alerts"].ToString());
                enable_modal_alerts = SqlToObject.ToBool(reader["enable_modal_alerts"].ToString());
                last_routine_operations_fortnight = SqlToObject.ToDateTime(reader["last_routine_operations_fortnight"].ToString());
                enable_request_products_separation_helper = SqlToObject.ToBool(reader["enable_request_products_separation_helper"].ToString());
                auto_clear_cancelled_req = SqlToObject.ToBool(reader["auto_clear_cancelled_req"].ToString());
                days_before_expiration = SqlToObject.ToInt(reader["days_before_expiration"].ToString());
                enable_critical_stock_system = SqlToObject.ToBool(reader["enable_critical_stock_system"].ToString());

                GlobalVariables.Configuration = new Configuration(enable_animations, enable_windows_voice_alerts, enable_modal_alerts, last_routine_operations_fortnight, enable_request_products_separation_helper, auto_clear_cancelled_req, days_before_expiration, enable_critical_stock_system);
            }

            GlobalVariables.MySqlConnection.Close();
        }

        internal static void ReadReminders()
        {
            int id;
            string title, observations;
            byte red, green, blue;
            DateTime start;
            DateTime end;
            DateTime created_in;

            MySqlCommand sqlCommand = new MySqlCommand("SELECT idreminder, start, end, title, observations, red, green, blue, created_in FROM reminder WHERE id_user = " + GlobalVariables.User.Id.ToString() + ";", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                // Old reminders are still on DB Shield
                created_in = SqlToObject.ToDateTime(reader["created_in"].ToString());
                if (Reminder.ReminderIsOld(created_in)) continue;

                id = SqlToObject.ToInt(reader["idreminder"].ToString());
                start = SqlToObject.ToDateTime(reader["start"].ToString());
                end = SqlToObject.ToDateTime(reader["end"].ToString());
                title = SqlToObject.ToString(reader["title"].ToString());
                observations = SqlToObject.ToString(reader["observations"].ToString());
                red = SqlToObject.ToByte(reader["red"].ToString());
                green = SqlToObject.ToByte(reader["green"].ToString());
                blue = SqlToObject.ToByte(reader["blue"].ToString());                

                GlobalVariables.Reminders.Add(new Reminder(id, start, end, title, observations, red, green, blue, created_in));
            }

            GlobalVariables.MySqlConnection.Close();
        }

        internal static void ReadProducts()
        {
            int id, pack_quantity, id_supplier;
            string code, description, position;
            double ideal_stock, price, weight_kg;
            MySqlCommand sqlCommand = new MySqlCommand("SELECT idproduct, code, description, ideal_stock, price, position," +
                " pack_quantity, weight_kg, id_supplier FROM product WHERE id_user = " + GlobalVariables.User.Id.ToString() + ";", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                id = SqlToObject.ToInt(reader["idproduct"].ToString());
                code = reader["code"].ToString();
                description = reader["description"].ToString();
                ideal_stock = SqlToObject.ToDouble(reader["ideal_stock"].ToString());
                price = SqlToObject.ToDouble(reader["price"].ToString());
                position = reader["position"].ToString();
                pack_quantity = SqlToObject.ToInt(reader["pack_quantity"].ToString());
                weight_kg = SqlToObject.ToDouble(reader["weight_kg"].ToString());
                id_supplier = SqlToObject.ToInt(reader["id_supplier"].ToString());

                GlobalVariables.Products.Add(new Product(id, code, description, ideal_stock, price, position, pack_quantity, weight_kg, id_supplier));
            }

            GlobalVariables.MySqlConnection.Close();
        }

        internal static void ReadLots()
        {
            int id, id_product;
            string number;
            double quantity;
            DateTime entry;
            DateTime expires_in;
            MySqlCommand sqlCommand = new MySqlCommand("SELECT idlot, number, quantity, entry, expires_in, id_product FROM lot WHERE id_user = " + GlobalVariables.User.Id.ToString() + ";", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                id = SqlToObject.ToInt(reader["idlot"].ToString());
                number = SqlToObject.ToString(reader["number"].ToString());
                quantity = SqlToObject.ToDouble(reader["quantity"].ToString());
                entry = SqlToObject.ToDateTime(reader["entry"].ToString());
                expires_in = SqlToObject.ToDateTime(reader["expires_in"].ToString());
                id_product = SqlToObject.ToInt(reader["id_product"].ToString());

                GlobalVariables.Lots.Add(new Lot(id, number, quantity, entry, expires_in, id_product));
            }

            GlobalVariables.MySqlConnection.Close();
        }

        internal static void ReadSuppliers()
        {
            int id;
            string name, email, cpf_cnpj, description, phone_number;
            MySqlCommand sqlCommand = new MySqlCommand("SELECT idsupplier, name, description, email, phone_number, cpf_cnpj FROM supplier WHERE id_user = " + GlobalVariables.User.Id.ToString() + ";", GlobalVariables.MySqlConnection);
            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                id = SqlToObject.ToInt(reader["idsupplier"].ToString());
                name = reader["name"].ToString();
                description = SqlToObject.ToString(reader["description"].ToString());
                email = SqlToObject.ToString(reader["email"].ToString());
                phone_number = SqlToObject.ToString(reader["phone_number"].ToString());
                cpf_cnpj = SqlToObject.ToString(reader["cpf_cnpj"].ToString());

                GlobalVariables.Suppliers.Add(new Supplier(id, name, description, email, phone_number, cpf_cnpj));
            }

            GlobalVariables.MySqlConnection.Close();
        }

        internal static void ReadJobs()
        {
            int id;
            string name, description;
            double price;
            MySqlCommand sqlCommand = new MySqlCommand("SELECT idjob, name, description, price FROM job WHERE id_user = " + GlobalVariables.User.Id.ToString() + ";", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                id = SqlToObject.ToInt(reader["idjob"].ToString());
                name = reader["name"].ToString();
                description = SqlToObject.ToString(reader["description"].ToString());
                price = SqlToObject.ToDouble(reader["price"].ToString());

                GlobalVariables.Jobs.Add(new Job(id, name, description, price));
            }

            GlobalVariables.MySqlConnection.Close();
        }

        internal static void ReadCostumers()
        {   
            MySqlCommand sqlCommand = new MySqlCommand("SELECT idcostumer, name, email, phone_number, is_phone_whatsapp, sex," +
                " street, number, complement, reference, district, city, state, country, cep, discount_counter, discount_accumulated," +
                " debt FROM costumer WHERE id_user = " + GlobalVariables.User.Id.ToString() + ";", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                int id = SqlToObject.ToInt(reader["idcostumer"].ToString());
                string name = reader["name"].ToString();
                string email = SqlToObject.ToString(reader["email"].ToString());
                string phone_number = SqlToObject.ToString(reader["phone_number"].ToString());
                bool is_phone_whatsapp = SqlToObject.ToBool(reader["is_phone_whatsapp"].ToString());
                char sex = SqlToObject.ToChar(reader["sex"].ToString());
                string street = SqlToObject.ToString(reader["street"].ToString());
                string number = SqlToObject.ToString(reader["number"].ToString());
                string complement = SqlToObject.ToString(reader["complement"].ToString());
                string reference = SqlToObject.ToString(reader["reference"].ToString());
                string district = SqlToObject.ToString(reader["district"].ToString());
                string city = SqlToObject.ToString(reader["city"].ToString());
                string state = SqlToObject.ToString(reader["state"].ToString());
                string country = SqlToObject.ToString(reader["country"].ToString());
                string cep = SqlToObject.ToString(reader["cep"].ToString());
                int discount_counter = SqlToObject.ToInt(reader["discount_counter"].ToString());
                double discount_accumulated = SqlToObject.ToDouble(reader["discount_accumulated"].ToString());
                double debt = SqlToObject.ToDouble(reader["debt"].ToString()); ;

                GlobalVariables.Costumers.Add(new Costumer(id, name, email, phone_number, is_phone_whatsapp, sex, street, number, complement, reference, district, city, state, country, cep, discount_counter, discount_accumulated, debt));
            }

            GlobalVariables.MySqlConnection.Close();
        }

        internal static void ReadWarranties()
        {
            int id, id_item, id_costumer, id_user;
            string number, observations;
            bool type;
            DateTime started_in, expires_in;

            MySqlCommand sqlCommand = new MySqlCommand("SELECT idwarranty, number, type, started_in, expires_in, observations, " +
                "id_item, id_costumer, id_user FROM warranty WHERE id_user = " + GlobalVariables.User.Id.ToString() + ";", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                //Old Warranties that are still on DB Shield
                started_in = SqlToObject.ToDateTime(reader["started_in"].ToString());
                if (Warranty.WarrantyIsOld(started_in)) continue;

                id = SqlToObject.ToInt(reader["idwarranty"].ToString());
                number = reader["number"].ToString();
                type = SqlToObject.ToBool(reader["type"].ToString());
                expires_in = SqlToObject.ToDateTime(reader["expires_in"].ToString());
                observations = SqlToObject.ToString(reader["observations"].ToString());
                id_item = SqlToObject.ToInt(reader["id_item"].ToString());
                id_costumer = SqlToObject.ToInt(reader["id_costumer"].ToString());
                id_user = SqlToObject.ToInt(reader["id_user"].ToString());

                GlobalVariables.Warranties.Add(new Warranty(id, number, type, started_in, expires_in, observations, id_item, id_costumer, id_user));
            }

            GlobalVariables.MySqlConnection.Close();
        }

        internal static void ReadRequests()
        {
            int id, id_costumer;
            double value, discount, addition;
            char status;
            string number, occurrences, observations;
            bool is_delivery;
            byte payment_type;
            DateTime expires_in, started_in, done_in;

            MySqlCommand sqlCommand = new MySqlCommand("SELECT idrequest, number, value, discount, addition, status, observations, occurrences, " +
                "started_in, expires_in, done_in, is_delivery, payment_type, id_costumer FROM request WHERE id_user = " + GlobalVariables.User.Id.ToString() + ";", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                //Old Requests that are still on DB Shield
                started_in = SqlToObject.ToDateTime(reader["started_in"].ToString());
                if (Request.RequestIsOld(started_in)) continue;

                id = SqlToObject.ToInt(reader["idrequest"].ToString());
                number = reader["number"].ToString();
                value = SqlToObject.ToDouble(reader["value"].ToString());
                discount = SqlToObject.ToDouble(reader["discount"].ToString());
                addition = SqlToObject.ToDouble(reader["addition"].ToString());              
                status = Convert.ToChar(reader["status"]);
                observations = SqlToObject.ToString(reader["observations"].ToString());
                occurrences = SqlToObject.ToString(reader["occurrences"].ToString());                
                expires_in = SqlToObject.ToDateTime(reader["expires_in"].ToString());
                done_in = SqlToObject.ToDateTime(reader["done_in"].ToString());
                is_delivery = Boolean.Parse(reader["is_delivery"].ToString());
                payment_type = Byte.Parse(reader["payment_type"].ToString());
                id_costumer = SqlToObject.ToInt(reader["id_costumer"].ToString());

                GlobalVariables.Requests.Add(new Request(id, number, value, discount, addition, observations, occurrences, status, started_in, expires_in, done_in, is_delivery, payment_type, id_costumer, GlobalVariables.User.Id));
            }

            GlobalVariables.MySqlConnection.Close();

            //Setting the idsProducts list
            foreach (Request item in GlobalVariables.Requests)
            {
                sqlCommand = new MySqlCommand("SELECT id_product, quantity, price FROM request_products WHERE id_user = " + GlobalVariables.User.Id.ToString() + " AND id_request = " + item.Id.ToString() + ";", GlobalVariables.MySqlConnection);
                reader = ConnectionHandler(sqlCommand);

                while (reader.Read())
                {
                    item.Products.Add(new Request_Products(SqlToObject.ToInt(reader["id_product"].ToString()), SqlToObject.ToDouble(reader["quantity"].ToString()), SqlToObject.ToDouble(reader["price"].ToString())));
                }

                GlobalVariables.MySqlConnection.Close();
            }

            //Setting the idsJobs list
            foreach (Request item in GlobalVariables.Requests)
            {
                sqlCommand = new MySqlCommand("SELECT id_job, price FROM request_jobs WHERE id_user = " + GlobalVariables.User.Id.ToString() + " AND id_request = " + item.Id.ToString() + ";", GlobalVariables.MySqlConnection);
                reader = ConnectionHandler(sqlCommand);

                while (reader.Read())
                {
                    item.Jobs.Add(new Request_Jobs(SqlToObject.ToInt(reader["id_job"].ToString()), SqlToObject.ToDouble(reader["price"].ToString())));
                }

                GlobalVariables.MySqlConnection.Close();
            }
        }

        internal static void ReadSalesRecord()
        {   
            int requests_done_counter, products_sales_counter, jobs_sales_counter;
            double profits_amount, requests_done_amount, products_sales_amount, jobs_sales_amount;

            MySqlCommand sqlCommand = new MySqlCommand("SELECT profits_amount, requests_done_counter, requests_done_amount, products_sales_counter, products_sales_amount, jobs_sales_counter, jobs_sales_amount FROM commerce_stats WHERE id_user = " + GlobalVariables.User.Id.ToString() + ";", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                profits_amount = SqlToObject.ToDouble(reader["profits_amount"].ToString());
                requests_done_counter = SqlToObject.ToInt(reader["requests_done_counter"].ToString());
                requests_done_amount = SqlToObject.ToDouble(reader["requests_done_amount"].ToString());
                products_sales_counter = SqlToObject.ToInt(reader["products_sales_counter"].ToString());
                products_sales_amount = SqlToObject.ToDouble(reader["products_sales_amount"].ToString());
                jobs_sales_counter = SqlToObject.ToInt(reader["jobs_sales_counter"].ToString());
                jobs_sales_amount = SqlToObject.ToDouble(reader["jobs_sales_amount"].ToString());

                GlobalVariables.SalesRecords = new SalesRecord(profits_amount, requests_done_counter, requests_done_amount, products_sales_counter, products_sales_amount, jobs_sales_counter, jobs_sales_amount);
            }

            GlobalVariables.MySqlConnection.Close();
        }

        internal static void ReadDaysRecords()
        {     
            int id_user, id;
            double profit;
            DateTime date;

            MySqlCommand sqlCommand = new MySqlCommand("SELECT idds, date, profit, id_user FROM daily_sale WHERE id_user = " + GlobalVariables.User.Id.ToString() + ";", GlobalVariables.MySqlConnection);

            MySqlDataReader reader = ConnectionHandler(sqlCommand);

            while (reader.Read())
            {
                // Old DayRecord that are still on DB
                date = SqlToObject.ToDate(reader["date"].ToString());
                if (DayRecord.DayRecordIsOld(date)) continue;

                id = SqlToObject.ToInt(reader["idds"].ToString());                
                profit = SqlToObject.ToDouble(reader["profit"].ToString());
                id_user = SqlToObject.ToInt(reader["id_user"].ToString());

                GlobalVariables.DaysRecords.Add(new DayRecord(id, date, profit, id_user));
            }

            GlobalVariables.MySqlConnection.Close();
        }
    }
}
