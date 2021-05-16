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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

       

        private void annuler_Click(object sender, EventArgs e)
        {
            client.Text = "";
            rue.Text = "";
            ville.Text = "";
            cp.Text = "";
            tel.Text = "";
        }

        private void cp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void AjoutClien_Click(object sender, EventArgs e)
        {
            int res;
            BALClient bl = new BALClient();
            Client dl = new Client();
            if (client.Text == "" || rue.Text == "" || ville.Text == "" || cp.Text == "" || tel.Text == "")
            {
                MessageBox.Show("Remplir les champs.");
            }
            else
            {
                dl.nom = client.Text;
                dl.rue = rue.Text;
                dl.ville = ville.Text;
                dl.cp = Int32.Parse(cp.Text);
                dl.tel = Int32.Parse(tel.Text);
                res = bl.AjouterClient(dl);
                if (res == 1)
                {
                    MessageBox.Show("Succès Ajout de nouveau client.");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Echec Ajout de nouveau client.");
                }
            }

        }
    }
}
