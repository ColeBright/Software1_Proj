using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 "Part_Ab.cs";


namespace Software1
{
    class Product
    {
        private Arraylist<Part_ab> associatedParts;
        private int productID;
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
        public void addAssociatedPart(Part)
        public bool removeAssociatedPart(int)
        public Part_ab lookupAssociatedPart(int)
        public void setProductID(int)
        public int getProductID()


         
    }
}
