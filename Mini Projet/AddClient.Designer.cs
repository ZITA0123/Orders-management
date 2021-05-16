namespace Mini_Projet
{
    partial class AddClient
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.annuler = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.cp = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.rue = new System.Windows.Forms.TextBox();
            this.client = new System.Windows.Forms.TextBox();
            this.AjoutClien = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.AjoutClien);
            this.panel3.Controls.Add(this.annuler);
            this.panel3.Location = new System.Drawing.Point(124, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 61);
            this.panel3.TabIndex = 11;
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(383, 20);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(106, 36);
            this.annuler.TabIndex = 0;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.tel);
            this.panel4.Controls.Add(this.cp);
            this.panel4.Controls.Add(this.ville);
            this.panel4.Controls.Add(this.rue);
            this.panel4.Controls.Add(this.client);
            this.panel4.Location = new System.Drawing.Point(124, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(511, 273);
            this.panel4.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(265, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tel";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(19, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Code postal ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ville";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rue";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(337, 196);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(122, 20);
            this.tel.TabIndex = 5;
            this.tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_KeyPress);
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(111, 196);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(122, 20);
            this.cp.TabIndex = 4;
            this.cp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cp_KeyPress);
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(111, 146);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(348, 20);
            this.ville.TabIndex = 3;
            // 
            // rue
            // 
            this.rue.Location = new System.Drawing.Point(111, 85);
            this.rue.Name = "rue";
            this.rue.Size = new System.Drawing.Size(348, 20);
            this.rue.TabIndex = 2;
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(111, 32);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(348, 20);
            this.client.TabIndex = 0;
            // 
            // AjoutClien
            // 
            this.AjoutClien.Location = new System.Drawing.Point(257, 20);
            this.AjoutClien.Name = "AjoutClien";
            this.AjoutClien.Size = new System.Drawing.Size(106, 36);
            this.AjoutClien.TabIndex = 1;
            this.AjoutClien.Text = "Valider";
            this.AjoutClien.UseVisualStyleBackColor = true;
            this.AjoutClien.Click += new System.EventHandler(this.AjoutClien_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClient";
            this.Text = "Ajouter nouveau client";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.TextBox rue;
        private System.Windows.Forms.TextBox client;
        private System.Windows.Forms.Button AjoutClien;
    }
}