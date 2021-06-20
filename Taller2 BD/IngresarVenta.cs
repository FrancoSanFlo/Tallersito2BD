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
    public partial class IngresarVenta : Form
    {
        public IngresarVenta()
        {
            InitializeComponent();

            textBox_nombreProducto.ReadOnly = true;


        }

        int index_fila_matriz = 0;
        string[,] matriz_detalle_venta = new string[100, 3];
        int monto_total = 0;
        string fecha_ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        private void button_volver_Click(object sender, EventArgs e)
        {
            MenuPrincipal.control_ingresoVenta = false;
            this.Close();
        }

        private void IngresarVenta_Load(object sender, EventArgs e)
        {
            comboBox_cliente.Items.Clear(); //limpiar elementos antiguos del comboBox
            try
            {
                //COMBO BOX CLIENTE
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                int estado = 1;
                string consultaIdCliente = "SELECT * FROM cliente WHERE cliente.estado = '" + estado + "'";
                DataTable tabla = conex.selectQuery(consultaIdCliente);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_cliente.Items.Add(tabla.Rows[i]["codigo"]);
                    
                }

                //COMBO BOX PRODUCTO

                string consulta_idProducto = "SELECT * FROM producto WHERE producto.estado = '" + estado + "'";
                DataTable tabla_idProducto = conex.selectQuery(consulta_idProducto);
                for (int x = 0; x < tabla_idProducto.Rows.Count; x++)
                {
                    comboBox_codigoProducto.Items.Add(tabla_idProducto.Rows[x]["codigo"]);
                }

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void comboBox_codigoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                int estado = 1;
                string query = "SELECT producto.nombre FROM producto WHERE producto.codigo = " + comboBox_codigoProducto.Text + " AND producto.estado= '" + estado + "'";
                textBox_nombreProducto.Text = conex.selectQueryScalar(query);

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_agregarProducto_Click(object sender, EventArgs e)
        {
            matriz_detalle_venta[index_fila_matriz, 0] = textBox_codigoVenta.Text;//ID de Venta  
            matriz_detalle_venta[index_fila_matriz, 1] = comboBox_codigoProducto.Text;//ID producto
            matriz_detalle_venta[index_fila_matriz, 2] = textBox_cantidad.Text;//Cantidad de producto

            index_fila_matriz++;//aumentar el indice para la siguiente fila, el siguiente producto
            try
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string consulta = "SELECT producto.precio_unitario FROM producto WHERE producto.codigo = " + comboBox_codigoProducto.Text;
                int precio_unitario = int.Parse(conex.selectQueryScalar(consulta));
                int cantidad = int.Parse(textBox_cantidad.Text);
                monto_total += precio_unitario * cantidad;


                MessageBox.Show("El monto total es: " + monto_total.ToString(), "Monto Total", MessageBoxButtons.OK);


                textBox_nombreProducto.Clear();
                textBox_cantidad.Clear();

                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_ingresarVenta_Click(object sender, EventArgs e)
        {
            
            if (comboBox_cliente.Text == "" || comboBox_codigoProducto.Text == "" || textBox_codigoVenta.Text == "")
            {
                MessageBox.Show("Campo Cliente o Producto en blanco, ingrese todos los datos");
            }
            else
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                try
                {
                    if (checkBox_ordenCompleta.Checked == true)
                    {
                        //Crear tabla venta primero, luego asociar el detalle
                        int codigo = int.Parse(textBox_codigoVenta.Text);
                        int codigoCliente = int.Parse(comboBox_cliente.Text);
                        string insertar_venta = "INSERT INTO venta(cod_venta, clientecodigo , fecha, subtotal) VALUES(" + codigo + ","  + codigoCliente  + ", " + "\"" + fecha_ahora + "\"" + "," + monto_total + ")";

                        int correct_venta = conex.executeNonQuery(insertar_venta);
                        if (correct_venta == 1)
                        {
                            //Crear tabla Cantidad_producto_venta
                            for (int a = 0; a < index_fila_matriz; a++)
                            {
                                int Ventacodigo = int.Parse(matriz_detalle_venta[a, 0]);
                                int Productocodigo = int.Parse(matriz_detalle_venta[a, 1]);
                                int cantidad_producto = int.Parse(matriz_detalle_venta[a, 2]);
                                string insertar_producto = "INSERT INTO detalle(ventacod_venta, Productocodigo, cantidad) VALUES(" + Ventacodigo + "," + Productocodigo + "," + cantidad_producto + ")";

                                int insercion_correcta = conex.executeNonQuery(insertar_producto);

                                if (insercion_correcta != 1)
                                {
                                    break;
                                }

                            }
                            index_fila_matriz = 0;//restablecer el indice para utilizar la matriz para la siguiente venta
                        }
                        MessageBox.Show("Venta ingreasada correctamente");

                        conex.close();
                    }
                    else
                    {
                        MessageBox.Show("Verifique que ha terminado de ingresar productos a la venta");
                    }



                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
