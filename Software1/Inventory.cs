using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1
{
    class Inventory
    {
        private ArrayList<Product> Products;
        private ArrayList<Part_ab> allParts;

        public void addProduct(Product);
        public bool removeProduct(int);
        public Product lookupProduct(int);
        public void updateProduct(int, Product);
        public void addPart(Part);
        public bool deletePart(Part);
        public Part_ab lookupPart(int);
        public void updatePart(int, Part_ab);
    }
}
