using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Generacion_de_utileria
{
    internal class Conexion_Groq
    {
        private readonly HttpClient cliente;

        public Conexion_Groq()
        {
            cliente = new HttpClient(); //Crea una instancia para solicitudes HTTP

            cliente.BaseAddress = new Uri(
                "https://api.groq.com/openai/v1/" // Dirección base del servicio API de Groq
            );
        }

        public async Task<string> EnviarPreguntaAsync(string pregunta)
        {
            // Obtener la API Key desde las variables de entorno
            string apiKey = Environment.GetEnvironmentVariable(
                "GROQ_API_KEY"
            );

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new Exception(
                    "No se encontró la variable GROQ_API_KEY."
                );
            }

            // Configurar la autenticación
            cliente.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue(
                    "Bearer",
                    apiKey
                );

            // Preparar la solicitud para Groq
            var solicitud = new
            {
                model = "openai/gpt-oss-20b",
                messages = new[]
                {
                    new
                    {
                        role = "user",
                        content = pregunta
                    }
                }
            };

            string json = JsonSerializer.Serialize(solicitud);

            var contenido = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            // Enviar solicitud a Groq
            HttpResponseMessage respuesta = await cliente.PostAsync(
                "chat/completions",
                contenido
            );

            string resultado = await respuesta.Content.ReadAsStringAsync();

            if (!respuesta.IsSuccessStatusCode)
            {
                throw new Exception(
                    "Error de Groq: " + resultado
                );
            }

            // Obtener el texto de la respuesta
            using JsonDocument documento = JsonDocument.Parse(resultado);

            return documento.RootElement
                .GetProperty("choices")[0]
                .GetProperty("message")
                .GetProperty("content")
                .GetString();
        }
    }
}
