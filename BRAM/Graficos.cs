using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BRAM
{
    public partial class Graficos : Form
    {
        Alumno alumnoEscogido { get; set; }
        public Graficos(string nombre, List<Alumno> alumnos)
        {
            InitializeComponent();

            // Obtenemos el nombre del alumno seleccionado
            labelNombre.Text = nombre;


            // Mostramos los datos si la opción escogida es la media de los alumnos
            if (nombre.Equals("Media"))
            {
                mostrar_grafico_media_facil(alumnos);

                mostrar_grafico_media_dificil(alumnos);

            }
            else // En caso de no haber escogido la media, mostramos los datos del alumno
            {
                // Asignamos el alumno
                foreach (var alumno in alumnos)
                {
                    if (alumno.Nombre == nombre)
                    {
                        alumnoEscogido = alumno;
                    }
                }

                // Métodos para mostrar los 4 gráficos
                mostrar_grafico_errores_facil(alumnos);
                mostrar_grafico_tiempo_facil(alumnos);
                mostrar_grafico_errores_dificil(alumnos);
                mostrar_grafico_tiempo_dificil(alumnos);
            }
        }

        /// <summary>
        /// Muestra dos gráficos con la información del modo de juego DIFÍCIL en caso de que el usuario haya seleccionado 'MEDIA' en la listBox de la ventana anterior.
        /// </summary>
        /// <param name="alumnos"></param>
        private void mostrar_grafico_media_dificil(List<Alumno> alumnos)
        {
            // Gráficos modo difícil
            Series serieColumnasMediaDificilErrores = new Series("Errores");
            serieColumnasMediaDificilErrores.ChartType = SeriesChartType.Column;

            serieColumnasMediaDificilErrores.Color = Color.LightSlateGray;

            serieColumnasMediaDificilErrores.Points.AddXY(1, errores_Totales(alumnos, "hard"));

            chartErroresDificil.Series.Add(serieColumnasMediaDificilErrores);

            Series serieColumnasMediaDificilTiempo = new Series("Tiempo");
            serieColumnasMediaDificilTiempo.ChartType = SeriesChartType.Column;

            serieColumnasMediaDificilTiempo.Color = Color.LightSlateGray;

            serieColumnasMediaDificilTiempo.Points.AddXY(1, tiempo_Totales(alumnos, "hard"));

            chartTiempoDificil.Series.Add(serieColumnasMediaDificilTiempo);
        }

        /// <summary>
        /// Muestra dos gráficos con la información del modo de juego FÁCIL en caso de que el usuario haya seleccionado 'MEDIA' en la listBox de la ventana anterior.
        /// </summary>
        /// <param name="alumnos"></param>
        private void mostrar_grafico_media_facil(List<Alumno> alumnos)
        {
            // Gráficos modo fácil
            Series serieColumnasMediaFacilErrores = new Series("Errores");
            serieColumnasMediaFacilErrores.ChartType = SeriesChartType.Column;

            serieColumnasMediaFacilErrores.Color = Color.LightSlateGray;

            serieColumnasMediaFacilErrores.Points.AddXY(1, errores_Totales(alumnos, "easy"));

            chartErroresFacil.Series.Add(serieColumnasMediaFacilErrores);

            Series serieColumnasMediaFacilTiempo = new Series("Tiempo");
            serieColumnasMediaFacilTiempo.ChartType = SeriesChartType.Column;

            serieColumnasMediaFacilTiempo.Color = Color.LightSlateGray;

            serieColumnasMediaFacilTiempo.Points.AddXY(1, tiempo_Totales(alumnos, "easy"));

            chartTiempoFacil.Series.Add(serieColumnasMediaFacilTiempo);
        }

        /// <summary>
        /// Muestra el gráfico de tiempo en el modo difícil del usuario seleccionado en la ventana anterior.
        /// </summary>
        /// <param name="alumnos"></param>
        private void mostrar_grafico_tiempo_dificil(List<Alumno> alumnos)
        {
            // Gráfica Tiempo Dificil
            // Crear las series
            Series serieColumnasTiempoDificil = new Series("Tiempo");
            serieColumnasTiempoDificil.ChartType = SeriesChartType.Column;

            Series serieLineaMediaTiempoDificil = new Series("Media");
            serieLineaMediaTiempoDificil.ChartType = SeriesChartType.Line;

            serieLineaMediaTiempoDificil.BorderWidth = 5;
            serieLineaMediaTiempoDificil.Color = Color.Red;
            serieColumnasTiempoDificil.Color = Color.LightSlateGray;


            int count = 0;
            foreach (var partida in alumnoEscogido.Partidas)
            {
                if (partida.Modo.Equals("hard"))
                {
                    count++;
                    serieLineaMediaTiempoDificil.Points.AddXY(count, tiempo_Totales(alumnos, "hard"));
                    serieColumnasTiempoDificil.Points.AddXY(count, partida.TiemposAnimales);
                }
            }

            // Agregar las series al chart
            chartTiempoDificil.Series.Add(serieColumnasTiempoDificil);
            chartTiempoDificil.Series.Add(serieLineaMediaTiempoDificil);
        }

        /// <summary>
        /// Muestra el gráfico de errores en el modo difícil del usuario seleccionado en la ventana anterior.
        /// </summary>
        /// <param name="alumnos"></param>
        private void mostrar_grafico_errores_dificil(List<Alumno> alumnos)
        {
            // Gráfica Errores Dificil
            // Crear las series
            Series serieColumnasErroresDificil = new Series("Errores");
            serieColumnasErroresDificil.ChartType = SeriesChartType.Column;

            Series serieLineaMediaErroresDificil = new Series("Media");
            serieLineaMediaErroresDificil.ChartType = SeriesChartType.Line;

            serieLineaMediaErroresDificil.BorderWidth = 5;
            serieLineaMediaErroresDificil.Color = Color.Red;
            serieColumnasErroresDificil.Color = Color.LightSlateGray;

            int count = 0;
            foreach (var partida in alumnoEscogido.Partidas)
            {
                if (partida.Modo.Equals("hard"))
                {
                    count++;
                    serieLineaMediaErroresDificil.Points.AddXY(count, errores_Totales(alumnos, "hard"));
                    serieColumnasErroresDificil.Points.AddXY(count, partida.Errores);
                }
            }

            // Agregar las series al chart
            chartErroresDificil.Series.Add(serieColumnasErroresDificil);
            chartErroresDificil.Series.Add(serieLineaMediaErroresDificil);
        }

        /// <summary>
        /// Muestra el gráfico de tiempo en el modo fácil del usuario seleccionado en la ventana anterior.
        /// </summary>
        /// <param name="alumnos"></param>
        private void mostrar_grafico_tiempo_facil(List<Alumno> alumnos)
        {
            // Gráfica Tiempo Fácil
            // Crear las series
            Series serieColumnasTiempoFacil = new Series("Tiempo");
            serieColumnasTiempoFacil.ChartType = SeriesChartType.Column;

            Series serieLineaMediaTiempoFacil = new Series("Media");
            serieLineaMediaTiempoFacil.ChartType = SeriesChartType.Line;

            serieLineaMediaTiempoFacil.BorderWidth = 5;
            serieLineaMediaTiempoFacil.Color = Color.Red;
            serieColumnasTiempoFacil.Color = Color.LightSlateGray;


            int count = 0;
            foreach (var partida in alumnoEscogido.Partidas)
            {
                if (partida.Modo.Equals("easy"))
                {
                    count++;
                    serieLineaMediaTiempoFacil.Points.AddXY(count, tiempo_Totales(alumnos, "easy"));
                    serieColumnasTiempoFacil.Points.AddXY(count, partida.TiemposAnimales);
                }
            }

            // Agregar las series al chart
            chartTiempoFacil.Series.Add(serieColumnasTiempoFacil);
            chartTiempoFacil.Series.Add(serieLineaMediaTiempoFacil);
        }

        /// <summary>
        /// Muestra el gráfico de errores en el modo fácil del usuario seleccionado en la ventana anterior.
        /// </summary>
        /// <param name="alumnos"></param>
        private void mostrar_grafico_errores_facil(List<Alumno> alumnos)
        {
            // Gráfica Errores Fácil
            // Crear las series
            Series serieColumnasErroresFacil = new Series("Errores");
            serieColumnasErroresFacil.ChartType = SeriesChartType.Column;

            Series serieLineaMediaErroresFacil = new Series("Media");
            serieLineaMediaErroresFacil.ChartType = SeriesChartType.Line;

            serieLineaMediaErroresFacil.BorderWidth = 5;
            serieLineaMediaErroresFacil.Color = Color.Red;
            serieColumnasErroresFacil.Color = Color.LightSlateGray;

            int count = 0;
            foreach (var partida in alumnoEscogido.Partidas)
            {
                if (partida.Modo.Equals("easy"))
                {
                    count++;
                    serieLineaMediaErroresFacil.Points.AddXY(count, errores_Totales(alumnos, "easy"));
                    serieColumnasErroresFacil.Points.AddXY(count, partida.Errores);
                }
            }

            // Agregar las series al chart
            chartErroresFacil.Series.Add(serieColumnasErroresFacil);
            chartErroresFacil.Series.Add(serieLineaMediaErroresFacil);
        }

        /// <summary>
        /// Botón que se utiliza para cerrar esta ventana y volver a la selección de alumno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            return mediaErrores / count;
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
    }
}
