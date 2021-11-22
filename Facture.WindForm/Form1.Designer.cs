namespace Facture.WindForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbRef = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTVA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbRemise = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkLabelFacture = new System.Windows.Forms.LinkLabel();
            this.linkLabelBilan = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reference:";
            // 
            // txbRef
            // 
            this.txbRef.Location = new System.Drawing.Point(127, 57);
            this.txbRef.Name = "txbRef";
            this.txbRef.Size = new System.Drawing.Size(136, 20);
            this.txbRef.TabIndex = 1;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(127, 83);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(136, 20);
            this.txbName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(127, 109);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(136, 20);
            this.txbQuantity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity:";
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(127, 135);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(136, 20);
            this.txbPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price:";
            // 
            // txbTVA
            // 
            this.txbTVA.Location = new System.Drawing.Point(337, 54);
            this.txbTVA.Name = "txbTVA";
            this.txbTVA.Size = new System.Drawing.Size(136, 20);
            this.txbTVA.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "TVA:";
            // 
            // txbRemise
            // 
            this.txbRemise.Location = new System.Drawing.Point(337, 83);
            this.txbRemise.Name = "txbRemise";
            this.txbRemise.Size = new System.Drawing.Size(136, 20);
            this.txbRemise.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Remise:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(355, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 31);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // linkLabelFacture
            // 
            this.linkLabelFacture.AutoSize = true;
            this.linkLabelFacture.Location = new System.Drawing.Point(49, 188);
            this.linkLabelFacture.Name = "linkLabelFacture";
            this.linkLabelFacture.Size = new System.Drawing.Size(94, 13);
            this.linkLabelFacture.TabIndex = 13;
            this.linkLabelFacture.TabStop = true;
            this.linkLabelFacture.Text = "GO TO FACTURE";
            this.linkLabelFacture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFacture_LinkClicked);
            // 
            // linkLabelBilan
            // 
            this.linkLabelBilan.AutoSize = true;
            this.linkLabelBilan.Location = new System.Drawing.Point(352, 188);
            this.linkLabelBilan.Name = "linkLabelBilan";
            this.linkLabelBilan.Size = new System.Drawing.Size(75, 13);
            this.linkLabelBilan.TabIndex = 14;
            this.linkLabelBilan.TabStop = true;
            this.linkLabelBilan.Text = "GO TO BILAN";
            this.linkLabelBilan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBilan_LinkClicked);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 210);
            this.Controls.Add(this.linkLabelBilan);
            this.Controls.Add(this.linkLabelFacture);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbRemise);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbTVA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbRef);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbRef;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTVA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbRemise;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel linkLabelFacture;
        private System.Windows.Forms.LinkLabel linkLabelBilan;
    }
}

