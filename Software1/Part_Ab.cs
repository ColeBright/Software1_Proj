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

        public void setName(string name) { this.name = name; }
        public string getName() { return name; }
        public void setPrice(double price) { this.price = price; }
        public double getPrice() { return price; }
        public void setInStock(int inStock) { this.inStock = inStock; }
        public int getInStock() { return inStock; }
        public void setMin(int min) { this.min = min; }
        public int getMin() { return min; }
        public void setMax(int max) { this.max = max; }
        public int getMax() { return max; }
        public void setPartID(int partID) { this.partID = partID; }
        public int getPartID() { return partID; }

    }
}
