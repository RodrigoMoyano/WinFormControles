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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {   //De esta manera si quiero que mi ventana perfil personal aparezca
            //dentro de mi ventana personal, tengo que realizar este forech
            //para que no me permita abrir la ventana perfil personal multiples
            //veces, ya que no puedo usar el showdialog por que da error,
            //solo puedo usar el show.
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe esta ventana abierta, termine de trabajar alli.");
                    return;

                }
                    
            }

            //Como navego a otra ventana? Creando una instancia de un objeto
            //Asi voy a poder mostrar lo progranado en Form1 cuando apretemos en Opeciones : Perfil Persona
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tabPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 venta = new Form1();
            venta.ShowDialog();
        }
    }
}
