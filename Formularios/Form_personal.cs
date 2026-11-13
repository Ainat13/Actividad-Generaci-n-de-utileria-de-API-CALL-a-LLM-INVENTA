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
    public partial class Form_personal : Form
    {
        public Form_personal()
        {
            InitializeComponent();
        }

        //configuración de la ventana de personal
        private void Form_personal_Load(object sender, EventArgs e)
        {
            Consulta_BD consultas = new Consulta_BD();
            dgv_personal.DataSource = consultas.consultar_personal(); //Obtiene y muestra los datos de la BD

            Estilo_tablas.Aplicar(dgv_personal); //aplica el estilo de diseño a las tablas

        }
    }
}
