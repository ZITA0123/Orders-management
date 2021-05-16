using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product
    {
        public int typeProduit { get; set; }
        public String code { get; set; }
        public String designation { get; set; }

        public Product(String code, String des, int type)
        {
            this.code = code;
            this.designation = des;
            this.typeProduit = type;
        }
        public Product() { }
    }
}
