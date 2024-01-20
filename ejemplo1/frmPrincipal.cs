using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Con el foreach recorro para ver si no hay otra ventana abierta
            foreach (var item in Application.OpenForms)
            {
                // Pregunto si el item es igual al tipo de item que el formulario
                if(item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe un formulario abierto, termine de trabajar allí");
                    return;
                    // Hago que retorne y se quede ahi para no poder abrir más
                }
            }
            
            
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
            
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
            // ShowDialog para no poder salir de la ventana hasta que no se complete todo
            // Así no pasa de abrir infinitas veces la misma ventana
        }
    }
}
