using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BRAM
{
    public partial class Resultados : Form
    {
        List<Alumno> alumnos;
        string dirPath;
        public Resultados(List<Alumno> alumnos, string dirPath)
        {
            InitializeComponent();
            this.alumnos = alumnos;
            this.dirPath = dirPath;

            // Mostramos los alumnos en la listBoxAlumnos
            foreach (var alumno in alumnos)
            {
                listBoxAlumnos.Items.Add(alumno.Nombre);
            }

            listBoxAlumnos.Items.Add("Media");

            // Configurar el DataGridView
            ConfigurarDataGridView();
        }


        /// <summary>
        /// Método que se utiliza para seleccionar el alumno que el usuario ha escrito en el buscador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAlumno_TextChanged(object sender, EventArgs e)
        {
            int indice = listBoxAlumnos.FindString(textBoxAlumno.Text);
            if (indice != -1)
            {
                listBoxAlumnos.SelectedIndex = indice;
            }
        }

        /// <summary>
        /// Método que se utiliza para establecer las columnas en el dataGridViewPartidas donde se mostrará la información de cada alumno.
        /// </summary>
        private void ConfigurarDataGridView()
        {
            // Agregar columnas al DataGridView para mostrar la información de las partidas
            dataGridViewPartidas.Columns.Add("Nº", "Nº");
            dataGridViewPartidas.Columns.Add("Modo", "Modo");
            dataGridViewPartidas.Columns.Add("Fecha", "Fecha");
            dataGridViewPartidas.Columns.Add("Errores", "Errores");
            dataGridViewPartidas.Columns.Add("Tiempo Total", "Tiempo Total");
        }

        /// <summary>
        /// Método que se utiliza para mostrar la información del alumno seleccionado en la listBoxAlumnos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            else if (indice >= 0) // Mostrar la media en caso de que se haya seleccionado 'Media' en la listBoxAlumnos
            {
                dataGridViewPartidas.Rows.Add(1, "MEDIA FÁCIL", DateTime.Now, errores_Totales(alumnos,"easy"), conversor_tiempo(tiempo_Totales(alumnos, "easy")));
                dataGridViewPartidas.Rows.Add(2, "MEDIA DIFÍCIL", DateTime.Now, errores_Totales(alumnos, "hard"), conversor_tiempo(tiempo_Totales(alumnos, "hard")));
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
                Graficos graficos = new Graficos(alumnos[listBoxAlumnos.SelectedIndex].Nombre, alumnos); // Envía el nombre en forma de String a la ventana Graficos
                graficos.ShowDialog();
            }
            else
            {
                Graficos graficos = new Graficos("Media", alumnos); // Envía 'Media' en forma de String a la ventana Graficos
                graficos.ShowDialog();
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
        /// <param name="modo"></param>
        /// <returns>Devuelve un entero con la media de partidas.</returns>
        private int errores_Totales(List<Alumno> alumnos, string modo)
        {
            int mediaErrores = 0;
            int count = 0;

            foreach (var alumno in alumnos)
            {
                foreach (var partida in alumno.Partidas)
                {
                    if (modo.Equals(partida.Modo))
                    {
                        mediaErrores = mediaErrores + partida.Errores;
                        count++;
                    }
                }
            }
            return mediaErrores/count;
        }

        /// <summary>
        /// Devuelve un numero entero de la media de partidas jugadas.
        /// </summary>
        /// <param name="alumnos"></param>
        /// <param name="modo"></param>
        /// <returns>Devuelve un entero con la media de partidas.</returns>
        private int tiempo_Totales(List<Alumno> alumnos, string modo)
        {
            int mediaErrores = 0;
            int count = 0;

            foreach (var alumno in alumnos)
            {
                foreach (var partida in alumno.Partidas)
                {
                    if (modo.Equals(partida.Modo))
                    {
                        mediaErrores = mediaErrores + partida.TiemposAnimales;
                        count++;
                    }
                }
            }
            return mediaErrores / count;
        }

        private void Resultados_FormClosed(object sender, FormClosedEventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
        }

        private void buttonFichDel_Click(object sender, EventArgs e)
        {
            // Verificar si hay un alumno seleccionado en el ListBox
            int indice = listBoxAlumnos.SelectedIndex;
            if (indice >= 0 && indice < alumnos.Count) // Excluye la opción "Media"
            {
                // Confirmar la eliminación
                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este alumno?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Obtener el alumno seleccionado
                    Alumno alumnoSeleccionado = alumnos[indice];

                    // Eliminar al alumno de la lista
                    alumnos.RemoveAt(indice);

                    // Eliminar el alumno del ListBox
                    listBoxAlumnos.Items.RemoveAt(indice);

                    // Actualizar el archivo JSON
                    GuardarDatosJSON();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un alumno válido para eliminar.");
            }
        }

        private void GuardarDatosJSON()
        {
            try
            {
                // Serializar la lista de alumnos a formato JSON
                string jsonData = JsonConvert.SerializeObject(alumnos, Formatting.Indented);

                // Especificar la ruta del archivo JSON (aquí se asume que ya tienes la ruta del archivo original)
                string rutaArchivo = "ruta_a_tu_archivo.json"; // Sustituir con la ruta real del archivo JSON

                // Guardar el JSON actualizado en el archivo
                File.WriteAllText(rutaArchivo, jsonData);

                MessageBox.Show("Alumno eliminado y archivo actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Confirmar la acción
            var result = MessageBox.Show("¿Estás seguro de que deseas eliminar todos los datos?\n" + dirPath, "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Vaciar la lista de alumnos
                    alumnos.Clear();

                    // Actualizar la interfaz de usuario
                    listBoxAlumnos.Items.Clear();
                    dataGridViewPartidas.Rows.Clear();

                    // Guardar una lista vacía en el archivo JSON
                    string jsonData = JsonConvert.SerializeObject(alumnos, Formatting.Indented);
                    File.WriteAllText(dirPath, jsonData);

                    // Informar al usuario
                    MessageBox.Show("Todos los datos han sido eliminados correctamente.");

                    Inicio i = new Inicio();
                    this.Hide();
                    i.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar los datos: {ex.Message}");
                }
            }
        }
    }
}
