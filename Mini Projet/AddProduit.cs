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
    public partial class AddProduit : Form
    {
        public AddProduit()
        {
            InitializeComponent();
           
        }

        private void ajoutProduit_Click(object sender, EventArgs e)
        {
           

           
             int res;
             
            BALProduit bp = new BALProduit();
            Product p = new Product();
            
            
             p.code = codep.Text;
             p.designation = designation.Text;
            int type = Int32.Parse(cmbType.SelectedItem.ToString().Split()[0]);
             p.typeProduit = type;
    
            res = bp.AjouterProduit(p);  
             if (res == 1)
             {
                 MessageBox.Show("Succès Ajout d'un nouveau Produit");
                this.Dispose();
             }
             else
             {
                 MessageBox.Show("Echec Ajout d'un nouveau produit.");
             }
           
        }
        public void remplirTypeProduit()
        {
            

            cmbType.Items.Clear();



            SqlConnection cn = new SqlConnection();
            SqlDataReader lect;
            cn = Global.seConnecter(Global.cs);

            lect = Global.ExecuterOleDBSelect(@"select * from tproduit order by codeTProduit asc", cn);

            while (lect.Read())
            {

                TProduit tp = new TProduit(lect.GetInt32(0), lect.GetValue(1).ToString());

                cmbType.Items.Add(tp.code+" "+tp.designation);
              
            }

            Global.seDeconnecter(cn);
            lect.Close();
        }
        private void AddProduit_Load(object sender, EventArgs e)
        {
          
            remplirTypeProduit();
            }

        private void button5_Click(object sender, EventArgs e)
        {
            designation.Text = "";
            codep.Text = "";
            cmbType.Items.Clear();


        }
    }
}
