using GC.Library.Translators;
using System;

namespace GC.Library.Entities
{
    internal class User
    {
        internal int Id { get; }
        internal string Name { get; set; }
        internal string Email { get; set; }
        private string Password { get; set; }
        internal string PhoneNumber { get; set; }
        internal string Cnpj { get; set; }
        internal DateTime Joined { get; set; }
        internal string Mac { get; set; }
        internal string Token { get; set; }
        internal int WarrantyCounter { get; set; }
        internal int RequestCounter { get; set; }
        internal readonly char AccountType;        

        public User(int id, string name, string email, string password, string phone_number, string cnpj, DateTime joined, string mac, int warranty_counter, int request_counter, char account_type)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = WKCrypto.W530(password);
            this.PhoneNumber = phone_number;
            this.Cnpj = cnpj;
            this.Joined = joined;
            this.Mac = mac;
            this.WarrantyCounter = warranty_counter;
            this.RequestCounter = request_counter;
            this.AccountType = account_type;
        }

        public User(int id, string name, string email, string password, string phone_number, string cnpj, string mac, int warranty_counter, int request_counter)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = WKCrypto.W530(password);
            this.PhoneNumber = phone_number;
            this.Cnpj = cnpj;
            this.Mac = mac;
            this.WarrantyCounter = warranty_counter;
            this.RequestCounter = request_counter;
        }

        public User(int id, string name, string email, string password, string phone_number, string cnpj, string mac)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = WKCrypto.W530(password);
            this.PhoneNumber = phone_number;
            this.Cnpj = cnpj;
            this.Mac = mac;
        }

        internal string GetPassword()
        {
            return this.Password;
        }

        internal void SetPassword(string newPass)
        {
            this.Password = WKCrypto.W530(newPass);
        }

        internal string GetFirstWordAndSurname()
        {
            int start = this.Name.IndexOf(' ') + 1;
            int end = this.Name.IndexOf(' ', start);

            return this.Name[0] + this.Name.Substring(start, end - start);
        }
    }
}
