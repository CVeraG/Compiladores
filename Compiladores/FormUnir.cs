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
    public partial class FormUnir : Form
    {
        private int valorSeleccionado;
        private int valorSeleccionado2;
        public FormUnir()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormUnir_Load(object sender, EventArgs e)
        {
            foreach (var afns in AFN.ConjDeAFNs)
            {
                comboBox1.Items.Add(afns.IdAFN.ToString());
                comboBox2.Items.Add(afns.IdAFN.ToString());
            }
                        
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                valorSeleccionado = Int32.Parse(comboBox1.SelectedItem.ToString());
                valorSeleccionado2 = Int32.Parse(comboBox2.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Debe seleccionar un valor antes de continuar.");
            }
            
            for (int i = AFN.ConjDeAFNs.Count - 1; i >= 0; i--)
            {
                for (int j = AFN.ConjDeAFNs.Count - 1; j >= 0; j--)
                {
                   if  (AFN.ConjDeAFNs.ElementAt(i).IdAFN == valorSeleccionado && AFN.ConjDeAFNs.ElementAt(j).IdAFN == valorSeleccionado2)
                    {
                        AFN.ConjDeAFNs.ElementAt(i).UnirAFN(AFN.ConjDeAFNs.ElementAt(j));
                        AFN.ConjDeAFNs.Remove(AFN.ConjDeAFNs.ElementAt(j)); 
                        this.Close();
                    }
                }
            }

                        

            
        }

    }
    
}
