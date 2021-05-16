using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DAL;
namespace BALSQLSERVER
{
    public class BALClient
    {
        public int AjouterClient(Client dal)
        {
            int res;
            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
            object[,] tabPMNames =
            {
               // {"@id",dal.id },
                {"@nom",dal.nom },
                {"@rue",dal.rue },
                {"@ville",dal.ville },
                 {"@cp",dal.cp },
                 {"@tel",dal.tel }
            };
            res = Global.ExecuteroleDbActionNomsParams(@"insert into client (nom,rue,ville,cp,tel) values (@nom,@rue,@ville,@cp,@tel)", cn, tabPMNames);
            Global.seDeconnecter(cn);
           
            return res;
        }
      

    }
}
