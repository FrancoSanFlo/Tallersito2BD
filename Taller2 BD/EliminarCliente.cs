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
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void rellenarNacional()
        {
            comboBox_clienteNacional.Items.Clear();
            try
            {
                int estado = 1;
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string consulta = "SELECT cliente_local.nombre_nacional FROM cliente_local INNER JOIN cliente ON cliente.codigo = cliente_local.clientecodigo AND cliente.estado = '" + estado + "\'";
                DataTable tabla = conex.selectQuery(consulta);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_clienteNacional.Items.Add(tabla.Rows[i]["nombre_nacional"]);
                }
                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void rellenarExtranjero()
        {
            comboBox_clienteExtranjero.Items.Clear();
            try
            {
                int estado = 1;
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string consulta = "SELECT cliente_extranjero.nombre_extranjero FROM cliente_extranjero INNER JOIN cliente ON cliente.codigo = cliente_extranjero.clientecodigo AND cliente.estado = '" + estado + "\'";

                DataTable tabla = conex.selectQuery(consulta);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    comboBox_clienteExtranjero.Items.Add(tabla.Rows[i]["nombre_extranjero"]);
                }
                conex.close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_clienteExtranjero_Click(object sender, EventArgs e)
        {
            if (comboBox_clienteExtranjero.Text == "")
            {
                MessageBox.Show("Escoger un cliente antes de eliminar");
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

                        string consultaSeleccion = "SELECT cliente_extranjero.clientecodigo FROM cliente_extranjero INNER JOIN cliente ON cliente.codigo = cliente_extranjero.clientecodigo AND cliente.estado = '" + estado + "' AND cliente_extranjero.nombre_extranjero = '" + comboBox_clienteExtranjero.Text + "'";
                       // string consultaSeleccion = "SELECT clientecodigo FROM cliente_extranjero WHERE nombre = '" + comboBox_clienteExtranjero.Text + "\' AND estado = '" + estado + "\'";
                        string codigoCliente = conex.selectQueryScalar(consultaSeleccion);

                        string consultaBorrar = "UPDATE cliente SET estado = '" + estadoCero + "\' WHERE codigo = '" + codigoCliente + "\'";
                        //string consultaBorrar = "DELETE FROM producto WHERE codigo = " + codigoProducto;
                        int saber = conex.executeNonQuery(consultaBorrar);

                        if (saber == 1)
                        {
                            MessageBox.Show("Se ha eliminado satisfactoriamente el cliente");
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

        private void button_clienteNacional_Click(object sender, EventArgs e)
        {
            if (comboBox_clienteNacional.Text == "")
            {
                MessageBox.Show("Escoger un cliente antes de eliminar");
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

                        string consultaSeleccion = "SELECT cliente_local.clientecodigo FROM cliente_local INNER JOIN cliente ON cliente.codigo = cliente_local.clientecodigo AND cliente.estado = '" + estado + "' AND cliente_local.nombre_nacional = '" + comboBox_clienteNacional.Text + "'";
                        // string consultaSeleccion = "SELECT clientecodigo FROM cliente_extranjero WHERE nombre = '" + comboBox_clienteExtranjero.Text + "\' AND estado = '" + estado + "\'";
                        string codigoCliente = conex.selectQueryScalar(consultaSeleccion);

                        string consultaBorrar = "UPDATE cliente SET estado = '" + estadoCero + "\' WHERE codigo = '" + codigoCliente + "\'";
                        //string consultaBorrar = "DELETE FROM producto WHERE codigo = " + codigoProducto;
                        int saber = conex.executeNonQuery(consultaBorrar);

                        if (saber == 1)
                        {
                            MessageBox.Show("Se ha eliminado satisfactoriamente el cliente");
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

        private void comboBox_clienteExtranjero_DropDown(object sender, EventArgs e)
        {
            rellenarExtranjero();
        }

        private void comboBox_clienteNacional_DropDown(object sender, EventArgs e)
        {
            rellenarNacional();
        }

        
    }
}
