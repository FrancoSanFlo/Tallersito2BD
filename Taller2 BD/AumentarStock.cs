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
    public partial class AumentarStock : Form
    {
        public AumentarStock()
        {
            InitializeComponent();
            textBox_stockActual.ReadOnly = true;
            textBox_stockActual.BackColor = System.Drawing.SystemColors.Window;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void rellenar()
        {
            comboBox_nomProdAumento.Items.Clear();
            try
            {
                int estado = 1;
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string consulta = "SELECT * FROM producto WHERE estado = '" + estado + "'";
                DataTable tabla = conex.selectQuery(consulta);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_nomProdAumento.Items.Add(tabla.Rows[i]["nombre"]);

                }
                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void button_resfrescarDatos_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            int estado = 1;
            conex.open();
            string consulta = "SELECT codigo, nombre, precio_unitario, stock  FROM producto WHERE estado = '" + estado + "\'";
            DataTable tabla = conex.selectQuery(consulta);
            datoStock.DataSource = tabla;
            conex.close();
        }

        private void comboBox_nomProdAumento_DropDown(object sender, EventArgs e)
        {
            rellenar();
        }


        private void checkBox_confirmarNombre_CheckedChanged(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string consulta = "SELECT stock FROM producto WHERE nombre = '" + comboBox_nomProdAumento.Text + "'";
            string completada = conex.selectQueryScalar(consulta);
            textBox_stockActual.Text = completada;
            conex.close();
        }

        private void button_ingresoStock_Click(object sender, EventArgs e)
        {
            if (comboBox_nomProdAumento.Text == "")
            {
                MessageBox.Show("Escoger un producto antes de actualizar su stock");
            }
            else
            {

                var msgConfirmacion = MessageBox.Show("¿Estás seguro de la información a ingresar?", "Confirmación", MessageBoxButtons.YesNo);

                if (msgConfirmacion == DialogResult.Yes)
                {
                    try
                    {
                        ConexMySQL conex = new ConexMySQL();
                        conex.open();

                        int estado = 1;

                        int stockNuevo = int.Parse(textBox_stockIngresado.Text);

                        string consultaStock = "SELECT stock FROM producto WHERE nombre = '" + comboBox_nomProdAumento.Text + "' AND estado = '" + estado + "'";
                        int stockActual = int.Parse(conex.selectQueryScalar(consultaStock));
                        int sumarStock = stockActual + stockNuevo;
                        string consultaSeleccion = "SELECT codigo FROM producto WHERE nombre = '" + comboBox_nomProdAumento.Text + "' AND estado = '" + estado + "'";
                        string codigoProducto = conex.selectQueryScalar(consultaSeleccion);
                        string consultaStockNuevo = "UPDATE producto SET stock = '" + sumarStock + "' WHERE codigo = '" + codigoProducto + "'";

                        int saber = conex.executeNonQuery(consultaStockNuevo);


                        if (saber == 1)
                        {
                            MessageBox.Show("Stock actualizado satisfactoriamente");
                            conex.close();
                        }
                        else
                        {
                            MessageBox.Show("Error en la actualizacion de stock");
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
    
}
