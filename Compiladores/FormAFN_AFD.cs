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
    public partial class FormAFN_AFD : Form
    {
        public int[,] tablaEdos;
        public FormAFN_AFD()
        {
            InitializeComponent();
        }

        public void Mostrar()
        {
            int row=0;
            dataGridView1.ColumnCount = AFD.edosAFD;
            dataGridView1.RowCount = AFD.edosAFD;
            for (int f=0; f<256; f++)
            {
                for(int c=0; c< AFD.edosAFD; c++)
                {
                    if(AFD.tablaAFD[c, f] != -1)
                    {
                        dataGridView1[row, c].Value = AFD.tablaAFD[c, f];
                        row++;
                    }
                        
                }
            }
            Console.WriteLine("Se obtuvo la tabla");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
