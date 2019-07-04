using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1
{
    abstract class Part_ab
    {
        private int partID;
        private string name;
        private double price;
        private int inStock;
        private int min;
        private int max;

        public void setName(string) { };
        public string getName() { };
        public void setPrice(double) { };
        public double getPrice() { };
        public setInStock(int) { };
        public int getInStock() { };
        public setMin(int) { };
        public int getMin() { };
        public void setMax(int) { };
        public int getMax() { };
        public void setPartID(int);
        public int getPartID();

    }
}
