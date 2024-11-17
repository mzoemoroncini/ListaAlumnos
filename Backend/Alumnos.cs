using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            CargarTodos();
            Lista.Rows.Add();
            int NuevoRenglon = Lista.Rows.Count - 1;
            Lista.Rows[NuevoRenglon]["Nombre"] = alumno.Nombre;
            Lista.Rows[NuevoRenglon]["Apellido"] = alumno.Apellido;
            Lista.Rows[NuevoRenglon]["DNI"] = alumno.DNI;
            Lista.Rows[NuevoRenglon]["Condicion"] = alumno.Condicion;

            Lista.WriteXml("Alumnos Cargados.xml");
        }
        //BUSCAR CON DNI metodo BUSCAR
        public void Buscar(string DNI)
        {

            Lista.DefaultView.RowFilter = $"DNI = '{DNI}'";

        }
        //MOSTRAR TODOS metodo MOSTRAR TODOS
        public void CargarTodos()
        {
            Lista.DefaultView.RowFilter = "";
        }

        //BORRAR DGV metodo BORRAR LISTA
        public void BorrarLista()
        {
            Lista.DefaultView.RowFilter = "";
            Lista.Clear();
            Lista.WriteXml("Alumnos Cargados.xml");

        }

        //BORRAR ALUMNO DE LA LISTA metodo BORRAR ALUMNO
        public void BorrarAlumno(string DNI)
        {
            CargarTodos();
            DataRow[] datos = Lista.Select($"DNI = '{DNI}'");
            foreach (DataRow fila in datos)
            {
                Lista.Rows.Remove(fila);
            }
            Lista.WriteXml("Alumnos Cargados.xml");

        }

        //ACTUALIZAR UN ALUMNO metodo ACTUALIZAR
        public void Actualizar (string DNI, string Condicion )
        {
            CargarTodos();
            DataRow[] datos = Lista.Select($"DNI = '{DNI}'");
            foreach (DataRow fila in datos)
            {
                fila["Condicion"] = Condicion;
            }
            Lista.WriteXml("Alumnos Cargados.xml");
        }
    }
}

