namespace Mini_Projet
{
    partial class AjoutCmd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateCmd = new System.Windows.Forms.DateTimePicker();
            this.refCmd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.cp = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.rue = new System.Windows.Forms.TextBox();
            this.choisirClient = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteLignCmd = new System.Windows.Forms.Button();
            this.modifLigCmd = new System.Windows.Forms.Button();
            this.ajouterLigCmd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLigneCmd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.modifierCmde = new System.Windows.Forms.Button();
            this.ajouterCmd = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCmd)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dateCmd);
            this.panel1.Controls.Add(this.refCmd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tel);
            this.panel1.Controls.Add(this.cp);
            this.panel1.Controls.Add(this.ville);
            this.panel1.Controls.Add(this.rue);
            this.panel1.Controls.Add(this.choisirClient);
            this.panel1.Location = new System.Drawing.Point(94, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 241);
            this.panel1.TabIndex = 0;
            // 
            // dateCmd
            // 
            this.dateCmd.Location = new System.Drawing.Point(343, 34);
            this.dateCmd.Name = "dateCmd";
            this.dateCmd.Size = new System.Drawing.Size(328, 20);
            this.dateCmd.TabIndex = 24;
            // 
            // refCmd
            // 
            this.refCmd.Location = new System.Drawing.Point(126, 34);
            this.refCmd.Name = "refCmd";
            this.refCmd.Size = new System.Drawing.Size(122, 20);
            this.refCmd.TabIndex = 23;
            this.refCmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.refCmd_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(266, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Date";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Reference commande";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(453, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tel";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(266, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "CP";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(21, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ville";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(21, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rue";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Client";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(549, 193);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(122, 20);
            this.tel.TabIndex = 15;
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(359, 193);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(77, 20);
            this.cp.TabIndex = 14;
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(126, 193);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(122, 20);
            this.ville.TabIndex = 13;
            this.ville.TextChanged += new System.EventHandler(this.ville_TextChanged);
            // 
            // rue
            // 
            this.rue.Location = new System.Drawing.Point(126, 142);
            this.rue.Name = "rue";
            this.rue.Size = new System.Drawing.Size(547, 20);
            this.rue.TabIndex = 12;
            // 
            // choisirClient
            // 
            this.choisirClient.Location = new System.Drawing.Point(126, 96);
            this.choisirClient.Name = "choisirClient";
            this.choisirClient.Size = new System.Drawing.Size(545, 20);
            this.choisirClient.TabIndex = 11;
            this.choisirClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.choisirClient_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.deleteLignCmd);
            this.panel2.Controls.Add(this.modifLigCmd);
            this.panel2.Controls.Add(this.ajouterLigCmd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvLigneCmd);
            this.panel2.Location = new System.Drawing.Point(94, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 335);
            this.panel2.TabIndex = 9;
            // 
            // deleteLignCmd
            // 
            this.deleteLignCmd.Location = new System.Drawing.Point(550, 220);
            this.deleteLignCmd.Name = "deleteLignCmd";
            this.deleteLignCmd.Size = new System.Drawing.Size(104, 23);
            this.deleteLignCmd.TabIndex = 9;
            this.deleteLignCmd.Text = "Supprimer";
            this.deleteLignCmd.UseVisualStyleBackColor = true;
            this.deleteLignCmd.Click += new System.EventHandler(this.deleteLignCmd_Click);
            // 
            // modifLigCmd
            // 
            this.modifLigCmd.Location = new System.Drawing.Point(550, 157);
            this.modifLigCmd.Name = "modifLigCmd";
            this.modifLigCmd.Size = new System.Drawing.Size(104, 23);
            this.modifLigCmd.TabIndex = 8;
            this.modifLigCmd.Text = "Modifier";
            this.modifLigCmd.UseVisualStyleBackColor = true;
            this.modifLigCmd.Click += new System.EventHandler(this.modifLigCmd_Click);
            // 
            // ajouterLigCmd
            // 
            this.ajouterLigCmd.Location = new System.Drawing.Point(550, 96);
            this.ajouterLigCmd.Name = "ajouterLigCmd";
            this.ajouterLigCmd.Size = new System.Drawing.Size(104, 23);
            this.ajouterLigCmd.TabIndex = 7;
            this.ajouterLigCmd.Text = "Ajouter";
            this.ajouterLigCmd.UseVisualStyleBackColor = true;
            this.ajouterLigCmd.Click += new System.EventHandler(this.ajouterLigCmd_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lignes commandes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLigneCmd
            // 
            this.dgvLigneCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLigneCmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.codeProduit});
            this.dgvLigneCmd.Location = new System.Drawing.Point(3, 68);
            this.dgvLigneCmd.Name = "dgvLigneCmd";
            this.dgvLigneCmd.Size = new System.Drawing.Size(512, 218);
            this.dgvLigneCmd.TabIndex = 5;
            this.dgvLigneCmd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLigneCmd_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Produit";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantite";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // codeProduit
            // 
            this.codeProduit.HeaderText = "codeProduit";
            this.codeProduit.Name = "codeProduit";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.modifierCmde);
            this.panel3.Controls.Add(this.ajouterCmd);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(94, 655);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 82);
            this.panel3.TabIndex = 10;
            // 
            // modifierCmde
            // 
            this.modifierCmde.Location = new System.Drawing.Point(410, 23);
            this.modifierCmde.Name = "modifierCmde";
            this.modifierCmde.Size = new System.Drawing.Size(106, 36);
            this.modifierCmde.TabIndex = 2;
            this.modifierCmde.Text = "Mettre a jour";
            this.modifierCmde.UseVisualStyleBackColor = true;
            this.modifierCmde.Click += new System.EventHandler(this.modifierCmde_Click);
            // 
            // ajouterCmd
            // 
            this.ajouterCmd.Location = new System.Drawing.Point(410, 23);
            this.ajouterCmd.Name = "ajouterCmd";
            this.ajouterCmd.Size = new System.Drawing.Size(106, 36);
            this.ajouterCmd.TabIndex = 1;
            this.ajouterCmd.Text = "Valider";
            this.ajouterCmd.UseVisualStyleBackColor = true;
            this.ajouterCmd.Click += new System.EventHandler(this.ajouterCmd_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(549, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 36);
            this.button5.TabIndex = 0;
            this.button5.Text = "Annuler";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(117, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "choisir le champ client et taper sur entrer pour choisir un client";
            // 
            // AjoutCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 749);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AjoutCmd";
            this.Text = "AjoutCmd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCmd)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteLignCmd;
        private System.Windows.Forms.Button modifLigCmd;
        private System.Windows.Forms.Button ajouterLigCmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLigneCmd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ajouterCmd;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.TextBox rue;
        private System.Windows.Forms.TextBox choisirClient;
        private System.Windows.Forms.DateTimePicker dateCmd;
        private System.Windows.Forms.TextBox refCmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeProduit;
        private System.Windows.Forms.Button modifierCmde;
        private System.Windows.Forms.TextBox textBox1;
    }
}