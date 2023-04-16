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
    public partial class FormAFNBasico : Form
    {
        public FormAFNBasico()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string simb_inferior = textBox1.Text;
            string simb_superior = textBox2.Text;
            string ID = textBox3.Text;
            char[] simb_inferior_char = simb_inferior.ToCharArray();
            char[] simb_superior_char = simb_superior.ToCharArray();
            int id = Int32.Parse(ID);
            AFN afn = new AFN().CrearAFNBasico(simb_inferior_char[0], simb_superior_char[0]);
            afn.IdAFN = id;
            AFN.ConjDeAFNs.Add(afn);
            this.Close();      
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                    {
                MessageBox.Show("Introduce solo numeros", "Aerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void FormAFNBasico_Load(object sender, EventArgs e)
        {

        }
    }
}
