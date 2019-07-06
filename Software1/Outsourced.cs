using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1
{
    public class Outsourced : Part_ab
    {
        private string companyName;

        public Outsourced(int partID, string name, double price, int inStock, int min, int max, string companyName)
            : base(partID, name, price, inStock, min, max)
        { companyName = companyName; }
        public string getCompanyName() { return companyName; }
        public void setCompanyName(string companyName) { this.companyName = companyName; }

    }
}
