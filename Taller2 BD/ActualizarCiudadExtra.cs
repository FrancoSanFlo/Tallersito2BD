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
    public partial class ActualizarCiudadExtra : Form
    {
        public ActualizarCiudadExtra()
        {
            InitializeComponent();
        }

        private void rellenar()
        {
            comboBox_ciudades.Items.Clear();
            try
            {
                int estado = 1;
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string consulta = "SELECT cliente_extranjero.nombre_extranjero, cliente_extranjero.clientecodigo FROM cliente_extranjero INNER JOIN cliente ON cliente.codigo = cliente_extranjero.clientecodigo AND cliente.estado = '" + estado + "\'";
                DataTable tabla = conex.selectQuery(consulta);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_ciudades.Items.Add(tabla.Rows[i]["nombre_extranjero"]);
                }
                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            if (comboBox_ciudades.Text == "")
            {
                MessageBox.Show("Escoger un cliente antes de actualizar su ciudad");
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

                        string consultaSeleccion = "SELECT clientecodigo FROM cliente_Extranjero WHERE nombre_extranjero = '" + comboBox_ciudades.Text + "'";
                        string codigoCliente = conex.selectQueryScalar(consultaSeleccion);

                        string consultaBorrar = "UPDATE cliente_extranjero SET ciudad = '" + textBox_ciudad.Text + "\' WHERE clientecodigo = '" + codigoCliente + "\'";
                        //string consultaBorrar = "DELETE FROM producto WHERE codigo = " + codigoProducto;
                        int saber = conex.executeNonQuery(consultaBorrar);

                        if (saber == 1)
                        {
                            MessageBox.Show("Se ha actualizado la ciudad del cliente satisfactoriamente");
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

        private void comboBox_ciudades_DropDown(object sender, EventArgs e)
        {
            rellenar();
        }
    }
}
