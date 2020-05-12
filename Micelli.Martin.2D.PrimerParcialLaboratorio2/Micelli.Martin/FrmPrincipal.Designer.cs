namespace Micelli.Martin
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAltaDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAltaNoDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAltaAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAltaAula = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInformacionPadres = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSueldoDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSueldoNoDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecaudacionPorAula = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecaudacionTotalPorJardin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFuncionesVarias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBuscarAlumnoPorApellido = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEscucharMusica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInstanciarObjetos = new System.Windows.Forms.ToolStripMenuItem();
            this.lstboxListaAulas = new System.Windows.Forms.ListBox();
            this.lblListadoAulas = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.tsmiVerVideos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo,
            this.tsmiReporte,
            this.tsmiFuncionesVarias,
            this.tsmiInstanciarObjetos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAltaDocente,
            this.tsmiAltaNoDocente,
            this.tsmiAltaAlumno,
            this.tsmiAltaAula,
            this.tsmiSalir});
            this.tsmiArchivo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(71, 24);
            this.tsmiArchivo.Text = "Archivo";
            // 
            // tsmiAltaDocente
            // 
            this.tsmiAltaDocente.Name = "tsmiAltaDocente";
            this.tsmiAltaDocente.Size = new System.Drawing.Size(184, 24);
            this.tsmiAltaDocente.Text = "Alta docente";
            this.tsmiAltaDocente.Click += new System.EventHandler(this.tsmiAltaDocente_Click);
            // 
            // tsmiAltaNoDocente
            // 
            this.tsmiAltaNoDocente.Name = "tsmiAltaNoDocente";
            this.tsmiAltaNoDocente.Size = new System.Drawing.Size(184, 24);
            this.tsmiAltaNoDocente.Text = "Alta no docente";
            this.tsmiAltaNoDocente.Click += new System.EventHandler(this.tsmiAltaNoDocente_Click);
            // 
            // tsmiAltaAlumno
            // 
            this.tsmiAltaAlumno.Name = "tsmiAltaAlumno";
            this.tsmiAltaAlumno.Size = new System.Drawing.Size(184, 24);
            this.tsmiAltaAlumno.Text = "Alta alumno";
            this.tsmiAltaAlumno.Click += new System.EventHandler(this.tsmiAltaAlumno_Click);
            // 
            // tsmiAltaAula
            // 
            this.tsmiAltaAula.Name = "tsmiAltaAula";
            this.tsmiAltaAula.Size = new System.Drawing.Size(184, 24);
            this.tsmiAltaAula.Text = "Alta aula";
            this.tsmiAltaAula.Click += new System.EventHandler(this.tsmiAltaAula_Click);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(184, 24);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
            // 
            // tsmiReporte
            // 
            this.tsmiReporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInformacionPadres,
            this.tsmiSueldoDocente,
            this.tsmiSueldoNoDocente,
            this.tsmiRecaudacionPorAula,
            this.tsmiRecaudacionTotalPorJardin});
            this.tsmiReporte.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsmiReporte.Name = "tsmiReporte";
            this.tsmiReporte.Size = new System.Drawing.Size(74, 24);
            this.tsmiReporte.Text = "Reporte";
            // 
            // tsmiInformacionPadres
            // 
            this.tsmiInformacionPadres.Name = "tsmiInformacionPadres";
            this.tsmiInformacionPadres.Size = new System.Drawing.Size(267, 24);
            this.tsmiInformacionPadres.Text = "Informacion padres";
            this.tsmiInformacionPadres.Click += new System.EventHandler(this.tsmiInformacionPadres_Click);
            // 
            // tsmiSueldoDocente
            // 
            this.tsmiSueldoDocente.Name = "tsmiSueldoDocente";
            this.tsmiSueldoDocente.Size = new System.Drawing.Size(267, 24);
            this.tsmiSueldoDocente.Text = "Sueldo docente";
            this.tsmiSueldoDocente.Click += new System.EventHandler(this.tsmiSueldoDocente_Click);
            // 
            // tsmiSueldoNoDocente
            // 
            this.tsmiSueldoNoDocente.Name = "tsmiSueldoNoDocente";
            this.tsmiSueldoNoDocente.Size = new System.Drawing.Size(267, 24);
            this.tsmiSueldoNoDocente.Text = "Sueldo no docente";
            this.tsmiSueldoNoDocente.Click += new System.EventHandler(this.tsmiSueldoNoDocente_Click);
            // 
            // tsmiRecaudacionPorAula
            // 
            this.tsmiRecaudacionPorAula.Name = "tsmiRecaudacionPorAula";
            this.tsmiRecaudacionPorAula.Size = new System.Drawing.Size(267, 24);
            this.tsmiRecaudacionPorAula.Text = "Recaudacion por aula";
            this.tsmiRecaudacionPorAula.Click += new System.EventHandler(this.tsmiRecaudacionPorAula_Click);
            // 
            // tsmiRecaudacionTotalPorJardin
            // 
            this.tsmiRecaudacionTotalPorJardin.Name = "tsmiRecaudacionTotalPorJardin";
            this.tsmiRecaudacionTotalPorJardin.Size = new System.Drawing.Size(267, 24);
            this.tsmiRecaudacionTotalPorJardin.Text = "Recaudacion total por jardin";
            this.tsmiRecaudacionTotalPorJardin.Click += new System.EventHandler(this.tsmiRecaudacionTotalPorJardin_Click);
            // 
            // tsmiFuncionesVarias
            // 
            this.tsmiFuncionesVarias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBuscarAlumnoPorApellido,
            this.tsmiEscucharMusica,
            this.tsmiVerVideos});
            this.tsmiFuncionesVarias.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsmiFuncionesVarias.Name = "tsmiFuncionesVarias";
            this.tsmiFuncionesVarias.Size = new System.Drawing.Size(128, 24);
            this.tsmiFuncionesVarias.Text = "Funciones varias";
            // 
            // tsmiBuscarAlumnoPorApellido
            // 
            this.tsmiBuscarAlumnoPorApellido.Name = "tsmiBuscarAlumnoPorApellido";
            this.tsmiBuscarAlumnoPorApellido.Size = new System.Drawing.Size(261, 24);
            this.tsmiBuscarAlumnoPorApellido.Text = "Buscar alumno por apellido";
            this.tsmiBuscarAlumnoPorApellido.Click += new System.EventHandler(this.tsmiBuscarAlumnoPorApellido_Click);
            // 
            // tsmiEscucharMusica
            // 
            this.tsmiEscucharMusica.Name = "tsmiEscucharMusica";
            this.tsmiEscucharMusica.Size = new System.Drawing.Size(261, 24);
            this.tsmiEscucharMusica.Text = "Escuchar musica";
            this.tsmiEscucharMusica.Click += new System.EventHandler(this.tsmiEscucharMusica_Click);
            // 
            // tsmiInstanciarObjetos
            // 
            this.tsmiInstanciarObjetos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsmiInstanciarObjetos.Name = "tsmiInstanciarObjetos";
            this.tsmiInstanciarObjetos.Size = new System.Drawing.Size(138, 24);
            this.tsmiInstanciarObjetos.Text = "Instanciar objetos";
            this.tsmiInstanciarObjetos.Click += new System.EventHandler(this.tsmiInstanciarObjetos_Click);
            // 
            // lstboxListaAulas
            // 
            this.lstboxListaAulas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstboxListaAulas.BackColor = System.Drawing.SystemColors.Window;
            this.lstboxListaAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxListaAulas.FormattingEnabled = true;
            this.lstboxListaAulas.ItemHeight = 18;
            this.lstboxListaAulas.Location = new System.Drawing.Point(12, 75);
            this.lstboxListaAulas.Name = "lstboxListaAulas";
            this.lstboxListaAulas.Size = new System.Drawing.Size(495, 400);
            this.lstboxListaAulas.TabIndex = 2;
            this.lstboxListaAulas.DoubleClick += new System.EventHandler(this.lstboxListaAulas_DoubleClick);
            // 
            // lblListadoAulas
            // 
            this.lblListadoAulas.AutoSize = true;
            this.lblListadoAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoAulas.Location = new System.Drawing.Point(9, 51);
            this.lblListadoAulas.Name = "lblListadoAulas";
            this.lblListadoAulas.Size = new System.Drawing.Size(131, 18);
            this.lblListadoAulas.TabIndex = 3;
            this.lblListadoAulas.Text = "Listado de aulas";
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(223, 51);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(284, 18);
            this.lblInformacion.TabIndex = 4;
            this.lblInformacion.Text = "(Doble click para ver informacion del aula)";
            // 
            // tsmiVerVideos
            // 
            this.tsmiVerVideos.Name = "tsmiVerVideos";
            this.tsmiVerVideos.Size = new System.Drawing.Size(261, 24);
            this.tsmiVerVideos.Text = "Ver videos";
            this.tsmiVerVideos.Click += new System.EventHandler(this.tsmiVerVideos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(924, 494);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lblListadoAulas);
            this.Controls.Add(this.lstboxListaAulas);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jardin de infantes \"Los pichoncitos\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaDocente;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaNoDocente;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaAlumno;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaAula;
        private System.Windows.Forms.ListBox lstboxListaAulas;
        private System.Windows.Forms.Label lblListadoAulas;
        private System.Windows.Forms.ToolStripMenuItem tsmiInstanciarObjetos;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.ToolStripMenuItem tsmiReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiInformacionPadres;
        private System.Windows.Forms.ToolStripMenuItem tsmiSueldoNoDocente;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecaudacionPorAula;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecaudacionTotalPorJardin;
        private System.Windows.Forms.ToolStripMenuItem tsmiSueldoDocente;
        private System.Windows.Forms.ToolStripMenuItem tsmiFuncionesVarias;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuscarAlumnoPorApellido;
        private System.Windows.Forms.ToolStripMenuItem tsmiEscucharMusica;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerVideos;
    }
}

