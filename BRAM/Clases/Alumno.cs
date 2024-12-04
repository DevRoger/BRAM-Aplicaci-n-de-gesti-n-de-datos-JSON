using System.Collections.Generic;

namespace BRAM
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public List<Partida> Partidas { get; set; }

        public Alumno()
        {
            Partidas = new List<Partida>();
        }
    }
}
