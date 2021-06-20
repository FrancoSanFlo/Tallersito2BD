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
 * Formulario de interacción para obtener listas 
*/

namespace Taller2_BD
{
    public partial class ProcesoEnlistado : Form
    {
        public ProcesoEnlistado()
        {
            
            InitializeComponent();


        }

        /*
         * Botón que permite visualizar el listado de los clientes nacionales, los cuales están habilitados
         */

        private void button_listaNacional_Click(object sender, EventArgs e)
        {

            ConexMySQL conex = new ConexMySQL();
            int estado = 1;
            conex.open();
            string consulta = "SELECT cliente_local.clientecodigo, cliente_local.nombre_nacional, cliente_local.ciudad  FROM cliente_local INNER JOIN cliente ON cliente.codigo = cliente_local.clientecodigo AND cliente.estado = '" + estado + "\'";
            DataTable tabla = conex.selectQuery(consulta);
            datosListas.DataSource = tabla;
            conex.close();
        }

        /*
         * Botón que permite visualizar el listado de los clientes extranjeros, los cuales están habilitados
         */

        private void button_listaExtranjero_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            int estado = 1;
            conex.open();
            string consulta = "SELECT cliente_extranjero.clientecodigo, cliente_extranjero.nombre_extranjero, cliente_extranjero.pais, cliente_extranjero.ciudad  FROM cliente_extranjero INNER JOIN cliente ON cliente.codigo = cliente_extranjero.clientecodigo AND cliente.estado = '" + estado + "\'";
            DataTable tabla = conex.selectQuery(consulta);
            datosListas.DataSource = tabla;
            conex.close();
        }

        /*
         * Botón que permite visualizar el listado de todos los clientes, sean extranjeros o nacionales(habilitados)
         */

        private void button_listaGralClientes_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            int estado = 1;
            conex.open();
            string consulta = "SELECT codigo, cliente_extranjero.nombre_extranjero, cliente_local.nombre_nacional FROM cliente LEFT JOIN cliente_local ON cliente_local.clientecodigo = cliente.codigo LEFT JOIN cliente_extranjero ON cliente.codigo = cliente_extranjero.clientecodigo WHERE cliente.estado = '" + estado + "\'";
            DataTable tabla = conex.selectQuery(consulta);
            datosListas.DataSource = tabla;
            conex.close();
        }

        /*
         * Botón que permite visualizar el listado de los productos habilitados
         */

        private void button_listaProdAct_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            int estado = 1;
            conex.open();
            string consulta = "SELECT codigo, nombre, precio_unitario, stock  FROM producto WHERE estado = '" + estado + "\'";
            DataTable tabla = conex.selectQuery(consulta);
            datosListas.DataSource = tabla;
            conex.close();
        }

        private void linkLabel_haciaMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuPrincipal.control_ingresoSitio = false;
            this.Close();

        }
    }
}
