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
    public partial class FormCerrKleen : Form
    {
        private int valorSeleccionado;

        public FormCerrKleen()
        {
            InitializeComponent();
        }

        private void FormCerrKleen_Load(object sender, EventArgs e)
        {
            foreach (var afns in AFN.ConjDeAFNs)
            {
                comboBox1.Items.Add(afns.IdAFN.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                valorSeleccionado = Int32.Parse(comboBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Debe seleccionar un valor antes de continuar.");
            }

            for (int i = AFN.ConjDeAFNs.Count - 1; i >= 0; i--)
            {
                if (AFN.ConjDeAFNs.ElementAt(i).IdAFN == valorSeleccionado)
                {
                    AFN.ConjDeAFNs.ElementAt(i).CerrKleen();
                    this.Close();
                }

            }
        }
    }
}
