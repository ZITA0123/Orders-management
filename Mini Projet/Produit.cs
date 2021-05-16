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
    public partial class Produit : Form
    {
        public Produit()
        {
            InitializeComponent();
        }
        public void remplirDgvProduit()
        {

            dgvProduit.Rows.Clear();

            SqlConnection cn = new SqlConnection();
            SqlDataReader lect;
            cn = Global.seConnecter(Global.cs);

           
            lect = Global.ExecuterOleDBSelect(@"select p.codeProduit, p.designation,t.designation,p.codeTProduit from produit p,tproduit t where p.codeTProduit=t.codeTProduit order by codeProduit asc", cn);
            


            while (lect.Read())
            {
                
                dgvProduit.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(), lect.GetValue(2).ToString());


                Product p = new Product(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(),lect.GetInt32(3) );
               
            }

            Global.seDeconnecter(cn);
            lect.Close();
           





        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProduit_Click(object sender, EventArgs e)
        {
            AddProduit ap = new AddProduit();
            ap.ShowDialog();
            remplirDgvProduit();
            
        }

        private void Produit_Load(object sender, EventArgs e)
        {
            remplirDgvProduit();
        }

        private void annulerSearch_Click(object sender, EventArgs e)
        {
            designation.Text = "";
            remplirDgvProduit();
        }

        private void searchProduit_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataReader lect;
            cn = Global.seConnecter(Global.cs);
            if (!(designation.Text == "") )
            {
                  lect = Global.ExecuterOleDBSelect(@"select p.codeProduit, p.designation,t.designation,p.codeTProduit from produit p,tproduit t where p.designation like '%" + designation.Text + "%' and p.codeTProduit=t.codeTProduit  ", cn);
                
                dgvProduit.Rows.Clear();
                while (lect.Read())
                {

                    dgvProduit.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(), lect.GetValue(2).ToString());

                    Product p = new Product(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(), lect.GetInt32(3));


                }
                Global.seDeconnecter(cn);
                lect.Close();

            }
            else
            {
                MessageBox.Show("Entrer les criteres de recherches.");
            }



        }
        String cProduit;
        String typeP;
        String des;

        //SELECTION D'UN PRODUIT
        private void choisirProduit_Click(object sender, EventArgs e)
        {
            if (dgvProduit.SelectedRows.Count > 0)
            {
                cProduit = dgvProduit.SelectedRows[0].Cells[0].Value.ToString();
                typeP = dgvProduit.SelectedRows[0].Cells[1].Value.ToString();
                des = dgvProduit.SelectedRows[0].Cells[2].Value.ToString();
               
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Choisir un Produit.");
            }
        }
        public string[] returneChoix()
        {
            String[] tab = { cProduit, typeP, des };
            return tab;

        }
    
    }
}
