using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BALSQLSERVER
{
    public class Global
    {
       
        static public String cs = @"Data Source=DESKTOP-TJKJR8O\SQLSERVER;Initial Catalog=GestionCommande;Integrated Security=True";

        // static public String cs = @"Provider=Microsoft.ACE.OLEDB.12.0; data source=|DataDirectory|MaBase.accdb";
        static public SqlConnection seConnecter(String strCN)
        {
            SqlConnection objCN = new SqlConnection();
            try
            {
                objCN.ConnectionString = strCN;
                if (objCN.State == System.Data.ConnectionState.Closed)
                    objCN.Open();
            }
            catch (Exception)
            {

                throw;
            }
            return objCN;
        }
        static public void seDeconnecter(SqlConnection objCN)
        {
            try
            {
                if (objCN.State == System.Data.ConnectionState.Open)
                    objCN.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        static public int ExecuteroleDbActionNomsParams(string strSQL, SqlConnection objCN, Object[,] objPM)
        {
            int nb = -1;
            SqlCommand objCom = new SqlCommand(strSQL, objCN);
            try
            {
                for (int i = 0; i < objPM.GetLength(0); i++)
                {
                    objCom.Parameters.AddWithValue((String)objPM[i, 0], objPM[i, 1]);
                }
                nb = objCom.ExecuteNonQuery();
            }
            catch (Exception )
            {

              
                throw;
            }
            return nb;
        }

        static public Object ExecuterOleDBScalaire(String strSQL, SqlConnection objCN)
        {
            Object obj = new object();
            SqlCommand objCom = new SqlCommand(strSQL, objCN);
            try
            {
                obj = objCom.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            return obj;
        }
        static public SqlDataReader ExecuterOleDBSelect(string strSQL, SqlConnection objCN)
        {
            SqlDataReader objDR = null;
           SqlCommand objCOM = new SqlCommand(strSQL, objCN);
            try
            {
                objDR = objCOM.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
            return objDR;
        }

        //Gestion des requetes Ajout/Supprimer/Update, sans parametres
        static public int ExecuterOleDBAction(String strSQL, SqlConnection objCN)
        {
            int nb = -1; //nombre de lignes affectées
           SqlCommand objCOM = new SqlCommand(strSQL, objCN);
            try
            {
                nb = objCOM.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            return nb;
        }

       
        static public bool ExecuterTransaction(String strCN, params string[] tabSQL)
        {
            bool ok = false;
            SqlCommand objCOM = new SqlCommand();
           SqlTransaction transact;
            try
            {
                SqlConnection objCN = Global.seConnecter(strCN);
                objCOM.Connection = objCN;
                transact = objCN.BeginTransaction();
                objCOM.Transaction = transact;
                try
                {
                    foreach (String strSQL in tabSQL)
                    {
                        objCOM.CommandText = strSQL;
                        int i = objCOM.ExecuteNonQuery();
                    }
                    transact.Commit();
                    ok = true;
                }
                catch (Exception)
                {
                    transact.Rollback();
                    ok = false;
                }
                finally
                {
                    Global.seDeconnecter(objCN);
                }
            }
            catch (Exception)
            {
                ok = false;
            }
            return ok;
        }

    }

}
