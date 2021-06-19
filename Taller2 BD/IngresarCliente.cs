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
    public partial class IngresarCliente : Form
    {
        public IngresarCliente()
        {
            InitializeComponent();
        }

        private void button_ingresarNacional_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(textBox_codigoCliente.Text);


            if (textBox_codigoCliente.Text == "" || textBox_nombreCliente.Text == "" || textBox_ciudadCliente.Text == "")
            {
                MessageBox.Show("Rellene los campos vacíos");
            }
            else
            {

                var msgConfirmacion = MessageBox.Show("¿Estás seguro de la información a ingresar?", "Confirmación", MessageBoxButtons.YesNo);

                if (msgConfirmacion == DialogResult.Yes)
                {

                    try
                    {
                        int estado = 1;
                        ConexMySQL conex = new ConexMySQL();
                        conex.open();
                        string consultaClienteTable = "INSERT INTO cliente(codigo,estado) VALUES(\"" + codigo + "\",\"" + estado + "\")";
                        string consultaEntrada = "INSERT INTO cliente_local(clientecodigo,nombre_nacional,ciudad) VALUES(\"" + codigo + "\",\"" + textBox_nombreCliente.Text + "\",\"" + textBox_ciudadCliente.Text + "\")";
                        int saber = conex.executeNonQuery(consultaClienteTable);
                        int saber2 = conex.executeNonQuery(consultaEntrada);

                        MessageBox.Show("Inserción correcta");
                        conex.close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }

        private void button_ingresarExtranjero_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(textBox_codigoClienteExtra.Text);


            if (textBox_codigoClienteExtra.Text == "" || textBox_nombreClienteExtra.Text == "" || textBox_paisCliente.Text == "" || textBox_ciudadClienteExtra.Text == "")
            {
                MessageBox.Show("Rellene los campos vacíos");
            }
            else
            {

                var msgConfirmacion = MessageBox.Show("¿Estás seguro de la información a ingresar?", "Confirmación", MessageBoxButtons.YesNo);

                if (msgConfirmacion == DialogResult.Yes)
                {

                    try
                    {
                        int estado = 1;
                        ConexMySQL conex = new ConexMySQL();
                        conex.open();
                        string consultaClienteTable = "INSERT INTO cliente(codigo,estado) VALUES(\"" + codigo + "\",\"" + estado + "\")";
                        string consultaEntrada = "INSERT INTO cliente_extranjero(clientecodigo,nombre_extranjero,pais,ciudad) VALUES(\"" + codigo + "\",\"" + textBox_nombreClienteExtra.Text + "\",\"" + textBox_paisCliente.Text + "\",\"" + textBox_ciudadClienteExtra.Text + "\")";
                        int saber = conex.executeNonQuery(consultaClienteTable);
                        int saber2 = conex.executeNonQuery(consultaEntrada);

                        MessageBox.Show("Inserción correcta");
                        conex.close();
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
