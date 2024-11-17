namespace ListaAlumnos
{
    partial class frmAlumnos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btAgregar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbCondicion = new System.Windows.Forms.TextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btBorrarLista = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbParaBuscar = new System.Windows.Forms.TextBox();
            this.lRojo = new System.Windows.Forms.Label();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btVerTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(366, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(499, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "CONDICION";
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.Yellow;
            this.btAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregar.FlatAppearance.BorderSize = 0;
            this.btAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btAgregar.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.ForeColor = System.Drawing.Color.Black;
            this.btAgregar.Location = new System.Drawing.Point(478, 139);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(143, 35);
            this.btAgregar.TabIndex = 4;
            this.btAgregar.Text = "AGREGAR";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.White;
            this.tbNombre.Location = new System.Drawing.Point(28, 88);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(104, 26);
            this.tbNombre.TabIndex = 5;
            // 
            // tbApellido
            // 
            this.tbApellido.BackColor = System.Drawing.Color.White;
            this.tbApellido.Location = new System.Drawing.Point(182, 88);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(104, 26);
            this.tbApellido.TabIndex = 6;
            // 
            // tbDNI
            // 
            this.tbDNI.BackColor = System.Drawing.Color.White;
            this.tbDNI.Location = new System.Drawing.Point(338, 88);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(104, 26);
            this.tbDNI.TabIndex = 7;
            // 
            // tbCondicion
            // 
            this.tbCondicion.BackColor = System.Drawing.Color.White;
            this.tbCondicion.Location = new System.Drawing.Point(497, 88);
            this.tbCondicion.Name = "tbCondicion";
            this.tbCondicion.Size = new System.Drawing.Size(104, 26);
            this.tbCondicion.TabIndex = 8;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 129);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(460, 272);
            this.DGV.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(25, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(588, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(25, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(588, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------";
            // 
            // btBorrarLista
            // 
            this.btBorrarLista.BackColor = System.Drawing.Color.Red;
            this.btBorrarLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBorrarLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btBorrarLista.FlatAppearance.BorderSize = 0;
            this.btBorrarLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btBorrarLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btBorrarLista.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrarLista.ForeColor = System.Drawing.Color.Black;
            this.btBorrarLista.Location = new System.Drawing.Point(0, 428);
            this.btBorrarLista.Name = "btBorrarLista";
            this.btBorrarLista.Size = new System.Drawing.Size(640, 35);
            this.btBorrarLista.TabIndex = 13;
            this.btBorrarLista.Text = "BORRAR LISTA";
            this.btBorrarLista.UseVisualStyleBackColor = false;
            this.btBorrarLista.Click += new System.EventHandler(this.btBorrarLista_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.Goldenrod;
            this.btBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btBuscar.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.Black;
            this.btBuscar.Location = new System.Drawing.Point(478, 303);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(143, 54);
            this.btBuscar.TabIndex = 16;
            this.btBuscar.Text = "BUSCAR\r\nPOR DNI";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tbParaBuscar
            // 
            this.tbParaBuscar.BackColor = System.Drawing.Color.White;
            this.tbParaBuscar.Location = new System.Drawing.Point(478, 363);
            this.tbParaBuscar.Name = "tbParaBuscar";
            this.tbParaBuscar.Size = new System.Drawing.Size(143, 26);
            this.tbParaBuscar.TabIndex = 17;
            // 
            // lRojo
            // 
            this.lRojo.AutoSize = true;
            this.lRojo.BackColor = System.Drawing.Color.Transparent;
            this.lRojo.ForeColor = System.Drawing.Color.Red;
            this.lRojo.Location = new System.Drawing.Point(-3, 412);
            this.lRojo.Name = "lRojo";
            this.lRojo.Size = new System.Drawing.Size(678, 18);
            this.lRojo.TabIndex = 18;
            this.lRojo.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------";
            // 
            // btActualizar
            // 
            this.btActualizar.BackColor = System.Drawing.Color.Yellow;
            this.btActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btActualizar.FlatAppearance.BorderSize = 0;
            this.btActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btActualizar.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizar.ForeColor = System.Drawing.Color.Black;
            this.btActualizar.Location = new System.Drawing.Point(478, 180);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(143, 35);
            this.btActualizar.TabIndex = 19;
            this.btActualizar.Text = "ACTUALIZAR";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.Color.Yellow;
            this.btBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBorrar.FlatAppearance.BorderSize = 0;
            this.btBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btBorrar.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.ForeColor = System.Drawing.Color.Black;
            this.btBorrar.Location = new System.Drawing.Point(478, 221);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(143, 35);
            this.btBorrar.TabIndex = 20;
            this.btBorrar.Text = "BORRAR";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btVerTodos
            // 
            this.btVerTodos.BackColor = System.Drawing.Color.Yellow;
            this.btVerTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVerTodos.FlatAppearance.BorderSize = 0;
            this.btVerTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btVerTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btVerTodos.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerTodos.ForeColor = System.Drawing.Color.Black;
            this.btVerTodos.Location = new System.Drawing.Point(478, 262);
            this.btVerTodos.Name = "btVerTodos";
            this.btVerTodos.Size = new System.Drawing.Size(143, 35);
            this.btVerTodos.TabIndex = 21;
            this.btVerTodos.Text = "VER TODOS";
            this.btVerTodos.UseVisualStyleBackColor = false;
            this.btVerTodos.Click += new System.EventHandler(this.btVerTodos_Click);
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(640, 463);
            this.Controls.Add(this.btVerTodos);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.lRojo);
            this.Controls.Add(this.tbParaBuscar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btBorrarLista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.tbCondicion);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTADO DE ALUMNOS";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbCondicion;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btBorrarLista;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbParaBuscar;
        private System.Windows.Forms.Label lRojo;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btVerTodos;
    }
}

