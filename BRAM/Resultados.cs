using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BRAM
{
    public partial class Resultados : Form
    {
        List<Alumno> alumnos;
        public Resultados(List<Alumno> alumnos)
        {
            InitializeComponent();
            this.alumnos = alumnos;

            foreach (var alumno in alumnos)
            {
                listBoxAlumnos.Items.Add(alumno.Nombre);

            }

            listBoxAlumnos.Items.Add("Media");



            // Configurar el DataGridView
            ConfigurarDataGridView();
        }


        private void textBoxAlumno_TextChanged(object sender, EventArgs e)
        {
            int indice = listBoxAlumnos.FindString(textBoxAlumno.Text);
            if (indice != -1)
            {
                listBoxAlumnos.SelectedIndex = indice;
            }
        }

        private void ConfigurarDataGridView()
        {
            // Agregar columnas al DataGridView para mostrar la información de las partidas
            dataGridViewPartidas.Columns.Add("Nº", "Nº");
            dataGridViewPartidas.Columns.Add("Modo", "Modo");
            dataGridViewPartidas.Columns.Add("Fecha", "Fecha");
            dataGridViewPartidas.Columns.Add("Errores", "Errores");
            dataGridViewPartidas.Columns.Add("Tiempo Total", "Tiempo Total");
        }

        private void listBoxAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el DataGridView
            dataGridViewPartidas.Rows.Clear();

            // Verificar que se haya seleccionado un alumno válido
            int indice = listBoxAlumnos.SelectedIndex;
            if (indice >= 0 && indice < alumnos.Count) // Excluye la opción "Media"
            {
                Alumno alumnoSeleccionado = alumnos[indice];
                int count = 0;
                // Agregar las partidas del alumno seleccionado al DataGridView
                foreach (var partida in alumnoSeleccionado.Partidas)
                {
                    count = count + 1;
                    dataGridViewPartidas.Rows.Add(count, partida.Modo, partida.Fecha, partida.Errores, conversor_tiempo(partida.TiemposAnimales));
                }
            }
            else if (indice >= 0) // Media
            {
                dataGridViewPartidas.Rows.Add(1, "MEDIA", DateTime.Now, errores_Totales(alumnos), conversor_tiempo(tiempo_Totales(alumnos)));
            }
            
        }

        /// <summary>
        /// Muestra una ventana emergente donde se ven los datos de cada alumno de forma gráfica.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGraficos_Click(object sender, EventArgs e)
        {
            int indice = listBoxAlumnos.SelectedIndex;
            if (indice >=0 && indice < alumnos.Count)
            {
                Graficos graficos = new Graficos(alumnos[listBoxAlumnos.SelectedIndex].Nombre, alumnos, errores_Totales(alumnos), tiempo_Totales(alumnos)); // Envía el nombre en forma de String a la ventana Graficos
                graficos.Show();
            }
            else
            {
                Graficos graficos = new Graficos("Media", alumnos, errores_Totales(alumnos), tiempo_Totales(alumnos));
                graficos.Show();
            }
        }

        /// <summary>
        /// Convierte un numero entero en segundos a formato reloj.
        /// </summary>
        /// <param name="segundos_totales"></param>
        /// <returns>Devuelve un string con formato reloj</returns>
        private string conversor_tiempo(int segundos_totales)
        {
            int segundos = segundos_totales % 60;
            int minutos = segundos_totales / 60;


            return $"{minutos}:{segundos:D2}";
        }


        /// <summary>
        /// Devuelve un numero entero de la media de partidas jugadas.
        /// </summary>
        /// <param name="alumnos"></param>
        /// <returns>Devuelve un entero con la media de partidas.</returns>
        private int errores_Totales(List<Alumno> alumnos)
        {
            int mediaErrores = 0;
            int count = 0;

            foreach (var alumno in alumnos)
            {
                foreach (var partida in alumno.Partidas)
                {
                    mediaErrores = mediaErrores + partida.Errores;
                    count++;
                }
            }
            return mediaErrores/count;
        }

        /// <summary>
        /// Devuelve un numero entero de la media de partidas jugadas.
        /// </summary>
        /// <param name="alumnos"></param>
        /// <returns>Devuelve un entero con la media de partidas.</returns>
        private int tiempo_Totales(List<Alumno> alumnos)
        {
            int mediaErrores = 0;
            int count = 0;

            foreach (var alumno in alumnos)
            {
                foreach (var partida in alumno.Partidas)
                {
                    mediaErrores = mediaErrores + partida.TiemposAnimales;
                    count++;
                }
            }
            return mediaErrores / count;
        }
    }
}
