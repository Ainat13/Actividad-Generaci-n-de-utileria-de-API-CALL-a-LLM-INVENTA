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
    public partial class Form_inventario : Form 
    {
        public Form_inventario()
        {
            InitializeComponent();
        }

        //Configuración de la ventana del formulario
        private void Form_inventariol_Load(object sender, EventArgs e) 
        {
            Consulta_BD consultas = new Consulta_BD(); //accede a los métodos de consulta de la BD
            dgv_inventario.DataSource = consultas.consultar_inventario(); //obtiene los datos de de la BD y los muestra

            Estilo_tablas.Aplicar(dgv_inventario); //se aplican las caracteristicas visuales a las tablas
        }
    }
}
