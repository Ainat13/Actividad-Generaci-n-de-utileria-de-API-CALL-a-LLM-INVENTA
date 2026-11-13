
using System.Drawing;
using System.Windows.Forms;

namespace Generacion_de_utileria
{
    internal static class Estilo_tablas
    {
        public static void Aplicar(DataGridView tabla)
        {
            // Configuración general
            tabla.BackgroundColor = Color.White;
            tabla.BorderStyle = BorderStyle.None;
            tabla.GridColor = Color.FromArgb(225, 235, 237);

            tabla.EnableHeadersVisualStyles = false;

            // Encabezados
            tabla.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 155, 150);

            tabla.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            tabla.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            tabla.ColumnHeadersHeight = 40;

            // Filas
            tabla.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            tabla.DefaultCellStyle.ForeColor =
                Color.FromArgb(38, 59, 67);

            tabla.DefaultCellStyle.BackColor =
                Color.White;

            tabla.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(221, 244, 243);

            tabla.RowTemplate.Height = 35;

            // Selección
            tabla.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(8, 169, 194);

            tabla.DefaultCellStyle.SelectionForeColor =
                Color.White;

            // Presentación
            tabla.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            tabla.RowHeadersVisible = false;
            tabla.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            tabla.MultiSelect = false;
            tabla.ReadOnly = true;
            tabla.AllowUserToAddRows = false;
        }
    }
}
