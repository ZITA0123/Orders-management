using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LigneCmd
    {
        public string codeProduit { get; set; }
        public int numCmd { get; set; }
        public int qte { get; set; }
        public decimal prix { get; set; }

        public LigneCmd(String c, int q, decimal prix)
        {
            this.codeProduit = c;
            this.qte = q;
            this.prix = prix;
        }
        public LigneCmd() { }
    }
}
