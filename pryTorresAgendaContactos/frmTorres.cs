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
            string nombre = tboNombre.Text.Trim();
            string apellido = tboApellido.Text.Trim();
            string correo = tboCorreo.Text.Trim();
            string telefono = mtbTelefono.Text.Trim();
            string categoria = cboCategoria.Text.Trim();
            
            
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
                            dgvColumna.Rows.Add(nombre, apellido, telefono, correo, categoria);

                            tboNombre.Clear();
                            tboApellido.Clear();
                            tboCorreo.Clear();
                            mtbTelefono.Clear();
                            cboCategoria.SelectedIndex = -1;
                            tboNombre.Focus();
                        }
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Comprobar que hay una fila seleccionada
            if (dgvColumna.CurrentRow == null)
            {
                MessageBox.Show("Seleccione el contacto que quiera eliminar");
                return;
            }

            // Confirmación antes de eliminar
            var resultado = MessageBox.Show(
                "Quiere eliminar el contacto seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Eliminar la fila seleccionada
                dgvColumna.Rows.RemoveAt(dgvColumna.CurrentRow.Index);

                
                tboNombre.Clear();
                tboApellido.Clear();
                tboCorreo.Clear();
                mtbTelefono.Clear();
                cboCategoria.SelectedIndex = -1;
                tboNombre.Focus();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Comprobar que hay una fila seleccionada
            if (dgvColumna.CurrentRow == null)
            {
                MessageBox.Show("Seleccione el contacto que quiera editar");
                return;
            }
            //Confirmacion antes de editar
            var resultado = MessageBox.Show(
                "Quiere editar el contacto seleccionado?",
                "Confirmar edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                //Editar la fila seleccionada
                dgvColumna.CurrentRow.Cells[0].Value = tboNombre.Text.Trim();


                tboNombre.Clear();
                tboApellido.Clear();
                tboCorreo.Clear();
                mtbTelefono.Clear();
                cboCategoria.SelectedIndex = -1;
                tboNombre.Focus();
            }
        }
    }
}
