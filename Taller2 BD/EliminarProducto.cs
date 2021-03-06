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
 * Formulario para eliminar un producto
 */

namespace Taller2_BD
{
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        /*
         * Método que actualiza y rellena un combo box con los nombres de un producto
        */

        private void rellenar()
        {
            comboBox_eliminar.Items.Clear();
            try
            {
                int estado = 1;
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string consulta = "SELECT * FROM producto WHERE estado = '" + estado + "\'";
                DataTable tabla = conex.selectQuery(consulta);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_eliminar.Items.Add(tabla.Rows[i]["nombre"]);
                }
                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        /*
         * Botón que hace efectivo el eliminado de un producto
        */

        private void button_eliminarProducto_Click(object sender, EventArgs e)
        {
            if (comboBox_eliminar.Text == "")
            {
                MessageBox.Show("Escoger un producto antes de eliminar");
            }
            else
            {
                var msgConfirmacion = MessageBox.Show("¿Estás seguro de la información a eliminar?", "Confirmación", MessageBoxButtons.YesNo);
                if (msgConfirmacion == DialogResult.Yes)
                {
                    try
                    {
                        ConexMySQL conex = new ConexMySQL();
                        conex.open();

                        int estado = 1;
                        int estadoCero = 0;

                        string consultaSeleccion = "SELECT codigo FROM producto WHERE nombre = '" + comboBox_eliminar.Text + "' AND estado = '" + estado + "'";
                        string codigoProducto = conex.selectQueryScalar(consultaSeleccion);

                        string consultaBorrar = "UPDATE producto SET estado = '" + estadoCero + "\' WHERE codigo = '" + codigoProducto + "\'";
                        //string consultaBorrar = "DELETE FROM producto WHERE codigo = " + codigoProducto;
                        int saber = conex.executeNonQuery(consultaBorrar);

                        if (saber == 1)
                        {
                            MessageBox.Show("Se ha eliminado satisfactoriamente el producto");
                            conex.close();
                        }
                        else
                        {
                            MessageBox.Show("Error en la eliminación");
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                
            }
        }

        private void comboBox_eliminar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*
        *  Método que hace llamado al método de rellenado del combo box, en el cual 
        *  están alojadas los nombres de los productos
        */

        private void comboBox_eliminar_DropDown(object sender, EventArgs e)
        {
            rellenar();
        }
    }
}
