namespace Facture.WindForm
{
    partial class ProductSellForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.Reference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TVA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewProduct
            // 
            this.listViewProduct.BackColor = System.Drawing.Color.LightGray;
            this.listViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Reference,
            this.Name,
            this.Quantity,
            this.Price,
            this.TVA,
            this.Remise,
            this.Date});
            this.listViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProduct.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listViewProduct.FullRowSelect = true;
            this.listViewProduct.GridLines = true;
            this.listViewProduct.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(0, 0);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(513, 215);
            this.listViewProduct.TabIndex = 0;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.View = System.Windows.Forms.View.Details;
            // 
            // Reference
            // 
            this.Reference.Text = "Reference";
            this.Reference.Width = 64;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 211;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // TVA
            // 
            this.TVA.Text = "TVA";
            // 
            // Remise
            // 
            this.Remise.Text = "Remise";
            this.Remise.Width = 58;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 146;
            // 
            // ProductSellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 215);
            this.Controls.Add(this.listViewProduct);
          //  this.Name = "ProductSellForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductSell";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ColumnHeader Reference;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader TVA;
        private System.Windows.Forms.ColumnHeader Remise;
        private System.Windows.Forms.ColumnHeader Date;
    }
}