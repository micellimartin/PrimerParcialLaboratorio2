namespace Micelli.Martin
{
    partial class FrmAltaAula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lstboxAlumnosEnSala = new System.Windows.Forms.ListBox();
            this.lstboxAlumnosSinSala = new System.Windows.Forms.ListBox();
            this.lblAlumnosEnSala = new System.Windows.Forms.Label();
            this.lblAlumnosSinSalaAsignada = new System.Windows.Forms.Label();
            this.btnGuardarAula = new System.Windows.Forms.Button();
            this.btnInstrucciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(12, 20);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 18);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color";
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Naranja ",
            "Rojo ",
            "Amarillo ",
            "Verde"});
            this.cmbColor.Location = new System.Drawing.Point(95, 17);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(189, 26);
            this.cmbColor.TabIndex = 8;
            this.cmbColor.SelectedValueChanged += new System.EventHandler(this.cmbColor_SelectedValueChanged);
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.cmbTurno.Location = new System.Drawing.Point(379, 17);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(130, 26);
            this.cmbTurno.TabIndex = 9;
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.cmbTurno_SelectedIndexChanged);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(310, 20);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(47, 18);
            this.lblTurno.TabIndex = 10;
            this.lblTurno.Text = "Turno";
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesor.Enabled = false;
            this.cmbProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(95, 73);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(826, 26);
            this.cmbProfesor.TabIndex = 11;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.Location = new System.Drawing.Point(12, 73);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(66, 18);
            this.lblProfesor.TabIndex = 12;
            this.lblProfesor.Text = "Profesor";
            // 
            // lstboxAlumnosEnSala
            // 
            this.lstboxAlumnosEnSala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstboxAlumnosEnSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxAlumnosEnSala.FormattingEnabled = true;
            this.lstboxAlumnosEnSala.ItemHeight = 18;
            this.lstboxAlumnosEnSala.Location = new System.Drawing.Point(12, 133);
            this.lstboxAlumnosEnSala.Name = "lstboxAlumnosEnSala";
            this.lstboxAlumnosEnSala.Size = new System.Drawing.Size(906, 274);
            this.lstboxAlumnosEnSala.TabIndex = 13;
            this.lstboxAlumnosEnSala.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstboxAlumnosEnSala_DragDrop);
            this.lstboxAlumnosEnSala.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstboxAlumnosEnSala_DragEnter);
            this.lstboxAlumnosEnSala.DoubleClick += new System.EventHandler(this.lstboxAlumnosEnSala_DoubleClick);
            // 
            // lstboxAlumnosSinSala
            // 
            this.lstboxAlumnosSinSala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstboxAlumnosSinSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxAlumnosSinSala.FormattingEnabled = true;
            this.lstboxAlumnosSinSala.ItemHeight = 18;
            this.lstboxAlumnosSinSala.Location = new System.Drawing.Point(15, 441);
            this.lstboxAlumnosSinSala.Name = "lstboxAlumnosSinSala";
            this.lstboxAlumnosSinSala.Size = new System.Drawing.Size(906, 274);
            this.lstboxAlumnosSinSala.TabIndex = 14;
            this.lstboxAlumnosSinSala.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstboxAlumnosSinSala_MouseDown);
            // 
            // lblAlumnosEnSala
            // 
            this.lblAlumnosEnSala.AutoSize = true;
            this.lblAlumnosEnSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnosEnSala.Location = new System.Drawing.Point(12, 112);
            this.lblAlumnosEnSala.Name = "lblAlumnosEnSala";
            this.lblAlumnosEnSala.Size = new System.Drawing.Size(117, 18);
            this.lblAlumnosEnSala.TabIndex = 15;
            this.lblAlumnosEnSala.Text = "Alumnos en sala";
            // 
            // lblAlumnosSinSalaAsignada
            // 
            this.lblAlumnosSinSalaAsignada.AutoSize = true;
            this.lblAlumnosSinSalaAsignada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnosSinSalaAsignada.Location = new System.Drawing.Point(12, 420);
            this.lblAlumnosSinSalaAsignada.Name = "lblAlumnosSinSalaAsignada";
            this.lblAlumnosSinSalaAsignada.Size = new System.Drawing.Size(183, 18);
            this.lblAlumnosSinSalaAsignada.TabIndex = 16;
            this.lblAlumnosSinSalaAsignada.Text = "Alumnos sin sala asignada";
            // 
            // btnGuardarAula
            // 
            this.btnGuardarAula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAula.Location = new System.Drawing.Point(763, 12);
            this.btnGuardarAula.Name = "btnGuardarAula";
            this.btnGuardarAula.Size = new System.Drawing.Size(158, 35);
            this.btnGuardarAula.TabIndex = 17;
            this.btnGuardarAula.Text = "Guarda Aula";
            this.btnGuardarAula.UseVisualStyleBackColor = true;
            this.btnGuardarAula.Click += new System.EventHandler(this.btnGuardarAula_Click);
            // 
            // btnInstrucciones
            // 
            this.btnInstrucciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstrucciones.Location = new System.Drawing.Point(568, 12);
            this.btnInstrucciones.Name = "btnInstrucciones";
            this.btnInstrucciones.Size = new System.Drawing.Size(158, 35);
            this.btnInstrucciones.TabIndex = 18;
            this.btnInstrucciones.Text = "Instrucciones";
            this.btnInstrucciones.UseVisualStyleBackColor = true;
            this.btnInstrucciones.Click += new System.EventHandler(this.btnInstrucciones_Click);
            // 
            // FrmAltaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 732);
            this.Controls.Add(this.btnInstrucciones);
            this.Controls.Add(this.btnGuardarAula);
            this.Controls.Add(this.lblAlumnosSinSalaAsignada);
            this.Controls.Add(this.lblAlumnosEnSala);
            this.Controls.Add(this.lstboxAlumnosSinSala);
            this.Controls.Add(this.lstboxAlumnosEnSala);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.lblColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAltaAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaAula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.ListBox lstboxAlumnosEnSala;
        private System.Windows.Forms.ListBox lstboxAlumnosSinSala;
        private System.Windows.Forms.Label lblAlumnosEnSala;
        private System.Windows.Forms.Label lblAlumnosSinSalaAsignada;
        private System.Windows.Forms.Button btnGuardarAula;
        private System.Windows.Forms.Button btnInstrucciones;
    }
}