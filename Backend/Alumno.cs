using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Alumno
    {
        public string Nombre    { get; set; }
        public string Apellido  { get; set; }
        public string DNI       { get; set; }
        public string Condicion { get; set; }

        public Alumno( string nombre,
                       string apellido,
                       string dni,
                       string condicion ) 
        {
                        Nombre      = nombre;
                        Apellido    = apellido;
                        DNI         = dni;
                        Condicion   = condicion;
        }

    }
}
