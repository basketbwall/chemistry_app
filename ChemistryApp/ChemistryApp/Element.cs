using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemistryApp
{
    class Element
    {
        public double MolecularWeight { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public Element(double molecularweight, string name, string symbol)
        {
            MolecularWeight = molecularweight;
            Name = name;
            Symbol = symbol;
        }

        public string getDisplayText(string sep) //returns string with specified separator
        {
            return Name + sep + Symbol + sep + MolecularWeight + sep;
        }

        public override string ToString()
        {
            return getDisplayText(" ");
        }
    }
}
