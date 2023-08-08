using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncomprobarForm1_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(txtEdadForm1.Text);
            if (edad >= 18) ;
            MessageBox.Show("usted es mayor de edad");
          
        }
    }
}
