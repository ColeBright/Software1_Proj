using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1
{
    class Inventory
    {
        private List<Product> Products;
        private List<Part_ab> allParts;

        public void addProduct(Product z) { Products.Add(z); }
        public bool removeProduct(int a) { Products.Remove(a); }// is this a mistake on the UML?
        public Product lookupProduct(int b);
        public void updateProduct(int c, Product d);
        public void addPart(Part_ab e) { allParts.Add(e); }
        public bool deletePart(Part_ab f) { allParts.Remove(f); }
        public Part_ab lookupPart(int g);
        public void updatePart(int h, Part_ab j);
    }
}
