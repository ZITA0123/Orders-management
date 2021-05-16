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
    public partial class AjoutCmd : Form
    {
       
        public AjoutCmd()
        {
            InitializeComponent();
            modifierCmde.Visible = false;
        }
        
       
        public AjoutCmd(String c,String r,String v,String cop, String t)
        {
            InitializeComponent();
            this.choisirClient.Text = c;
            this.rue.Text = r;
            this.ville.Text = v;
            this.cp.Text = cop;
            this.tel.Text = t;
            modifierCmde.Visible = false;

        }
        //Modifier commande
        public AjoutCmd(int refcmde,String date,String c, String r, String v, int cop, int t)
        {
            InitializeComponent();
            refCmd.Text = refcmde.ToString() ;
            dateCmd.Text = date;
            choisirClient.Text = c;
            rue.Text = r;
            ville.Text = v;
            cp.Text = cop.ToString();
            tel.Text = t.ToString();
            refCmd.Enabled = false;
            ajouterCmd.Visible = false;
        }
        int idMonClient;
       
       

       
        //SUPPRIMER UNE LIGNE DE COMMANDE
        private void deleteLignCmd_Click(object sender, EventArgs e)
        {
           BALLigneCmd bl = new BALLigneCmd();
           LigneCmd dl = new LigneCmd();
            if (dgvLigneCmd.SelectedRows.Count == 0)
            {
                MessageBox.Show("selectionner une entrée", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (MessageBox.Show("Voulez vous supprimer cette commande?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //dl.numCmd = Int32.Parse(dgvLigneCmd.SelectedRows[0].Cells[0].Value.ToString());
                dl.numCmd = Int32.Parse(refCmd.Text);
                dl.codeProduit= dgvLigneCmd.SelectedRows[0].Cells[3].Value.ToString();

                bl.SupprimerLigneCommande(dl);
                remplirDgvLigneCmd();

            }
        }
     
             public void remplirDgvLigneCmd()
             {
                dgvLigneCmd.Rows.Clear();
                SqlConnection cn = new SqlConnection();
                SqlDataReader lect;
                cn = Global.seConnecter(Global.cs);
           
            
                lect = Global.ExecuterOleDBSelect(@"select p.designation,l.qte,l.prix,p.codeProduit from ligcmd l, produit p where numCmd=" +Int32.Parse(refCmd.Text) + "and l.codeProduit=p.codeProduit order by numCmd asc", cn);

                while (lect.Read())
                {
                    dgvLigneCmd.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1), lect.GetValue(2), lect.GetValue(3));
                    dgvLigneCmd.Columns["codeProduit"].Visible = false;

                }
                Global.seDeconnecter(cn);
                lect.Close();
        }

       //RECUPERER UNE COMMANDE
        public int getCommande()
        {
            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
            SqlDataReader lect;
            lect = Global.ExecuterOleDBSelect(@"select idClient from commande where numCmd=" + Int32.Parse(refCmd.Text), cn);
            while (lect.Read())
            {
                this.idMonClient = lect.GetInt32(0);
            }
            lect.Close();
            Object o = Global.ExecuterOleDBScalaire(@"select count(*) from commande where numCmd=" + Int32.Parse(refCmd.Text), cn);
            //this.idMonClient
            Global.seDeconnecter(cn);
            return Int32.Parse(o.ToString());   
        }

        //AjouterLigCmd UNE LIGNE DE COMMANDE
        private void ajouterLigCmd_Click(object sender, EventArgs e)
        {
            if (!(refCmd.Text=="") || !(choisirClient.Text==""))
            {

                if (getCommande() == 0)
                    ajouterCommande(Int32.Parse(refCmd.Text), dateCmd.Value.ToShortDateString(), this.idMonClient);
                AjouterLigCmd al = new AjouterLigCmd(Int32.Parse(refCmd.Text));
                al.ShowDialog();
                remplirDgvLigneCmd();
            }
            else
            {
                MessageBox.Show("Veillez ajouter une commande.");
            }
        }

       
        private void ajouterCmd_Click(object sender, EventArgs e)
        {
           
           MessageBox.Show(" ajout de commande reussi.");
           
            this.Dispose();
        }

        private void refCmd_TextChanged(object sender, EventArgs e)
        {
            ajouterLigCmd.Enabled = true;
        }

       public void ajouterCommande(int num,String date,int id)
        {
                   
            int res;
          BALCommande bl = new BALCommande();
          Commande dl = new Commande();
            dl.numCmd = num;
           dl.date = date;
           dl.idClient =id ;

           res = bl.AjouterCommande(dl);
           if (res == 1)
           {
               MessageBox.Show("Succès Ajout d'une nouvelle commande.");
           }
           else
           {
               MessageBox.Show("Echec d'Ajout d'une nouvelle commande.");
           }
           
        }

        //MODIFIER LIGNE DE COMMANDE
        private void modifLigCmd_Click(object sender, EventArgs e)
        {
           
           /* SqlConnection cn = new SqlConnection();
            SqlDataReader lect;
            cn = Global.seConnecter(Global.cs);*/
            if (dgvLigneCmd.SelectedRows.Count == 0)
            {
                MessageBox.Show("selectionner une entrée", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // return; 
            }
            else
            {
              
               // lect = Global.ExecuterOleDBSelect(@"select l.codeProduit from ligcmd l, produit p where l.codeProduit=p.codeProduit and numCmd=" + Int32.Parse(refCmd.Text) +" and p.designation ='"+dgvLigneCmd.SelectedRows[0].Cells[0].Value.ToString()+"'  " , cn);

               // AjouterLigCmd al = new AjouterLigCmd(Int32.Parse(refCmd.Text), lect.GetValue(0).ToString());
                    AjouterLigCmd al = new AjouterLigCmd(Int32.Parse(refCmd.Text));
                    al.ShowDialog();

                
                //Global.seDeconnecter(cn);
               // lect.Close();
            }
            remplirDgvLigneCmd();
           
        }

        private void dgvLigneCmd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void modifierCmde_Click(object sender, EventArgs e)
        {
            BALCommande bl = new BALCommande();
            Commande dl = new Commande();
            dl.numCmd = Int32.Parse(refCmd.Text);
            dl.date = dateCmd.Value.ToShortDateString();
            dl.idClient = this.idMonClient;

            bl.ModifierCommande(dl);
            MessageBox.Show("Mise a jour de la  commande reussie.");
            this.Dispose();
        }

        private void refCmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        //CHOISIR UN CLIENT POUR VOTRE COMMANDE
        private void choisirClient_KeyDown(object sender, KeyEventArgs e)
        {
            ListeClient cl = new ListeClient();
            cl.ShowDialog();

            if (cl.returneChoix().Length == 0)
            {
                MessageBox.Show("Aucun client selectionné");
            }
            else
            {
                choisirClient.Text = cl.returneChoix()[0].ToString();
                rue.Text = cl.returneChoix()[1].ToString();
                ville.Text = cl.returneChoix()[2].ToString();
                cp.Text = cl.returneChoix()[3].ToString();
                tel.Text = cl.returneChoix()[4].ToString();
                this.idMonClient = Int32.Parse(cl.returneChoix()[5].ToString());

            }
        }

        private void ville_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
