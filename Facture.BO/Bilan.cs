using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.BO
{
    public class Bilan : Product
    {
        public Bilan(string reference, string name_product, double price_uni, double quantity, double tVA, double remise) : base(reference, name_product, price_uni, quantity, tVA, remise)
        {
        }
    }
}
