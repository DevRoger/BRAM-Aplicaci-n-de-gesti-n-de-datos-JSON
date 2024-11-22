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
        public Graficos(string nombre, List<Alumno> alumnos, int mediaErrores, int mediaTiempo)
        {
            InitializeComponent();

            labelNombre.Text = nombre;

            if (nombre.Equals("Media"))
            {
                Series serieColumnas = new Series("Errores");
                serieColumnas.ChartType = SeriesChartType.Column;

                serieColumnas.Color = Color.LightSlateGray;

                serieColumnas.Points.AddXY(1, mediaErrores);

                chart1.Series.Add(serieColumnas);

                Series serieColumnas2 = new Series("Tiempo");
                serieColumnas2.ChartType = SeriesChartType.Column;

                serieColumnas2.Color = Color.LightSlateGray;

                serieColumnas2.Points.AddXY(1, mediaTiempo);

                chart2.Series.Add(serieColumnas2);

            }
            else
            {

                // Asignamos el alumno
                foreach (var alumno in alumnos)
                {
                    if (alumno.Nombre == nombre)
                    {
                        alumnoEscogido = alumno;
                    }
                }


                // Gráfica Errores
                // Crear las series
                Series serieColumnas = new Series("Errores");
                serieColumnas.ChartType = SeriesChartType.Column;

                Series serieLinea = new Series("Media");
                serieLinea.ChartType = SeriesChartType.Line;

                serieLinea.BorderWidth = 5;
                serieLinea.Color = Color.Red;
                serieColumnas.Color = Color.LightSlateGray;

                int count = 0;
                foreach (var partida in alumnoEscogido.Partidas)
                {
                    count++;
                    serieLinea.Points.AddXY(count, mediaErrores);
                    serieColumnas.Points.AddXY(count, partida.Errores);
                }

                // Agregar las series al chart
                chart1.Series.Add(serieColumnas);
                chart1.Series.Add(serieLinea);


                // Gráfica Tiempo
                // Crear las series
                Series serieColumnas2 = new Series("Tiempo");
                serieColumnas2.ChartType = SeriesChartType.Column;

                Series serieLinea2 = new Series("Media");
                serieLinea2.ChartType = SeriesChartType.Line;

                serieLinea2.BorderWidth = 5;
                serieLinea2.Color = Color.Red;
                serieColumnas2.Color = Color.LightSlateGray;


                int count2 = 0;
                foreach (var partida in alumnoEscogido.Partidas)
                {
                    count++;
                    serieLinea2.Points.AddXY(count2, mediaTiempo);
                    serieColumnas2.Points.AddXY(count2, partida.TiemposAnimales);
                }

                // Agregar las series al chart
                chart2.Series.Add(serieColumnas2);
                chart2.Series.Add(serieLinea2);
            }
        }

        private void buttonGraficos_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
