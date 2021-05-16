using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Commande
    {
        public int numCmd { get; set; }
        //public DateTime date { get; set; }
        public String date { get; set; }
        //public date date { get; set; }
        public int idClient { get; set; }
        public Commande(int num, String d,int idCl)
        {
            numCmd = num;
            date = d;
            idClient = idCl;
        }
        public Commande() { }

    }
}
