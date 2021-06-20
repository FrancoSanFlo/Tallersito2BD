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

namespace Taller2_BD
{
    public partial class DetalleVenta : Form
    {
        public DetalleVenta()
        {
            InitializeComponent();

            dateTimePicker_fechaVenta.Format = DateTimePickerFormat.Custom;

            dateTimePicker_fechaVenta.CustomFormat = "yyyy-MM-dd";
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            MenuPrincipal.control_detalleVenta = false;
            this.Close();
        }

        private void button_consultarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha_consulta = dateTimePicker_fechaVenta.Text;

                ConexMySQL conex = new ConexMySQL();
                conex.open();
                int consulta_clienteID = int.Parse(comboBox_codigoCliente.Text);

                //FROM                                                          
                string consulta_Fecha = "SELECT venta.cod_venta AS \"Venta\", cliente.codigo AS \"Cliente\", producto.codigo AS \"Codigo Producto\", producto.nombre AS \"Nombre Producto\", detalle.cantidad, venta.fecha  FROM venta INNER JOIN detalle ON venta.cod_venta = detalle.ventacod_venta INNER JOIN cliente ON cliente.codigo = venta.clientecodigo INNER JOIN producto ON detalle.Productocodigo = producto.codigo WHERE cliente.codigo = " + consulta_clienteID + " AND venta.fecha LIKE " + "\"" + fecha_consulta + "%\"" + " ORDER BY venta.cod_venta ASC ";

                DataTable tabla = conex.selectQuery(consulta_Fecha);
                dataGridView_ventaConsultada.DataSource = tabla;


                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void comboBox_codigoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                int estado = 1;
                string query = "SELECT cliente_local.nombre_nacional FROM cliente, cliente_local WHERE cliente.codigo = cliente_local.clientecodigo AND cliente.codigo = " + comboBox_codigoCliente.Text + " AND cliente.estado = '" + estado + "'";
                textBox_nombreCliente.Text = conex.selectQueryScalar(query);


                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            comboBox_codigoCliente.Items.Clear(); //limpiar elementos antiguos del comboBox
            try
            {
                //COMBO BOX CLIENTE
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                int estado = 1;
                string consulta_IDcliente = "SELECT * FROM cliente WHERE cliente.estado = '" + estado + "'";
                DataTable tabla = conex.selectQuery(consulta_IDcliente);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    
                    comboBox_codigoCliente.Items.Add(tabla.Rows[i]["codigo"]);
                }

               

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
