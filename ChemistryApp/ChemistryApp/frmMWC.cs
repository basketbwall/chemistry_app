using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemistryApp
{
    public partial class frmMWC : Form
    {
        //class variable for elements that can be accessed in any function in this form
        public frmMWC()
        {
            InitializeComponent();
        }

        private void txtMolecule_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string moleculeString = txtMolecule.Text;

            //algorithm to parse molecule string


            
        }

        private void frmMWC_Load(object sender, EventArgs e)
        {
            //load up items into list of elements
        }
    }
}
