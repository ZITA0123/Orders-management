namespace Mini_Projet
{
    partial class GestionCommande
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
            this.dgvCommande = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quitter = new System.Windows.Forms.Button();
            this.deleteCommande = new System.Windows.Forms.Button();
            this.editCmd = new System.Windows.Forms.Button();
            this.addCmd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLigneCmd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.refreshResearch = new System.Windows.Forms.Button();
            this.searchCmd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.clientCmd = new System.Windows.Forms.TextBox();
            this.refcmd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.datefin = new System.Windows.Forms.DateTimePicker();
            this.datedebut = new System.Windows.Forms.DateTimePicker();
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
            this.label3 = new System.Windows.Forms.Label();
            this.nomCl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCmd)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCommande
            // 
            this.dgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.idClient});
            this.dgvCommande.Location = new System.Drawing.Point(3, 56);
            this.dgvCommande.Name = "dgvCommande";
            this.dgvCommande.Size = new System.Drawing.Size(512, 254);
            this.dgvCommande.TabIndex = 5;
            this.dgvCommande.SelectionChanged += new System.EventHandler(this.dgvCommande_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Reference commande";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Client";
            this.Column3.Name = "Column3";
            this.Column3.Width = 170;
            // 
            // idClient
            // 
            this.idClient.HeaderText = "idClient";
            this.idClient.Name = "idClient";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.quitter);
            this.panel1.Controls.Add(this.deleteCommande);
            this.panel1.Controls.Add(this.editCmd);
            this.panel1.Controls.Add(this.addCmd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvCommande);
            this.panel1.Location = new System.Drawing.Point(317, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 345);
            this.panel1.TabIndex = 6;
            // 
            // quitter
            // 
            this.quitter.ForeColor = System.Drawing.Color.Red;
            this.quitter.Location = new System.Drawing.Point(548, 265);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(104, 23);
            this.quitter.TabIndex = 10;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // deleteCommande
            // 
            this.deleteCommande.Location = new System.Drawing.Point(548, 164);
            this.deleteCommande.Name = "deleteCommande";
            this.deleteCommande.Size = new System.Drawing.Size(104, 23);
            this.deleteCommande.TabIndex = 9;
            this.deleteCommande.Text = "Supprimer";
            this.deleteCommande.UseVisualStyleBackColor = true;
            this.deleteCommande.Click += new System.EventHandler(this.deleteCommande_Click);
            // 
            // editCmd
            // 
            this.editCmd.Location = new System.Drawing.Point(548, 113);
            this.editCmd.Name = "editCmd";
            this.editCmd.Size = new System.Drawing.Size(104, 23);
            this.editCmd.TabIndex = 8;
            this.editCmd.Text = "Modifier";
            this.editCmd.UseVisualStyleBackColor = true;
            this.editCmd.Click += new System.EventHandler(this.editCmd_Click);
            // 
            // addCmd
            // 
            this.addCmd.Location = new System.Drawing.Point(548, 68);
            this.addCmd.Name = "addCmd";
            this.addCmd.Size = new System.Drawing.Size(104, 23);
            this.addCmd.TabIndex = 7;
            this.addCmd.Text = "Ajouter";
            this.addCmd.UseVisualStyleBackColor = true;
            this.addCmd.Click += new System.EventHandler(this.addCmd_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Liste des commandes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvLigneCmd);
            this.panel2.Location = new System.Drawing.Point(317, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 352);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(3, 19);
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
            this.dataGridViewTextBoxColumn3});
            this.dgvLigneCmd.Location = new System.Drawing.Point(3, 68);
            this.dgvLigneCmd.Name = "dgvLigneCmd";
            this.dgvLigneCmd.Size = new System.Drawing.Size(512, 218);
            this.dgvLigneCmd.TabIndex = 5;
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
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.refreshResearch);
            this.panel3.Controls.Add(this.searchCmd);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.clientCmd);
            this.panel3.Controls.Add(this.refcmd);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 345);
            this.panel3.TabIndex = 9;
            // 
            // refreshResearch
            // 
            this.refreshResearch.Location = new System.Drawing.Point(19, 317);
            this.refreshResearch.Name = "refreshResearch";
            this.refreshResearch.Size = new System.Drawing.Size(112, 23);
            this.refreshResearch.TabIndex = 13;
            this.refreshResearch.Text = "refresh";
            this.refreshResearch.UseVisualStyleBackColor = true;
            this.refreshResearch.Click += new System.EventHandler(this.refreshResearch_Click);
            // 
            // searchCmd
            // 
            this.searchCmd.Location = new System.Drawing.Point(141, 316);
            this.searchCmd.Name = "searchCmd";
            this.searchCmd.Size = new System.Drawing.Size(125, 23);
            this.searchCmd.TabIndex = 12;
            this.searchCmd.Text = "rechercher";
            this.searchCmd.UseVisualStyleBackColor = true;
            this.searchCmd.Click += new System.EventHandler(this.searchCmd_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(16, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "Client";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(16, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 33);
            this.label10.TabIndex = 7;
            this.label10.Text = "Reference commande";
            // 
            // clientCmd
            // 
            this.clientCmd.Location = new System.Drawing.Point(128, 116);
            this.clientCmd.Name = "clientCmd";
            this.clientCmd.Size = new System.Drawing.Size(138, 20);
            this.clientCmd.TabIndex = 4;
            this.clientCmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientCmd_KeyPress);
            // 
            // refcmd
            // 
            this.refcmd.Location = new System.Drawing.Point(128, 72);
            this.refcmd.Name = "refcmd";
            this.refcmd.Size = new System.Drawing.Size(138, 20);
            this.refcmd.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(29, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 34);
            this.label9.TabIndex = 2;
            this.label9.Text = "Rechercher Commande";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.datefin);
            this.groupBox1.Controls.Add(this.datedebut);
            this.groupBox1.Location = new System.Drawing.Point(19, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 133);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Commande";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 23);
            this.label13.TabIndex = 12;
            this.label13.Text = "Fin";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "Debut";
            // 
            // datefin
            // 
            this.datefin.Location = new System.Drawing.Point(89, 79);
            this.datefin.Name = "datefin";
            this.datefin.Size = new System.Drawing.Size(138, 20);
            this.datefin.TabIndex = 10;
            // 
            // datedebut
            // 
            this.datedebut.Location = new System.Drawing.Point(91, 41);
            this.datedebut.Name = "datedebut";
            this.datedebut.Size = new System.Drawing.Size(138, 20);
            this.datedebut.TabIndex = 9;
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
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.nomCl);
            this.panel4.Location = new System.Drawing.Point(12, 363);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 352);
            this.panel4.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tel";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "CP";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ville";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(108, 286);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(122, 20);
            this.tel.TabIndex = 5;
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(108, 238);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(122, 20);
            this.cp.TabIndex = 4;
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(108, 191);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(122, 20);
            this.ville.TabIndex = 3;
            // 
            // rue
            // 
            this.rue.Location = new System.Drawing.Point(108, 144);
            this.rue.Name = "rue";
            this.rue.Size = new System.Drawing.Size(122, 20);
            this.rue.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(29, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Infos Clients";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomCl
            // 
            this.nomCl.Location = new System.Drawing.Point(108, 101);
            this.nomCl.Name = "nomCl";
            this.nomCl.Size = new System.Drawing.Size(122, 20);
            this.nomCl.TabIndex = 0;
            // 
            // GestionCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 749);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des commandes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCmd)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCommande;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Button deleteCommande;
        private System.Windows.Forms.Button editCmd;
        private System.Windows.Forms.Button addCmd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLigneCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomCl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.TextBox rue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox clientCmd;
        private System.Windows.Forms.TextBox refcmd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datefin;
        private System.Windows.Forms.DateTimePicker datedebut;
        private System.Windows.Forms.Button searchCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.Button refreshResearch;
    }
}

