using System.Linq;

namespace GC.Library.Entities
{
    internal class Costumer
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal string Email { get; set; }
        internal string PhoneNumber { get; set; }
        internal bool IsPhoneWhatsapp { get; set; }
        internal char Sex { get; set; }        
        internal string Street { get; set; }
        internal string Number { get; set; }
        internal string Complement { get; set; }
        internal string Reference { get; set; }
        internal string District { get; set; }
        internal string City { get; set; }
        internal string State { get; set; }
        internal string Country { get; set; }
        internal string Cep { get; set; }
        internal int DiscountCounter { get; set; }
        internal double DiscountAccumulated { get; set; }
        internal double Debt { get; set; }

        public Costumer(int id, string name, string email, string phone_number, bool is_phone_whatsapp, char sex, string street, string number, string complement, string reference, string district, string city, string state, string country, string cep, int discount_counter, double discount_accumulated, double debt)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phone_number;
            this.IsPhoneWhatsapp = is_phone_whatsapp;
            this.Sex = sex;
            this.Street = street;
            this.Number = number;
            this.Complement = complement;
            this.Reference = reference;
            this.District = district;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.Cep = cep;
            this.DiscountCounter = discount_counter;
            this.DiscountAccumulated = discount_accumulated;
            this.Debt = debt;
        }

        internal bool IsEqualTo(Costumer costumer)
        {
            if (costumer.Name == this.Name && costumer.Sex == this.Sex && costumer.Street == this.Street && costumer.Number == this.Number && costumer.PhoneNumber == this.PhoneNumber) return true;
            else return false;
        }

        internal string GetAddress()
        {
            return this.Street + ", " + this.Number;
        }

        /// <summary>
        /// Returns the Costumers ID by making a search by costumer's name. It will return -1 if there's no costumer found with that name.
        /// </summary>
        /// <param name="The name of the costumer to be found."></param>
        /// <returns></returns>
        internal static int GetCostumerId(string name)
        {
            int costumerId = -1;

            if (name == "Excluído") return costumerId;

            int index = GlobalVariables.Costumers.FindIndex(x => x.Name == name);
            return GlobalVariables.Costumers[index].Id;
        }

        /// <summary>
        /// Returns the Costumers Name by making a search by costumers's id. It will return -1 there's no costumer found with that id
        /// </summary>
        /// <param name="The ID of the costumer to be found"></param>
        /// <returns></returns>
        internal static string GetCostumerName(int id)
        {
            string costumerName = "Excluído";

            if (id == -1) return costumerName;

            var filtered = GlobalVariables.Costumers.Where(x => x.Id == id).Select(x => x.Name);
            foreach (var item in filtered)
            {
                costumerName = item;
            }

            if (filtered.Count() == 0)
            {
                return "Excluído";
            }

            return costumerName;
        }

        internal static Costumer CloneCostumer(int id)
        {
            if (id == -1) return null;

            foreach (Costumer costumer in GlobalVariables.Costumers)
            {
                if (costumer.Id == id) return costumer;
            }

            return null;
        }
    }
}
