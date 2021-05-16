namespace Mini_Projet
{
    partial class Produit
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
            this.addProduit = new System.Windows.Forms.Button();
            this.searchProduit = new System.Windows.Forms.Button();
            this.annulerSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.designation = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.choisirProduit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addProduit
            // 
            this.addProduit.Location = new System.Drawing.Point(25, 153);
            this.addProduit.Name = "addProduit";
            this.addProduit.Size = new System.Drawing.Size(104, 29);
            this.addProduit.TabIndex = 26;
            this.addProduit.Text = "Prduit Inexistant";
            this.addProduit.UseVisualStyleBackColor = true;
            this.addProduit.Click += new System.EventHandler(this.addProduit_Click);
            // 
            // searchProduit
            // 
            this.searchProduit.Location = new System.Drawing.Point(113, 137);
            this.searchProduit.Name = "searchProduit";
            this.searchProduit.Size = new System.Drawing.Size(122, 23);
            this.searchProduit.TabIndex = 24;
            this.searchProduit.Text = "Rechercher";
            this.searchProduit.UseVisualStyleBackColor = true;
            this.searchProduit.Click += new System.EventHandler(this.searchProduit_Click);
            // 
            // annulerSearch
            // 
            this.annulerSearch.Location = new System.Drawing.Point(25, 94);
            this.annulerSearch.Name = "annulerSearch";
            this.annulerSearch.Size = new System.Drawing.Size(104, 23);
            this.annulerSearch.TabIndex = 25;
            this.annulerSearch.Text = "Annuler";
            this.annulerSearch.UseVisualStyleBackColor = true;
            this.annulerSearch.Click += new System.EventHandler(this.annulerSearch_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 38);
            this.label1.TabIndex = 37;
            this.label1.Text = "Rechercher de produit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProduit
            // 
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvProduit.Location = new System.Drawing.Point(289, 12);
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.Size = new System.Drawing.Size(627, 377);
            this.dgvProduit.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Code Produit";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Produit";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 190;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Type Produit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 190;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(-89, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Operateur";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(-89, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "CP";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(-89, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ville";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-93, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Rue";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(-89, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Client";
            // 
            // designation
            // 
            this.designation.Location = new System.Drawing.Point(117, 157);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(122, 20);
            this.designation.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.choisirProduit);
            this.panel1.Controls.Add(this.addProduit);
            this.panel1.Controls.Add(this.annulerSearch);
            this.panel1.Location = new System.Drawing.Point(934, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 206);
            this.panel1.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Designation";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.searchProduit);
            this.panel2.Location = new System.Drawing.Point(3, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 174);
            this.panel2.TabIndex = 40;
            // 
            // choisirProduit
            // 
            this.choisirProduit.Location = new System.Drawing.Point(21, 37);
            this.choisirProduit.Name = "choisirProduit";
            this.choisirProduit.Size = new System.Drawing.Size(108, 23);
            this.choisirProduit.TabIndex = 27;
            this.choisirProduit.Text = "valider";
            this.choisirProduit.UseVisualStyleBackColor = true;
            this.choisirProduit.Click += new System.EventHandler(this.choisirProduit_Click);
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProduit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Produit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProduit;
        private System.Windows.Forms.Button searchProduit;
        private System.Windows.Forms.Button annulerSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProduit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button choisirProduit;
    }
}