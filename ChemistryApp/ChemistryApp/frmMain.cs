using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemistryApp
{
    public partial class frmMain : Form
    {
        private Stream path;

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form MolecularWeightForm = new frmMWC();
            MolecularWeightForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string dir = @"C:\"; //start with directory of where your file is located
            string path = dir + "elements.txt"; //append the file name after the directory to get the path to your file
            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            //make a streamreader, which requires a filestream object first. now you can start reading from the file

            //algorithm to start the parsing
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                if (row.Contains("name"))
                {
                    int start = row.IndexOf("name") + 7;
                    string elementSubString = row.Substring(start, row.Length -  start);
                    Console.WriteLine(removeFormatting(elementSubString));
                    elementSubString = removeFormatting(elementSubString); // update the elementSubstring
                    //delimit using the space character and store each item in an array
                    
                    //use this array to create an sql insert statement


                }
            }

        }

        private string removeFormatting(string input)
        {
            return removeBackSlash(removen(removeParens(input)));
        }

        private string removeParens(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input.ElementAt(i) == '(')
                {
                    // do nothing
                } else if (input.ElementAt(i) == ')')
                {
                    // do nothing
                } else
                {
                    output += input.ElementAt(i);
                }
            }
            return output;
        }

        private string removeBackSlash(string input)
        {
            string output = "";
            for(int i=0; i<input.Length; i++)
            {
                if (input.ElementAt(i) != '\\') {
                    output += input.ElementAt(i);
                }
            }
            return output;
        }

        private string removen(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input.ElementAt(i) != 'n')
                {
                    output += input.ElementAt(i);
                } else
                {
                    output += " ";
                }
            }
            return output;
        }
    }
}
