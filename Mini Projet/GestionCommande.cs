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
    public partial class GestionCommande : Form
    {
        public GestionCommande()
        {
            InitializeComponent();
        }

       
        public void remplirDgvCommande()
        {
            dgvCommande.Rows.Clear();
           

            SqlConnection cn = new SqlConnection();
            SqlDataReader lect;
            cn = Global.seConnecter(Global.cs);

            lect = Global.ExecuterOleDBSelect(@"select numCmd,dateCmd,nom,c.idClient from commande c,client cl where cl.idClient=c.idClient order by numCmd asc", cn);

            while (lect.Read())
            {
                dgvCommande.Rows.Add(lect.GetValue(0), lect.GetValue(1).ToString(), lect.GetValue(2),lect.GetValue(3));

                Commande cl = new Commande(lect.GetInt32(0), lect.GetValue(1).ToString(), lect.GetInt32(3));
               dgvCommande.Columns["idClient"].Visible = false;
            }
            Global.seDeconnecter(cn);
            lect.Close();

        }
        public void remplirDgvLigneCommande()
        {
            dgvLigneCmd.Rows.Clear();
            SqlConnection cn = new SqlConnection();
            SqlDataReader lect;
            cn = Global.seConnecter(Global.cs);
            if (dgvCommande.SelectedRows.Count > 0)
            {
                lect = Global.ExecuterOleDBSelect(@"select p.designation,l.qte,l.prix from ligcmd l, produit p where numCmd=" + Int32.Parse(dgvCommande.SelectedRows[0].Cells[0].Value.ToString())+ "and l.codeProduit=p.codeProduit order by numCmd asc", cn);

                while (lect.Read())
                {
                    dgvLigneCmd.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1), lect.GetValue(2));

               
                }
                Global.seDeconnecter(cn);
                lect.Close();

            }
            else
            {
               
                lect = Global.ExecuterOleDBSelect(@"select p.designation,l.qte,l.prix from ligcmd l, produit p where numCmd=" + Int32.Parse(dgvCommande.Rows[0].Cells[0].Value.ToString()) + "and l.codeProduit=p.codeProduit order by numCmd asc", cn);

                while (lect.Read())
                {
                    dgvLigneCmd.Rows.Add(lect.GetValue(0), lect.GetValue(1).ToString(), lect.GetValue(2));

                 
                }
                Global.seDeconnecter(cn);
                lect.Close();
            }


        }

        //RECUPERER INFOS DU CLIENT
        public void infoClient()
        {
            BALClient bc = new BALClient();
            Client c = new Client();
           
           
            SqlDataReader lect;
            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
            if (dgvCommande.SelectedRows.Count > 0)
            {
                lect = Global.ExecuterOleDBSelect(@"select * from client where idClient=" + dgvCommande.SelectedRows[0].Cells[3].Value.ToString(), cn);
                while (lect.Read())
                {
                    nomCl.Text = lect.GetValue(1).ToString();
                    rue.Text = lect.GetValue(2).ToString();
                    ville.Text = lect.GetValue(3).ToString();
                    cp.Text = lect.GetValue(4).ToString();
                    tel.Text = lect.GetValue(5).ToString();
                }
                Global.seDeconnecter(cn);
                lect.Close();
            }
            else
            {
                lect = Global.ExecuterOleDBSelect(@"select * from client where idClient=" + dgvCommande.Rows[0].Cells[3].Value.ToString(), cn);
                while (lect.Read())
                {
                    nomCl.Text = lect.GetValue(1).ToString();
                    rue.Text = lect.GetValue(2).ToString();
                    ville.Text = lect.GetValue(3).ToString();
                    cp.Text = lect.GetValue(4).ToString();
                    tel.Text = lect.GetValue(5).ToString();
                }
                Global.seDeconnecter(cn);
                lect.Close();
            }
           
        }


        private void GestionCommande_Load(object sender, EventArgs e)
        {
            remplirDgvCommande();
           
        }

        //AJOUTER COMMANDE
        private void addCmd_Click(object sender, EventArgs e)
        {
            AjoutCmd ac = new AjoutCmd();
            ac.ShowDialog();
               remplirDgvCommande();
        }


        //SUPPRIMER COMMANDE
        private void deleteCommande_Click(object sender, EventArgs e)
        {
            BALCommande bl = new BALCommande();
            Commande dl = new Commande();
            BALLigneCmd blig = new BALLigneCmd();
            LigneCmd lc = new LigneCmd();
            if (dgvCommande.SelectedRows.Count == 0)
            {
                MessageBox.Show("selectionner une entrée", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (MessageBox.Show("Voulez vous supprimer cette commande?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                dl.numCmd = Int32.Parse(dgvCommande.SelectedRows[0].Cells[0].Value.ToString()) ;
                lc.numCmd = Int32.Parse(dgvCommande.SelectedRows[0].Cells[0].Value.ToString());
                blig.SupprimerLignesCommande(lc);
                bl.SupprimerCommande(dl);
                remplirDgvCommande();
            }
           
        }


        //MODIFIER COMMANDE
        private void editCmd_Click(object sender, EventArgs e)
        {
           
            SqlConnection cn = new SqlConnection();
            SqlDataReader lect;
            cn = Global.seConnecter(Global.cs);
            if (dgvCommande.SelectedRows.Count == 0)
            {
                MessageBox.Show("selectionner une entrée", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // return; 
            }
            else
            {
                lect = Global.ExecuterOleDBSelect(@"select numCmd,dateCmd,nom,rue,ville,cp,tel from commande,client where commande.idClient=client.idClient and numCmd="+ Int32.Parse(dgvCommande.SelectedRows[0].Cells[0].Value.ToString()), cn);

                while (lect.Read())
                {
                   
                    AjoutCmd aj = new AjoutCmd(lect.GetInt32(0), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString(), lect.GetValue(4).ToString(), lect.GetInt32(5), lect.GetInt32(6));
                    aj.remplirDgvLigneCmd();
                    aj.ShowDialog();
                   
                }
                Global.seDeconnecter(cn);
                lect.Close();

                
            }
            remplirDgvCommande();
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvCommande_SelectionChanged(object sender, EventArgs e)
        {
            infoClient();
            remplirDgvLigneCommande();
            
           
        }

        //RECHERCHER UNE COMMANDE
        private void searchCmd_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataReader lect;
            cn = Global.seConnecter(Global.cs);
            if (!(refcmd.Text == "") || !(clientCmd.Text == "") || !( datedebut.Text == "") || !(datefin.Text == ""))
            {
                if(!(refcmd.Text == ""))
                    lect = Global.ExecuterOleDBSelect(@"select numCmd,dateCmd,nom,c.idClient from commande c,client cl where cl.idClient=c.idClient and numCmd =" + Int32.Parse(refcmd.Text), cn);
                else if(!(clientCmd.Text == ""))
                    lect = Global.ExecuterOleDBSelect(@"select numCmd,dateCmd,nom,c.idClient from commande c,client cl where cl.idClient=c.idClient and c.idClient =" + Int32.Parse(clientCmd.Text), cn);
                else if(!(datedebut.Text == ""))
                    lect = Global.ExecuterOleDBSelect(@"select numCmd,dateCmd,nom,c.idClient from commande c,client cl where cl.idClient=c.idClient and dateCmd ='" + datedebut.Value.ToShortDateString() + "'", cn);
                else
                lect = Global.ExecuterOleDBSelect(@"select numCmd,dateCmd,nom,c.idClient from commande c,client cl where cl.idClient=c.idClient and numCmd =" + Int32.Parse(refcmd.Text) + "and idClient =" + Int32.Parse(clientCmd.Text) + "and dateCmd ='" + datedebut.Value.ToShortDateString() + "'", cn);

                dgvCommande.Rows.Clear();
               while (lect.Read())
                {

                    dgvCommande.Rows.Add(lect.GetValue(0), lect.GetValue(1).ToString(), lect.GetValue(2), lect.GetValue(3));
                    Commande cl = new Commande(lect.GetInt32(0), lect.GetValue(1).ToString(), lect.GetInt32(3));
                }
                Global.seDeconnecter(cn);
                lect.Close();
               

            }
            else
            {
                MessageBox.Show("Entrer les criteres de recherches.");
            }
           


        }

        private void refreshResearch_Click(object sender, EventArgs e)
        {
            clientCmd.Text = "";
            refcmd.Text = "";
            remplirDgvCommande();
        }

        private void clientCmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
    }
}
