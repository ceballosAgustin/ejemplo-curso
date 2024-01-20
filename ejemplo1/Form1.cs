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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Creo un string que va a ser lo que se ingresa en el TextBox
            string elemento = txtNombre.Text;
            lwElementos.Items.Add(elemento);
            // Y acá en la lisat le agrego lo que entra por el string
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
            cboColorFavorito.Items.Add("Azul");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            // Como capturar todos los datos que entran
            // Nombre
            string nombre = txtNombre.Text;

            // Fecha de nacimiento
            DateTime fecha = dtpFechaNacimiento.Value;

            // Te gusta el chocolate?
            // Operador terneario ( ? "" : "" )
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";
            
            // Tipo (Con un IF para chequear cual es el elegido)
            string tipo;
            if(rbtMuggle.Checked)
            {
                tipo = "Muggle";
            }
            else if (rbtWizard.Checked)
            {
                tipo = "Wizard";
            }
            else
            {
                tipo = "Squibs";
            }

            // Color Favorito
            string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            
            // Numero Favorito
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            // Mensaje final al clickear en VER PERFIL
            string mensaje = chocolate + ", es " + tipo + ", su color es " + colorFavorito + ", su numero fav es " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + " Fecha: " + fecha + ", " + mensaje);
        }
    }
}
