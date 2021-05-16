using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BALSQLSERVER;
using DAL;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mini_Projet
{
    public partial class ListeClient : Form
    {
        String clientt;
        String ruee;
        String villee;
        int cpp;
        int tell;
        int clientId;
        public ListeClient()
        {
            InitializeComponent();
        }

       
        public  void  remplirDgvClient()
        {
           
            dgvClient.Rows.Clear();

            SqlConnection cn = new SqlConnection();
            SqlDataReader lect;
            cn = Global.seConnecter(Global.cs);

            lect = Global.ExecuterOleDBSelect(@"select * from client order by idClient asc", cn);

            while (lect.Read())
            {
                dgvClient.Rows.Add(lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString(), lect.GetValue(4), lect.GetValue(5));

                Client cl= new Client(lect.GetInt32(0), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString(), lect.GetInt32(0), lect.GetInt32(0));
               
            }
            Global.seDeconnecter(cn);
            lect.Close();

        }

        private void ListeClient_Load(object sender, EventArgs e)
        {
            remplirDgvClient();
        }

       
      
        //rECHERCHE DDE CLIENTS
        private void searchClient_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataReader lect;
            cn = Global.seConnecter(Global.cs);
            if(!(client.Text=="") || !(rue.Text=="") || !(ville.Text=="") || !(cp.Text=="") )
            {

                if (operateur.Text=="")
                {      
                        MessageBox.Show("Choisir l'operatuer de recherche.");
                }
                else
                {
                    if (operateur.SelectedItem.ToString() == "OR")
                    {
                        lect = Global.ExecuterOleDBSelect(@"select * from client where nom ='" + client.Text + "' " + operateur.SelectedItem.ToString() + " rue ='" + rue.Text + "' " + operateur.SelectedItem.ToString() + " ville ='" + ville.Text + "' " + operateur.SelectedItem.ToString() + " cp ='" + cp.Text + "' ", cn);
                    }
                    else
                    {
                        lect = Global.ExecuterOleDBSelect(@"select * from client where nom like '%" + client.Text + "%' " + operateur.SelectedItem.ToString() + " rue like '%" + rue.Text + "%' " + operateur.SelectedItem.ToString() + " ville  like '%" + ville.Text + "%' " + operateur.SelectedItem.ToString() + " cp like '%" + cp.Text + "%' ", cn);
                    }

                    dgvClient.Rows.Clear();
                    while (lect.Read())
                    {

                        dgvClient.Rows.Add(lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString(), lect.GetValue(4), lect.GetValue(5));

                        Client cl = new Client(lect.GetInt32(0), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString(), lect.GetInt32(0), lect.GetInt32(0));


                    }
                    Global.seDeconnecter(cn);
                    lect.Close();
                }
                

            }
            else
            {
                MessageBox.Show("Entrer les criteres de recherches.");
            }



        }

      
      
        

        private void cp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
       
        //SELECTION D4UN CLIENT
        private void clientCmde_Click(object sender, EventArgs e)
        {
            if (dgvClient.SelectedRows.Count > 0)
            {
               
                SqlConnection cn = new SqlConnection();
               
                 cn = Global.seConnecter(Global.cs);
                  Object o = Global.ExecuterOleDBScalaire(@"select idClient from client where tel="+ dgvClient.SelectedRows[0].Cells[4].Value.ToString(), cn);

                 this.clientId = Int32.Parse(o.ToString());
                 this.clientt = dgvClient.SelectedRows[0].Cells[0].Value.ToString();
                 this.ruee = dgvClient.SelectedRows[0].Cells[1].Value.ToString();
                 this.villee = dgvClient.SelectedRows[0].Cells[2].Value.ToString();
                 this.cpp = Int32.Parse(dgvClient.SelectedRows[0].Cells[3].Value.ToString());
                 this.tell = Int32.Parse(dgvClient.SelectedRows[0].Cells[4].Value.ToString());
               
                // this.Dispose();

            }
            else
            {
                MessageBox.Show("Choisir un client.");
            }
        }

        public object[] returneChoix()
        {
           Object[] tab= { this.clientt, this.ruee, this.villee, this.cpp, this.tell, this.clientId };
            return tab;
                 
        }


        //REFRESH LA PAGE
      

        private void button1_Click(object sender, EventArgs e)
        {
            client.Text = "";
            rue.Text = "";
            client.Text = "";
            rue.Text = "";
            ville.Text = "";
            cp.Text = "";
            remplirDgvClient();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            AddClient ac = new AddClient();
            ac.ShowDialog();
            remplirDgvClient();
        }
    }
}
