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
    public partial class AjouterLigCmd : Form
    {
        int numCmd;
        String codProduit;


        public AjouterLigCmd()
        {
            InitializeComponent();
        }
        public AjouterLigCmd(int numCmd)
        {
            InitializeComponent();
            this.numCmd = numCmd;
        }
        public AjouterLigCmd(int numCmd, String c)
        {
            InitializeComponent();
            this.numCmd = numCmd;
            this.codProduit = c;
        }

       

        //AJOUTER LIGNE DE COMMANDE
        private void addLiCmd_Click(object sender, EventArgs e)
        {
            int res;
            BALLigneCmd bl = new BALLigneCmd();
            LigneCmd dl = new LigneCmd();
           

                if (!(produit.Text == "") || !(txtprix.Text == "") || !(txtprix.Text == ""))
                {
                
                    dl.codeProduit = produit.Text;
                    dl.numCmd = this.numCmd;

                    dl.qte = Int32.Parse(txtquantite.Text);
                    dl.prix = Decimal.Parse(txtprix.Text);

                if (getLigneCommande() == 0)
                {
                    res = bl.AjouterLigneCommande(dl);
                    if (res == 1)
                    {
                        MessageBox.Show("Succès Ajout d'une nouvelle Ligne de commande.");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Echec d'Ajout d'une nouvelle ligne de  commande.");
                    }
                }
                else
                {
                   
                    bl.ModifierLigneCommande(dl);
                    MessageBox.Show("Ligne deja existante, Mise a jour  reussie.");
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs");
            }
           


        }
     

        private void txtquantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
        public int getLigneCommande()
        {
            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
           
            Object o = Global.ExecuterOleDBScalaire(@"select count(*) from ligcmd where numCmd=" + this.numCmd + "and codeProduit='" + produit.Text + "'", cn);
            
            Global.seDeconnecter(cn);
            return Int32.Parse(o.ToString());
        }

        private void txtprix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void produit_KeyDown(object sender, KeyEventArgs e)
        {
            Produit p = new Produit();
            p.ShowDialog();
            produit.Text = p.returneChoix()[0];
            type.Text = p.returneChoix()[2];
            designat.Text = p.returneChoix()[1];
        }
    }
    
}
