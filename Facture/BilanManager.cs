using Facture.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facture.DAL;

namespace Facture
{
    public class BilanManager
    {
        BilanRepository BilanRepository = new BilanRepository();
       public  List<Bilan> GetBilans()
       {
            return BilanRepository.GetAll();
       }
        public void  AddBilan(Bilan bilan)
        {
            BilanRepository.Add(bilan);
        }
    }
}
