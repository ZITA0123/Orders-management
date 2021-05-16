using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
namespace BALSQLSERVER
{
    public class BALCommande
    {
        public int AjouterCommande(Commande dal)
        {
            int res;
            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
            object[,] tabPMNames =
            {
                {"@num",dal.numCmd },
                {"@date",dal.date },
                {"@client",dal.idClient }

            };
            res = Global.ExecuteroleDbActionNomsParams(@"insert into commande (numCmd,dateCmd,idClient) values (@num,@date,@client)", cn, tabPMNames);
            Global.seDeconnecter(cn);
            return res;
        }
        public void SupprimerCommande(Commande dal)
        {

            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
            object[,] tabPMNames =
            {
                {"@num",dal.numCmd }


            };
            Global.ExecuteroleDbActionNomsParams(@"delete from commande where numCmd = @num", cn, tabPMNames);
            Global.seDeconnecter(cn);


           
        }

        public void ModifierCommande(Commande dal)
        {

            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
            object[,] tabPMNames =
            {
                {"@num",dal.numCmd },
                {"@date",dal.date },
                {"@client",dal.idClient }
            };
            Global.ExecuteroleDbActionNomsParams(@"update commande set dateCmd=@date, idClient=@client where numCmd=@num ", cn, tabPMNames);
            Global.seDeconnecter(cn);
        }
    }
}
