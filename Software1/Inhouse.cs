using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1
{
    public class Inhouse : Part_ab
    {
        private int machineID;

        public Inhouse(int partID, string name, double price, int inStock, int min, int max, string machineID)
            : base(partID, name, price, inStock, min, max)
        { machineID = machineID; }
        public void setMachineID(int machineID) { this.machineID = machineID; }
        public int getMachineID() { return machineID; }
    }
}
