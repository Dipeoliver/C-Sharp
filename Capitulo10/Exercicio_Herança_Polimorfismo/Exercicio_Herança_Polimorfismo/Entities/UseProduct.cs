

using System;
using System.Globalization;

namespace Exercicio_Herança_Polimorfismo.Entities
{
    class UseProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UseProduct()
        {

        }
        public UseProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
