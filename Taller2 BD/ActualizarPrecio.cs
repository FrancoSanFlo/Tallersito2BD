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
    public partial class ActualizarPrecio : Form
    {
        public ActualizarPrecio()
        {
            InitializeComponent();
        }

        private void rellenar()
        {
            comboBox_actualizarPrecio.Items.Clear();
            try
            {
                int estado = 1;
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string consulta = "SELECT * FROM producto WHERE estado = '" + estado + "\'";
                DataTable tabla = conex.selectQuery(consulta);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_actualizarPrecio.Items.Add(tabla.Rows[i]["nombre"]);
                }
                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_actualizarPrecio_Click(object sender, EventArgs e)
        {
            if (comboBox_actualizarPrecio.Text == "")
            {
                MessageBox.Show("Escoger un producto antes de actualizar su precio");
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
                        int precioUnitario = int.Parse(textBox_precio.Text);

                        string consultaSeleccion = "SELECT codigo FROM producto WHERE nombre = '" + comboBox_actualizarPrecio.Text + "\' AND estado = '" + estado + "\'";
                        string codigoProducto = conex.selectQueryScalar(consultaSeleccion);

                        string consultaBorrar = "UPDATE producto SET precio_unitario = '" + precioUnitario + "\' WHERE codigo = '" + codigoProducto + "\'";
                        //string consultaBorrar = "DELETE FROM producto WHERE codigo = " + codigoProducto;
                        int saber = conex.executeNonQuery(consultaBorrar);

                        if (saber == 1)
                        {
                            MessageBox.Show("Se ha actualizado el precio del producto");
                            conex.close();
                        }
                        else
                        {
                            MessageBox.Show("Error en la actualizacion");
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                    
            }
        }

        private void comboBox_actualizarPrecio_DropDown(object sender, EventArgs e)
        {
            rellenar();
        }
    }
}
