namespace AppWinBaseDatosAEO
{
    partial class Form1
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnConsultarTodos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(124, 318);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(632, 317);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(128, 47);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Cedula";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(128, 94);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 3;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(128, 141);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 4;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(128, 183);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(128, 231);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono";
            // 
            // tbCedula
            // 
            this.tbCedula.Location = new System.Drawing.Point(273, 47);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(100, 20);
            this.tbCedula.TabIndex = 7;
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(273, 94);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(100, 20);
            this.tbNombres.TabIndex = 8;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(273, 141);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(100, 20);
            this.tbApellidos.TabIndex = 9;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(273, 183);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 20);
            this.tbDireccion.TabIndex = 10;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(273, 223);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 11;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(131, 272);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(206, 317);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.lblConsultar_Click);
            // 
            // btnConsultarTodos
            // 
            this.btnConsultarTodos.Location = new System.Drawing.Point(287, 318);
            this.btnConsultarTodos.Name = "btnConsultarTodos";
            this.btnConsultarTodos.Size = new System.Drawing.Size(110, 23);
            this.btnConsultarTodos.TabIndex = 14;
            this.btnConsultarTodos.Text = "ConsultarTodos";
            this.btnConsultarTodos.UseVisualStyleBackColor = true;
            this.btnConsultarTodos.Click += new System.EventHandler(this.btnConsultarTodos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(403, 317);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Consultar Procedimiento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Consultar ProcedimientoConWS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConsultarTodos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnConsultarTodos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

