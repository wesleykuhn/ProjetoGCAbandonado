using System.IO;
using System.Linq;
using GC.Library.Entities;
using GC.Library.Translators;

namespace GC.Library.Files
{
    internal static class LoginData
    {
        internal static void LastLoginFileBeforeLogin(ref System.Windows.Forms.TextBox txtEmail, ref System.Windows.Forms.TextBox txtPassword)
        {
            if (File.Exists(Informations.Directories.LastLoginSettings))
            {
                string[] content = File.ReadAllLines(Informations.Directories.LastLoginSettings);

                if (content.Length >= 1)
                {
                    txtEmail.Text = WKCrypto.W710(content[0]);
                }

                if (content.Count() >= 2)
                {
                    txtPassword.Text = WKCrypto.W710(content[1]);
                }                              
            }
        }

        internal static void LastLoginFileAfterLogin(User user, bool useAutoLogin)
        {
            string[] content = new string[1];

            if (useAutoLogin)
            {
                content = new string[2];

                content[1] = user.GetPassword();
            }

            content[0] = WKCrypto.W530(user.Email);

            File.WriteAllLines(Informations.Directories.LastLoginSettings, content);            
        }        
    }
}
