using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facture.BO;
using Facture.DAL;

namespace Facture.WindForm
{
    public partial class Form1 : Form
    {
        ProductManager ProductManager = new ProductManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product= new Product(txbRef.Text,txbName.Text,double.Parse(txbPrice.Text),double.Parse(txbQuantity.Text),double.Parse(txbTVA.Text),double.Parse(txbRemise.Text));
            try
            {
                    ProductManager.AddProduct(product);
                    MessageBox.Show("DONE!");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void linkLabelFacture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new Preview();
            form.Show();
        }

        private void btnRebootlist_Click(object sender, EventArgs e)
        {
            ProductManager.Reboot();
        }
    }
}
