using System;
using System.Windows.Forms;

namespace Generacion_de_utileria
{
    public partial class Form_chatIA : Form
    {
        public Form_chatIA()
        {
            InitializeComponent();
        }

        public Form_chatIA(string pregunta)
        {
            InitializeComponent();

            rtb_conversacion.AppendText(  //Para mostrar la pregunta realizada
                "Tú: " + pregunta + Environment.NewLine //se agrega el salto de línea
            );
        }

        // Configuración del botón de enviar del chatIA
        private async void btn_enviar_Click(object sender, EventArgs e)
        {
            string pregunta = tb_pregunta_chat.Text.Trim();

            if (string.IsNullOrWhiteSpace(pregunta))
            {
                MessageBox.Show("Escribe una pregunta.");
                return;
            }

            rtb_conversacion.AppendText(
                "Tú: " + pregunta + Environment.NewLine
            );

            tb_pregunta_chat.Clear();

            try
            {
                // Consultar los datos actuales de AWS
                Consulta_BD consultas = new Consulta_BD();

                string informacionInventario =
                    consultas.Obtener_contexto_inventario();

                // Preparar el contexto que recibirá Groq
                string contexto = $@"
                    Eres InventAI, un asistente inteligente para la gestión de inventarios.

                    Utiliza la siguiente información de la base de datos para responder
                    las preguntas del usuario.

                    INFORMACIÓN ACTUAL DE LA EMPRESA:
                    {informacionInventario}

                    INSTRUCCIONES:
                    - Responde siempre en español.
                    - Utiliza los datos proporcionados.
                    - No inventes cantidades, productos ni empleados.
                    - Si no encuentras un dato, indícalo.
                    - Explica los resultados de manera clara.
                    - Si te preguntan algo que no está en la base de datos,
                      aclara que no tienes esa información.

                    PREGUNTA DEL USUARIO:
                    {pregunta}
                    ";

                // Crear la conexión con Groq
                Conexion_Groq groq = new Conexion_Groq();

                // Enviar el contexto y recibir la respuesta
                string respuesta =
                    await groq.EnviarPreguntaAsync(contexto);

                // Mostrar la respuesta en el chat
                rtb_conversacion.AppendText(
                    "InventAI: " + respuesta + Environment.NewLine
                );
            }
            catch (Exception ex) //Mensaje de error en caso de falla de comunicación con la API
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Error al comunicarse con InventoryAI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
