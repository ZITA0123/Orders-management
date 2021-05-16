using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using DAL;

namespace BALSQLSERVER
{
   public  class BALTProduits
    {
        public int AjouterProduit(Product dal)
        {
            int res;
            SqlConnection cn = new SqlConnection();
            cn = Global.seConnecter(Global.cs);
            object[,] tabPMNames =
            {

                {"@code",dal.code },
                {"@des",dal.designation },
                {"@type",dal.typeProduit }

            };
            res = Global.ExecuteroleDbActionNomsParams(@"insert into produit (codeProduit,designation,codeTProduit) values (@code,@des,@type)", cn, tabPMNames);
            Global.seDeconnecter(cn);

            return res;
        }
    }
}
