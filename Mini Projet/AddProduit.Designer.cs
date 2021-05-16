namespace Mini_Projet
{
    partial class AddProduit
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.designation = new System.Windows.Forms.TextBox();
            this.codep = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ajoutProduit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbType);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.designation);
            this.panel4.Controls.Add(this.codep);
            this.panel4.Location = new System.Drawing.Point(145, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(511, 190);
            this.panel4.TabIndex = 16;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(112, 124);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "type produit";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Designation";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Code produit";
            // 
            // designation
            // 
            this.designation.Location = new System.Drawing.Point(111, 79);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(348, 20);
            this.designation.TabIndex = 5;
            // 
            // codep
            // 
            this.codep.Location = new System.Drawing.Point(111, 32);
            this.codep.Name = "codep";
            this.codep.Size = new System.Drawing.Size(122, 20);
            this.codep.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ajoutProduit);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(145, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 61);
            this.panel3.TabIndex = 15;
            // 
            // ajoutProduit
            // 
            this.ajoutProduit.Location = new System.Drawing.Point(244, 20);
            this.ajoutProduit.Name = "ajoutProduit";
            this.ajoutProduit.Size = new System.Drawing.Size(106, 36);
            this.ajoutProduit.TabIndex = 1;
            this.ajoutProduit.Text = "Valider";
            this.ajoutProduit.UseVisualStyleBackColor = true;
            this.ajoutProduit.Click += new System.EventHandler(this.ajoutProduit_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(383, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 36);
            this.button5.TabIndex = 0;
            this.button5.Text = "Annuler";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AddProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduit";
            this.Text = "AddProduit";
            this.Load += new System.EventHandler(this.AddProduit_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.TextBox codep;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ajoutProduit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cmbType;
    }
}