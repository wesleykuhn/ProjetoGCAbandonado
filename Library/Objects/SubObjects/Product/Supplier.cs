using System.Linq;

namespace GC.Library.Objects.SubObjects.Product
{
    internal class Supplier
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal string Email { get; set; }
        internal string PhoneNumber { get; set; }
        internal string CpfCnpj { get; set; }

        public Supplier(int id, string name, string description, string email, string phone_number, string cpf_cnpj)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Email = email;
            this.PhoneNumber = phone_number;
            this.CpfCnpj = cpf_cnpj;
        }

        internal bool IsEqualTo(Supplier supplier)
        {
            if (supplier.Name == this.Name && supplier.Description == this.Description && supplier.Email == this.Email && supplier.PhoneNumber == this.PhoneNumber && supplier.CpfCnpj == this.CpfCnpj) return true;
            else return false;
        }

        /// <summary>
        /// Returns the Suppliers ID by making a search by supplier's name. It will return -1 if there's no suppliers found with that name.
        /// </summary>
        /// <param name="The name of the supplier to be found."></param>
        /// <returns></returns>
        internal static int GetSupplierId(string name)
        {
            int supplierId = -1;

            if (name == "Nenhum") return supplierId;

            int index = GlobalVariables.Suppliers.FindIndex(x => x.Name == name);

            return GlobalVariables.Suppliers[index].Id;
        }

        /// <summary>
        /// Returns the Suppliers Name by making a search by supplier's id. It will return -1 there's no suppliers found with that id
        /// </summary>
        /// <param name="The ID of the supplier to be found"></param>
        /// <returns></returns>
        internal static string GetSupplierName(int id)
        {
            int index = GlobalVariables.Suppliers.FindIndex(x => x.Id == id);

            if (index == -1) return "Nenhum";
            else return GlobalVariables.Suppliers[index].Name;
        }
    }
}
