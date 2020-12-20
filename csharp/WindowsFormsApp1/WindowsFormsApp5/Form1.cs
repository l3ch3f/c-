using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnControle_Click(object sender, EventArgs e)
        {
            {

                if (Convert.ToInt16(txtLeeftijd.Text) >= 18)

                {

                    MessageBox.Show("Je bent boven de 18");

                }

                else

                {

                    MessageBox.Show("Je bent onder de 18");

                }

            }
        }
    }
}
