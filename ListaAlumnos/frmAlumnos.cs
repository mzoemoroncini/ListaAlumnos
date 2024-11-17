using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ListaAlumnos
{
    
    public partial class frmAlumnos : Form
    {
        private Alumnos Alumnos = new Alumnos();
        public frmAlumnos()
        {
            InitializeComponent();
            DGV.DataSource = Alumnos.Lista;

        }
        //Boton agregar a DGV
        private void btAgregar_Click(object sender, EventArgs e)
        {
            Alumno Alumno = new Alumno(
                                            tbNombre.Text,
                                            tbApellido.Text,
                                            tbDNI.Text,
                                            tbCondicion.Text
                                        );
            Alumnos.Insert(Alumno);
            
                                {
                                    if (tbNombre.TextLength >= 1) tbNombre.Text = "";
                                }
                                {
                                    if (tbApellido.TextLength >= 1) tbApellido.Text = "";
                                }
                                {
                                    if (tbDNI.TextLength >= 1) tbDNI.Text = "";
                                }
                                {
                                    if (tbCondicion.TextLength >= 1) tbCondicion.Text = "";
                                }
        }

        //BORRAR DGV
        private void btBorrarLista_Click(object sender, EventArgs e)
        {
           
            //DGV.Rows.Clear();
        }

        //BUSCAR DEL DGV CON DNI
        private void btBuscar_Click(object sender, EventArgs e)
        {
            Alumno Alumno = Buscar(tbDNI.Text);
            
        }
        //Metodo? buscar
        public  Alumno Buscar(string text)
        {
           // throw new NotImplementedException();
            Alumno alumnob = Buscar(tbDNI.Text);

            if (alumnob.DNI != tbDNI.Text)
            {
                tbNombre.Text = alumnob.Nombre;
                tbApellido.Text = alumnob.Apellido;
                tbDNI.Text = alumnob.DNI;
                tbCondicion.Text = alumnob.Condicion;

                tbNombre.Focus();
            }
            else
            {
                tbDNI.Text = "no existe";
                tbDNI.SelectAll();
                tbDNI.Focus();
            }
        }
        //BOTON PARA ACTUALIZAR EN DGV
        private void btActualizar_Click(object sender, EventArgs e)
        {

        }
        //BORRAR UN ALUMNO DEL DGV
        private void btBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
