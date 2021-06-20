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
* Formulario del menú principal de acceso       
*/

namespace Taller2_BD
{
    public partial class MenuPrincipal : Form
    {

        // VARIABLES DE CONTROL DE VENTANAS
        public static bool control_admin = false;
        public static bool control_ingresoSitio = false;
        public static bool control_ingresoVenta = false;

        public MenuPrincipal()
        {
            InitializeComponent();
        }
        /*
         
         */
        private void verDatos_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string consulta = "SELECT * FROM producto";
            DataTable tabla = conex.selectQuery(consulta);
            datos.DataSource = tabla;
            conex.close();
        }

        private void datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        /*
        * Botón que redirige a la ventana de inicio de sesión del administrador
        */

        private void button_Administrador_Click(object sender, EventArgs e)
        {
            if (!control_admin)
            {
                try
                {
                    LogInAdmin administrador = new LogInAdmin();
                    control_admin = true;
                    administrador.ControlBox = false;
                    administrador.Show();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                this.SendToBack();
            }

        }
    
        /*
        * Botón que redirige  hacia las funciones del proceso de enlistado
        */

        private void button_ingresoSitio_Click(object sender, EventArgs e)
        {
            if (!control_ingresoSitio)
            {
                try
                {
                    ProcesoEnlistado enlistado = new ProcesoEnlistado();
                    control_ingresoSitio = true;
                    enlistado.ControlBox = false;
                    enlistado.Show();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            

            
        }

        /*
        * Botón que nos redirige hacia la ventana para poder aumentar el stock del producto escogido
        */

        private void button_aumentoStock_Click(object sender, EventArgs e)
        {
            AumentarStock aumentoStock = new AumentarStock();
            aumentoStock.Show();
        }

        private void button_nuevaVenta_Click(object sender, EventArgs e)
        {
            if (!control_ingresoVenta)
            {
                try
                {
                    IngresarVenta ingresarVenta = new IngresarVenta();
                    control_ingresoVenta = true;
                    ingresarVenta.ControlBox = false;
                    ingresarVenta.Show();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                this.SendToBack();
            }

        }
    }
}
