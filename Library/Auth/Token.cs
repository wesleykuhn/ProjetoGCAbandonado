using System;
using System.IO;
using GC.Library.Database;
using GC.Library.Errors;
using GC.Library.Generators;

namespace GC.Library.Auth
{
    internal static class Token
    {
        internal static bool TokenAuth()
        {
            bool tokenFileExists = TokenFileExists(), tokenExistsInDB = TokenExistsInDB(), result = false;
            if (!tokenFileExists && !tokenExistsInDB)
            {
                string newToken = Code.NumbersAndWords(10);
                GlobalVariables.User.Token = newToken;

                CreateTokenOnDataBase(newToken);

                try
                {
                    CreateTokenFile(newToken);
                }
                catch (IOException ex)
                {
                    Care.AppendOnErrorLogFile(ex.Message);

                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Ocorreu um erro ao tentar criar novo token no computador! Por favor, verifique se você tem privilégios administrativos ou de gravar/ler arquivos nesse computador. Considere reiniciar o computador e tentar novamente. Caso o erro persista entre em contato com a administração.", 2);
                    messOk.Show();

                    Environment.Exit(0);
                }  
                
                result = true;
            }
            else if (!tokenFileExists && tokenExistsInDB)
            {
                result = false;
            }
            else if (tokenFileExists && !tokenExistsInDB)
            {
                string fileToken = "";
                try
                {
                    StreamReader sr = new StreamReader(Informations.Directories.UserToken);
                    fileToken = sr.ReadLine();
                    sr.Close();
                    GlobalVariables.User.Token = fileToken;
                }
                catch (IOException ex)
                {
                    Care.AppendOnErrorLogFile(ex.Message);

                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Ocorreu um erro ao tentar ler o token da sua conta no computador! Por favor, verifique se você tem privilégios administrativos ou de gravar/ler arquivos nesse computador. Considere reiniciar o computador e tentar novamente. Caso o erro persista entre em contato com a administração.", 2);
                    messOk.Show();

                    Environment.Exit(0);
                }

                CreateTokenOnDataBase(fileToken);
               
                result = true;
            }
            else if (tokenFileExists && tokenExistsInDB)
            {
                string fileToken = "", dataBaseToken = "";
                string[] cond = { "iduser" };
                string[] condValue = { GlobalVariables.User.Id.ToString() };
                dataBaseToken = MySqlReader.ReadOnlyOneColumn("user", "token", cond, condValue, null, new bool[] { false });

                try
                {
                    StreamReader sr = new StreamReader(Informations.Directories.UserToken);
                    fileToken = sr.ReadLine();
                    sr.Close();
                }
                catch (IOException ex)
                {
                    Care.AppendOnErrorLogFile(ex.Message);

                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Ocorreu um erro ao tentar ler o token da sua conta no computador! Por favor, verifique se você tem privilégios administrativos ou de gravar/ler arquivos nesse computador. Considere reiniciar o computador e tentar novamente. Caso o erro persista entre em contato com a administração.", 2);
                    messOk.Show();

                    System.Windows.Forms.Application.Exit();
                }
                if (fileToken == dataBaseToken)
                {
                    result = true;
                    GlobalVariables.User.Token = fileToken;
                }
                else result = false;
            }
            return result;
        }


        internal static bool TokenExistsInDB()
        {
            bool result = false;
            string[] cond = { "iduser" };
            string[] condValue = { GlobalVariables.User.Id.ToString() };
            string token = MySqlReader.ReadOnlyOneColumn("user", "token", cond, condValue, null, new bool[] { false });
            if (token.Length < 10)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        static internal void ClearToken()
        {           
            bool result = Token.TokenExistsInDB();
            if (result)
            {
                MySqlNonQuery.UpdateUser("token", null);
            }
            result = File.Exists(Informations.Directories.UserToken);
            if (result)
            {
                File.Delete(Informations.Directories.UserToken);
            }

            MySqlNonQuery.UpdateUser("last_logout", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            MySqlNonQuery.UpdateUser("active", "0");
        }

        private static bool TokenFileExists()
        {
            return File.Exists(Informations.Directories.UserToken);
        }

        private static void CreateTokenFile(string newToken)
        {
            Stream stream = File.Create(Informations.Directories.UserToken);
            stream.Close();
            using (StreamWriter sw = new StreamWriter(Informations.Directories.UserToken))
            {
                sw.Write(newToken);
            }
        }

        private static void CreateTokenOnDataBase(string newToken)
        {
            MySqlNonQuery.UpdateUser("token", newToken);
        }
    }
}
