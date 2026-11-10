# Actividad Generación de utilería de API CALL a LLM: INVENTA

## 1. Descripción 📝
INVENTA es una aplicación de escritorio desarrollada en C# mediante Windows Forms, que permite administrar y consultar información de productos, personal e inventario.
El sistema integra una base de datos MySQL alojada en Amazon RDS y la API de Gemini para incorporar capacidades de inteligencia artificial mediante llamadas a un modelo de lenguaje (LLM).
Se realizó como parte de una actividad de la materia de Ciber infraestructura, en la que se buscaba generar una API de "llamada", se decidió utilizar una base de datos anteriormente creada de igual forma para la materia. 

## 2. Objetivo 🎯
Desarrollar una utilería que permita realizar solicitudes a un modelo de lenguaje mediante una API, proporcionando información contextual de una base de datos para generar respuestas relacionadas con la gestión de inventarios.

## 3. Tecnologías utilizadas 🛠️
* C#
* .NET 8
* Windows Forms
* Visual Studio
* Amazon Web Services (AWS RDS)
* MySQL
* Gemini API

## 4. Funcionalidades 🖥️
* Consulta de productos registrados.
* Consulta del personal y sus cargos.
* Visualización de registros de inventario.
* Consulta de existencias por producto.
* Conteo de productos y empleados.
* Interacción con Gemini mediante preguntas en lenguaje natural.
* Generación de respuestas utilizando información recuperada de la base de datos.

## 5. Funcionamiento de la API CALL a un LLM🕹️
La comunicación entre la aplicación y el modelo de lenguaje sigue el siguiente flujo:
👤 El usuario escribe una pregunta desde la interfaz de InventoryAI.
🗄️ La aplicación consulta la información correspondiente en la base de datos MySQL alojada en AWS.
📝 Los resultados obtenidos se organizan en un contexto.
🔌 La pregunta del usuario y el contexto se envían a Gemini mediante una llamada a la API.
🤖 Gemini procesa la solicitud y genera una respuesta.
💬 La aplicación recibe la respuesta y la muestra en la ventana del chat.

## Evidencias 🗂️
El repositorio contiene el código fuente de la aplicación, los scripts de la base de datos, la documentación y las evidencias de funcionamiento.

## Seguridad 🔒
