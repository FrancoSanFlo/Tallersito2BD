using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2_BD
{
    public partial class FuncionesAdmin : Form
    {
        public FuncionesAdmin()
        {
            InitializeComponent();
        }

        private void ingresoProducto_Click(object sender, EventArgs e)
        {
            InsertarProducto productoI = new InsertarProducto();
            productoI.Show();
        }

        private void eliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto productoEl = new EliminarProducto();
            productoEl.Show();
        }

        private void ingresarCliente_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
        }

        private void eliminarCliente_Click(object sender, EventArgs e)
        {
            EliminarCliente eliminarCliente = new EliminarCliente();
            eliminarCliente.Show();
        }

        private void actualizarPrecio_Click(object sender, EventArgs e)
        {
            ActualizarPrecio actualizarPrecio = new ActualizarPrecio();
            actualizarPrecio.Show();
        }

        private void actualizarCiudad_Click(object sender, EventArgs e)
        {
            ActualizarCiudadExtra actCiudad = new ActualizarCiudadExtra();
            actCiudad.Show();
        }
    }
}
