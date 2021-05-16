using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Client
    {
        public int id { get; set; }
        public String nom { get; set; }
        public String rue { get; set; }
        public String ville { get; set; }
        public int cp { get; set; }
        public int tel { get; set; }

        public Client(int id, String n, String r, String v,int cp,int t)
        {
            this.id = id;
            this.nom = n;
            this.rue = r;
            this.ville = v;
            this.cp = cp;
            this.tel = t;
        }
        public Client() { }

    }
}
