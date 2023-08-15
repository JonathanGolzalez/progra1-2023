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
    public partial class cboDeConversores : Form
    {
        public cboDeConversores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarConversores_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertirConversores_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0;


            de = comboBox1.SelectedIndex;
            a = cboAConversores.SelectedIndex;

            cantidad = double.Parse(cboCantidadConversores.Text);

            double[] monedas = { 1, 0.92, 7.86, 24.66, 8.75, 36.58, 535.14, 145.47, 0.79, 83.29 };
            respuesta = monedas[a] / monedas[de] * cantidad;

            lblRespuestaConversores.Text = "Respuesta: " + Math.Round(respuesta,3);
        }
    }
    }

