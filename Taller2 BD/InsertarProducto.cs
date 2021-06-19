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
    public partial class InsertarProducto : Form
    {
        public InsertarProducto()
        {
            InitializeComponent();
        }

        private void insercionDatos_Click(object sender, EventArgs e)
        {
            int stockProducto = int.Parse(textBox_stock.Text);
            int precioUnitario = int.Parse(textBox_precio.Text);
            
            

            if (textBox_codigo.Text == "" || textBox_nombre.Text == "" || textBox_stock.Text == "" || textBox_precio.Text == "")
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
                        ConexMySQL conex = new ConexMySQL();
                        conex.open();
                        int estado = 1;
                        string consultaEntrada = "INSERT INTO producto(codigo,nombre,stock,precio_unitario,estado) VALUES(\"" + textBox_codigo.Text + "\",\"" + textBox_nombre.Text + "\",\"" + stockProducto + "\",\"" + precioUnitario + "\",\""+ estado  +"\")" ;
                        int saber = conex.executeNonQuery(consultaEntrada);

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

        private void InsertarProducto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
