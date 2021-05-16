namespace Mini_Projet
{
    partial class ListeClient
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cp = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.rue = new System.Windows.Forms.TextBox();
            this.client = new System.Windows.Forms.TextBox();
            this.operateur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchClient = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.clientCmde = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(25, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Operateur";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(25, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "CP";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ville";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(21, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rue";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Client";
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(117, 277);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(122, 20);
            this.cp.TabIndex = 14;
            this.cp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cp_KeyPress);
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(117, 230);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(122, 20);
            this.ville.TabIndex = 13;
            // 
            // rue
            // 
            this.rue.Location = new System.Drawing.Point(117, 183);
            this.rue.Name = "rue";
            this.rue.Size = new System.Drawing.Size(122, 20);
            this.rue.TabIndex = 12;
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(117, 140);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(122, 20);
            this.client.TabIndex = 11;
            // 
            // operateur
            // 
            this.operateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operateur.FormattingEnabled = true;
            this.operateur.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.operateur.Location = new System.Drawing.Point(117, 322);
            this.operateur.Name = "operateur";
            this.operateur.Size = new System.Drawing.Size(121, 21);
            this.operateur.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "Rechercher Client";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column1,
            this.Column2});
            this.dgvClient.Location = new System.Drawing.Point(256, 12);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.Size = new System.Drawing.Size(627, 377);
            this.dgvClient.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Client";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Rue";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Ville";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code Postal";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Telephone";
            this.Column2.Name = "Column2";
            // 
            // searchClient
            // 
            this.searchClient.Location = new System.Drawing.Point(117, 378);
            this.searchClient.Name = "searchClient";
            this.searchClient.Size = new System.Drawing.Size(121, 23);
            this.searchClient.TabIndex = 7;
            this.searchClient.Text = "rechercher";
            this.searchClient.UseVisualStyleBackColor = true;
            this.searchClient.Click += new System.EventHandler(this.searchClient_Click);
            // 
            // addClient
            // 
            this.addClient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addClient.Location = new System.Drawing.Point(904, 221);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(104, 29);
            this.addClient.TabIndex = 9;
            this.addClient.Text = "Client Inexistant";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // clientCmde
            // 
            this.clientCmde.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clientCmde.Location = new System.Drawing.Point(904, 40);
            this.clientCmde.Name = "clientCmde";
            this.clientCmde.Size = new System.Drawing.Size(104, 23);
            this.clientCmde.TabIndex = 23;
            this.clientCmde.Text = "Valider";
            this.clientCmde.UseVisualStyleBackColor = true;
            this.clientCmde.Click += new System.EventHandler(this.clientCmde_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(904, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientCmde);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchClient);
            this.Controls.Add(this.operateur);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.rue);
            this.Controls.Add(this.client);
            this.Name = "ListeClient";
            this.Text = "ListeClient";
            this.Load += new System.EventHandler(this.ListeClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.TextBox rue;
        private System.Windows.Forms.TextBox client;
        private System.Windows.Forms.ComboBox operateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Button searchClient;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button clientCmde;
        private System.Windows.Forms.Button button1;
    }
}