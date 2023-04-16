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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void claseAFNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void basicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FormAFNBasico();
            Formulario.Show();
        }

        private void unirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FormUnir();
            Formulario.Show();
        }

        private void concatenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FormConc();
            Formulario.Show();
        }

        private void cerraduraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FormCerrPos();
            Formulario.Show();
        }

        private void cerraduraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Formulario = new FormCerrKleen();
            Formulario.Show();
        }

        private void opcionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FormOpc();
            Formulario.Show();
        }

        private void unionParaAnalizadorSintacticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FormUnionEsp();
            Formulario.Show();
        }

        private void convertirAFNAAFDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FormAFN_AFD();
            Formulario.Show();
        }

        private void analizarUnaCadenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FormAnalizarCadena();
            Formulario.Show();
        }
    }
}
