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
    public partial class Preview : Form
    {
        ProductManager ProductManager = new ProductManager();
        public Preview()
        {
            InitializeComponent();
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            var list = ProductManager.GetProducts();
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",list));
            this.reportViewer1.RefreshReport();
        }
    }
}
