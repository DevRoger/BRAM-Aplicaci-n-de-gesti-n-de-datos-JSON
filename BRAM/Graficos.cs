using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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





                // Gráfica Tiempo Fácil
                // Crear las series
                Series serieColumnasTiempoFacil = new Series("Tiempo");
                serieColumnasTiempoFacil.ChartType = SeriesChartType.Column;

                Series serieLineaMediaTiempoFacil = new Series("Media");
                serieLineaMediaTiempoFacil.ChartType = SeriesChartType.Line;

                serieLineaMediaTiempoFacil.BorderWidth = 5;
                serieLineaMediaTiempoFacil.Color = Color.Red;
                serieColumnasTiempoFacil.Color = Color.LightSlateGray;


                int count2 = 0;
                foreach (var partida in alumnoEscogido.Partidas)
                {
                    if (partida.Modo.Equals("easy"))
                    {
                        count++;
                        serieLineaMediaTiempoFacil.Points.AddXY(count2, tiempo_Totales(alumnos, "easy"));
                        serieColumnasTiempoFacil.Points.AddXY(count2, partida.TiemposAnimales);
                    }
                }

                // Agregar las series al chart
                chartTiempoFacil.Series.Add(serieColumnasTiempoFacil);
                chartTiempoFacil.Series.Add(serieLineaMediaTiempoFacil);




                // Gráfica Errores Dificil
                // Crear las series
                Series serieColumnasErroresDificil = new Series("Errores");
                serieColumnasErroresDificil.ChartType = SeriesChartType.Column;

                Series serieLineaMediaErroresDificil = new Series("Media");
                serieLineaMediaErroresDificil.ChartType = SeriesChartType.Line;

                serieLineaMediaErroresDificil.BorderWidth = 5;
                serieLineaMediaErroresDificil.Color = Color.Red;
                serieColumnasErroresDificil.Color = Color.LightSlateGray;

                int count3 = 0;
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




                // Gráfica Tiempo Dificil
                // Crear las series
                Series serieColumnasTiempoDificil = new Series("Tiempo");
                serieColumnasTiempoDificil.ChartType = SeriesChartType.Column;

                Series serieLineaMediaTiempoDificil = new Series("Media");
                serieLineaMediaTiempoDificil.ChartType = SeriesChartType.Line;

                serieLineaMediaTiempoDificil.BorderWidth = 5;
                serieLineaMediaTiempoDificil.Color = Color.Red;
                serieColumnasTiempoDificil.Color = Color.LightSlateGray;


                int count4 = 0;
                foreach (var partida in alumnoEscogido.Partidas)
                {
                    if (partida.Modo.Equals("hard"))
                    {
                        count++;
                        serieLineaMediaTiempoDificil.Points.AddXY(count2, tiempo_Totales(alumnos, "hard"));
                        serieColumnasTiempoDificil.Points.AddXY(count2, partida.TiemposAnimales);
                    }
                }

                // Agregar las series al chart
                chartTiempoDificil.Series.Add(serieColumnasTiempoDificil);
                chartTiempoDificil.Series.Add(serieLineaMediaTiempoDificil);
            }
        }

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
