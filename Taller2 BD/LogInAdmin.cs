using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

/*
 *  Formulario dónde el administrador inicia sesión
*/

namespace Taller2_BD
{
    public partial class LogInAdmin : Form
    {
        public LogInAdmin()
        {
            InitializeComponent();
        }

        /*
         *  Botón de redirección hacia e las funciones que realiza el administrador
         */

        private void button_entrarAdmin_Click(object sender, EventArgs e)
        {
           
            if (textBox_idAdmin.Text == "" || textBox_passwordAdmin.Text == "")
            {
                MessageBox.Show("Rellenar los campos vacíos");
            }
            else
            {
                try
                {
                    ConexMySQL conex = new ConexMySQL();
                    conex.open();
                    string consultaID = "SELECT nombre_id FROM admin";
                    string consultaPassword = "SELECT password FROM admin";

                    string id = conex.selectQueryScalar(consultaID);
                    string password = conex.selectQueryScalar(consultaPassword);

                    if (textBox_idAdmin.Text.Equals(id) && textBox_passwordAdmin.Text.Equals(password))
                    {

                        // Mostrar ventana de funciones al administrador
                        FuncionesAdmin funcionAdmin = new FuncionesAdmin();
                        MessageBox.Show("INGRESO EXITOSO");
                        funcionAdmin.Show();

                    }
                    else
                    {
                        MessageBox.Show("NO SE HA COMPROBADO EXITOSAMENTE EL INGRESO");
                    }

                    conex.close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            
            
            
        }

        /*
         *  Función de mostrar elementos en el text box que corresponde a la contraseña de administrador
         */

        private void checkBox_mostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            textBox_passwordAdmin.UseSystemPasswordChar = !checkBox_mostrarPass.Checked;
            
        }

        private void textBox_passwordAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        /*
         * Botón de redirección al menú principal
         */

        private void button_volverMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal.control_admin = false;
            this.Close();
        }
    }
}
