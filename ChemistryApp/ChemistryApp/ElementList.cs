using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemistryApp
{
    class ElementList
    {
        private List<Element> Elements = new List<Element>(); // private list

        public void addElement(Element e) // method to add element to element list
        {
            Elements.Add(e);
        }

        // add indexer to allow access to data with index
        public Element this[int i]
        {
            get { return Elements[i]; }
            set { Elements[i] = value; }
        }

        //method to print all items in the list
        public override string ToString()
        {
            string output = "";
            foreach(Element e in Elements)
            {
                output += e.getDisplayText("\n"); //loop through everything in the list and put a new line in as separator
            }
            return output;
        }


    }
}
