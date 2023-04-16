using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compiladores
{
    public partial class FormAnalizarCadena : Form
    {
        public FormAnalizarCadena()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            string cadena = txtCadena.Text;
            char[] arreglo = new char[cadena.Length];
            arreglo = cadena.ToCharArray();
            int edoActual = 0;
            int res = 0;

            for(int i=0; i<cadena.Length; i++)
            {
                if (AFD.tablaAFD[edoActual, (int)cadena[i]] != -1)
                {
                    edoActual = AFD.tablaAFD[edoActual, (int)cadena[i]];
                }
                else
                {
                    res = -1;
                    break;
                }
            }
            if (res != -1)
            {
                lblResultado.Text = "¡La cadena es valida!";
                lblResultado.BackColor = Color.Green;
            }
            else
            {
                lblResultado.Text = "La cadena es invalida";
                lblResultado.BackColor = Color.Red;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
