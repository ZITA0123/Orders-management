using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TProduit
    {
        public int code { get; set; }
        public String designation { get; set; }
        public TProduit(int c,String d)
        {
            this.code = c;
            this.designation = d;
        }
        public TProduit( String d)
        {
            
            this.designation = d;
        }
        public TProduit() { }
    }
}
