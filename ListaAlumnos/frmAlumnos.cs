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

        //BORRAR COMPLETO DGV
        private void btBorrarLista_Click(object sender, EventArgs e)
        {
            Alumnos.BorrarLista();
        }

        //BUSCAR ALUMNO DESDE EL DGV CON DNI
        private void btBuscar_Click(object sender, EventArgs e)
        {
            Alumnos.Buscar(tbParaBuscar.Text);
            {
                if (tbParaBuscar.TextLength >= 1) tbParaBuscar.Text = "";
            }
        }
       
        //BOTON PARA ACTUALIZAR ALUMNO EN DGV
        private void btActualizar_Click(object sender, EventArgs e)
        {
            Alumnos.Actualizar(DGV.CurrentRow.Cells[2].Value.ToString(),tbCondicion.Text);
            {
                if (tbCondicion.TextLength >= 1) tbCondicion.Text = "";
            }
        }
        //BORRAR UN ALUMNO DEL DGV
        private void btBorrar_Click(object sender, EventArgs e)
        {
            Alumnos.BorrarAlumno(DGV.CurrentRow.Cells[2].Value.ToString());
        }
        //MOSTRAR TODOS LOS ALUMNOS DEL DGV
        private void btVerTodos_Click(object sender, EventArgs e)
        {
            Alumnos.CargarTodos();
        }
    }
}
