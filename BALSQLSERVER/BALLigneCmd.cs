using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
namespace BALSQLSERVER
{
    public class BALLigneCmd
    {
        public void SupprimerLigneCommande(LigneCmd dal)
        {

            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
            object[,] tabPMNames =
            {
                {"@num",dal.numCmd },
                {"@produit",dal.codeProduit }


            };
            Global.ExecuteroleDbActionNomsParams(@"delete from ligcmd where numCmd = @num and codeProduit=@produit", cn, tabPMNames);
            Global.seDeconnecter(cn);

        }
        public void SupprimerLignesCommande(LigneCmd dal)
        {

            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
            object[,] tabPMNames =
            {
                {"@num",dal.numCmd }
               


            };
            Global.ExecuteroleDbActionNomsParams(@"delete from ligcmd where numCmd = @num ", cn, tabPMNames);
            Global.seDeconnecter(cn);



        }
        public int AjouterLigneCommande(LigneCmd dal)
        {
            int res;
            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
            object[,] tabPMNames =
            {
                {"@codep",dal.codeProduit },
                {"@ncmd",dal.numCmd },
                {"@qte",dal.qte },
                {"@prix",dal.prix }

            };
            res = Global.ExecuteroleDbActionNomsParams(@"insert into ligcmd(codeProduit,numCmd,qte,prix) values (@codep,@ncmd,@qte,@prix)", cn, tabPMNames);
            Global.seDeconnecter(cn);
            return res;
        }
        public void ModifierLigneCommande(LigneCmd dal)
        {

            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
            object[,] tabPMNames =
            {
                 {"@codep",dal.codeProduit },
                {"@num",dal.numCmd },
                {"@qte",dal.qte },
                {"@prix",dal.prix }
            };
            Global.ExecuteroleDbActionNomsParams(@"update ligcmd set qte=@qte,prix=@prix where numCmd=@num and codeProduit=@codep ", cn, tabPMNames);
            Global.seDeconnecter(cn);
        }
    }
}
