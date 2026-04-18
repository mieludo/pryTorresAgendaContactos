using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTorresAgendaContactos
{
    public partial class frmAgendaContactos : Form
    {
        //DECLARACION DE VARIABLES GLOBALES
        string varNombre = "";
        string varApellido = "";
        string varCorreoElectronico = "";
        string varCategoria = "";
        int varTelefono = 0;



        public frmAgendaContactos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tboNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
                tboNombre.Focus();
            }
            else
            {
                if (tboApellido.Text == "")
                {
                    MessageBox.Show("Ingrese el apellido");
                    tboApellido.Focus();
                }
                else
                {
                    if (tboCorreo.Text == "")
                    {
                        MessageBox.Show("Ingrese el correo electrónico");
                        tboCorreo.Focus();
                    }
                    else
                    {
                        if (mtbTelefono.Text == "")
                        {
                            MessageBox.Show("Ingrese el número de teléfono");
                            mtbTelefono.Focus();
                        }
                        else
                        {
                            if (cboCategoria.Text == "")
                            {
                                MessageBox.Show("Ingrese la categoría");
                                cboCategoria.Focus();
                            }
                            else
                            {
                                

                            }
                        }
                    }
                }
            }
        }
    }
}
