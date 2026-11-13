using System.Data;

namespace Generacion_de_utileria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Configuración del botón del personal
        private void btn_personal_Click(object sender, EventArgs e)
        {

            try //try para abrir una nueva ventana 
            {
                Form_personal ventana = new Form_personal();
                ventana.ShowDialog();
            }
            catch (Exception ex) //Mensaje de error por si no es posible abrir la ventana
            {
                MessageBox.Show(
                    "Error al abrir la ventana de personal: " + ex.Message);
            }
        }


        //Configuración del botón de productos
        private void btn_productos_Click(object sender, EventArgs e)
        {
            try //try para abrir la ventana de proucto
            {
                Form_producto ventana = new Form_producto();
                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al abrir la ventana de personal: " + ex.Message);
            }
        }

        //Configuración del botón del inventario
        private void btn_inventario_Click(object sender, EventArgs e)
        {
            try  //try para abrir una nueva ventana con el inventario
            {
                Form_inventario ventana = new Form_inventario();
                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al abrir la ventana de inventario: " + ex.Message);
            }
        }

        //Configuración del botón de enviar mensaje a la IA
        private void btn_ia_Click(object sender, EventArgs e)
        {
            string pregunta = tb_pregunta.Text.Trim();

            if (string.IsNullOrWhiteSpace(pregunta)) //un if en caso de que se presione el botón de enviar sin nada en el cuadro de texto
            {
                MessageBox.Show("Por favor, escribe una pregunta.");
                return;
            }


            Form_chatIA chat = new Form_chatIA(pregunta);// Crea y configura la ventana del chat con la pregunta a la IA
            chat.ShowDialog();// Abre la nueva ventana con el chat
        }
        
    }


}