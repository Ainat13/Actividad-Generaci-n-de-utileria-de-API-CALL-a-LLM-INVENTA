using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generacion_de_utileria
{
    public partial class Form_producto : Form
    {
        public Form_producto()
        {
            InitializeComponent();
        }

        //configura la ventana de productos
        private void Form_producto_Load(object sender, EventArgs e)
        {
            Consulta_BD consultas = new Consulta_BD(); 
            dgv_producto.DataSource = consultas.consultar_productos(); //obtiene y muestra los datos de la BD

            Estilo_tablas.Aplicar(dgv_producto); //aplica el estilo a las tablas
        }
    }


}
