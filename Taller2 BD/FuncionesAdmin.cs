using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Formulario que permite la interacción solamente al administrador
*/

namespace Taller2_BD
{
    public partial class FuncionesAdmin : Form
    {
        public FuncionesAdmin()
        {
            InitializeComponent();
            
        }

        /*
         * Botón que redirecciona al formulario que permite ingresar productos
         */

        private void ingresoProducto_Click(object sender, EventArgs e)
        {
            InsertarProducto productoI = new InsertarProducto();
            productoI.Show();
        }


        /*
         *  Botón que redirecciona al formulario de eliminado de producto
         */

        private void eliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto productoEl = new EliminarProducto();
            productoEl.Show();
        }

        /*
         *  Botón que redirecciona al formulario de ingresado de cliente, sean nacionales o extranjeros
         */

        private void ingresarCliente_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
        }

        /*
         *  Botón que redirecciona al formulario de eliminado de cliente, sean nacionales o extranjeros
         */

        private void eliminarCliente_Click(object sender, EventArgs e)
        {
            EliminarCliente eliminarCliente = new EliminarCliente();
            eliminarCliente.Show();
        }

        /*
         *  Botón que redirecciona al formulario de actualizado de precio de un producto
         */

        private void actualizarPrecio_Click(object sender, EventArgs e)
        {
            ActualizarPrecio actualizarPrecio = new ActualizarPrecio();
            actualizarPrecio.Show();
        }

        /*
         *  Botón que redirecciona al formulario de actualizado de ciudad de un cliente extranjero
         */

        private void actualizarCiudad_Click(object sender, EventArgs e)
        {
            ActualizarCiudadExtra actCiudad = new ActualizarCiudadExtra();
            actCiudad.Show();
        }
    }
}
