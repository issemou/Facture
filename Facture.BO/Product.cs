using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Facture.BO
{
    public class Product
    {
        CultureInfo culture = new CultureInfo("en-US");

        public Product()
        {

        }

        public Product(string reference, string name_product, double price_uni, double quantity,double tVA, double remise)
        {
            Reference = reference;
           Name_product = name_product;
            Price_uni = price_uni;
            Quantity = quantity;
            TVA = tVA;
            Remise = remise;
            date = DateTime.Now.Date.ToString();
            Montant_total = Price_uni * Quantity;
            Montant_remise = ((Remise * Montant_total) / 100);
            Montant_tva = ((TVA * Montant_total) / 100);
            Net_payer = (Montant_total + Montant_remise + Montant_tva);
        }

        public string Reference { get; set; }
        public string Name_product { get; set; }
        public double Price_uni { get; set; }
        public double Quantity { get; set; }

        public double Montant_total { get; set; }
        public double Montant_remise { get; set; }
        public double Montant_tva { get; set; }
        public double Net_payer { get; set; }

        public double TVA { get; set; }
        public double Remise { get; set; }
        public string date { get; set; }
    }
}
