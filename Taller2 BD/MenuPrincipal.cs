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


//hola franquito uwu
namespace Taller2_BD
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void verDatos_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string consulta = "SELECT * FROM producto";
            DataTable tabla = conex.selectQuery(consulta);
            datos.DataSource = tabla;
            conex.close();
        }

        private void datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button_Administrador_Click(object sender, EventArgs e)
        {
            FuncionesAdmin administrador = new FuncionesAdmin();
            administrador.Show();
        }

        private void button_ingresoSitio_Click(object sender, EventArgs e)
        {
            ProcesoEnlistado enlistado = new ProcesoEnlistado();
            enlistado.Show();
        }

        private void button_aumentoStock_Click(object sender, EventArgs e)
        {
            AumentarStock aumentoStock = new AumentarStock();
            aumentoStock.Show();
        }
    }
}
