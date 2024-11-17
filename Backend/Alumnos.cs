using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Alumnos
    {
        //Creacion Tabla con persistencia
        public DataTable Lista { get; set; }
        public Alumnos()
        {
            Lista = new DataTable();
            Lista.TableName = "Alumnos Cargados";
            Lista.Columns.Add("Nombre");
            Lista.Columns.Add("Apellido");
            Lista.Columns.Add("DNI");
            Lista.Columns.Add("Condicion");
            LeerArchivo();
        }
        private void LeerArchivo()
        {
            if (System.IO.File.Exists("Alumnos Cargados.xml"))
            {
                Lista.ReadXml("Alumnos Cargados.xml");
            }
        }
        //Agregar a TABLA metodo INSERT
        public void Insert(Alumno alumno)
        {
            Lista.Rows.Add();
            int NuevoRenglon = Lista.Rows.Count - 1;
            Lista.Rows[NuevoRenglon]["Nombre"] = alumno.Nombre;
            Lista.Rows[NuevoRenglon]["Apellido"] = alumno.Apellido;
            Lista.Rows[NuevoRenglon]["DNI"] = alumno.DNI;
            Lista.Rows[NuevoRenglon]["Condicion"] = alumno.Condicion;

            Lista.WriteXml("Alumnos Cargados.xml");
        }
        
        
        
       

    }
}

