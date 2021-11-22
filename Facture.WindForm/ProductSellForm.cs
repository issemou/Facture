using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture.WindForm
{
    public partial class ProductSellForm : Form
    {
        ProductManager ProductManager = new ProductManager();
        BilanManager BilanManager = new BilanManager();
        public ProductSellForm()
        {
            InitializeComponent();
            LoaProduct();
        }

        private void LoaProduct()
        {
            var list = BilanManager.GetBilans();
            foreach (var u in list)
            {
                ListViewItem lvi = new ListViewItem(new string[] {u.Reference, u.Name_product,u.Quantity.ToString(),u.Price_uni.ToString(),u.TVA.ToString(),u.Remise.ToString(),u.date });
                lvi.Tag = u;
                listViewProduct.Items.Add(lvi);
            }
        }
    }
}
