using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Compiladores
{
    public partial class FormUnionEsp : Form
    {
        private int valorSeleccionado;
        private string TOKEN;
        AFN Especial = new AFN();
        public FormUnionEsp()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormUnionEsp_Load(object sender, EventArgs e)
        {
            foreach (var afns in AFN.ConjDeAFNs)
            {
                checkedListBox1.Items.Add(afns.IdAFN.ToString());
            }
            foreach(string item in checkedListBox1.Items)
            {
                System.Windows.Forms.TextBox txtbox = new System.Windows.Forms.TextBox();
                txtbox.Location = new Point(20, 0 + (25 * panel1.Controls.Count));
                txtbox.Size = new Size(150, 20);
                txtbox.Text = item;
                txtbox.Name = item;
                // Agregar el nuevo TextBox al Panel
                panel1.Controls.Add(txtbox);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> listaAFN = new List<string>();
            foreach ( string item in checkedListBox1.Items)
            {
                if (checkedListBox1.CheckedItems.Contains(item)) 
                {
                    listaAFN.Add(item);
                }
            }
            foreach (var afn in AFN.ConjDeAFNs) 
            {
                foreach(string ID in listaAFN)
                {
                    if (Int32.Parse(ID) == afn.IdAFN)
                    {
                        foreach (Control control in panel1.Controls)
                        {
                            if (Int32.Parse(control.Name) == afn.IdAFN)
                            {
                                Especial.UnionEspecialAFNs(afn,Int32.Parse(control.Text));
                            }
                        }    
                    }
                }
            
            }
            Especial.ConvAFNaAFD();
            this.Close();
        }
    }
}
