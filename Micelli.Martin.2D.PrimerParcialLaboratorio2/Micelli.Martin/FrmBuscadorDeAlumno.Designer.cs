namespace Micelli.Martin
{
    partial class FrmBuscadorDeAlumno
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
            this.lblIngreseApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lstboxInformacionAlumno = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblInformacionAlumno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIngreseApellido
            // 
            this.lblIngreseApellido.AutoSize = true;
            this.lblIngreseApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseApellido.Location = new System.Drawing.Point(12, 18);
            this.lblIngreseApellido.Name = "lblIngreseApellido";
            this.lblIngreseApellido.Size = new System.Drawing.Size(280, 18);
            this.lblIngreseApellido.TabIndex = 5;
            this.lblIngreseApellido.Text = "Ingrese el apellido del alumno a encontrar";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(15, 43);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(302, 24);
            this.txtApellido.TabIndex = 6;
            // 
            // lstboxInformacionAlumno
            // 
            this.lstboxInformacionAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxInformacionAlumno.FormattingEnabled = true;
            this.lstboxInformacionAlumno.ItemHeight = 18;
            this.lstboxInformacionAlumno.Location = new System.Drawing.Point(15, 102);
            this.lstboxInformacionAlumno.Name = "lstboxInformacionAlumno";
            this.lstboxInformacionAlumno.Size = new System.Drawing.Size(940, 274);
            this.lstboxInformacionAlumno.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(340, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(319, 33);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblInformacionAlumno
            // 
            this.lblInformacionAlumno.AutoSize = true;
            this.lblInformacionAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionAlumno.Location = new System.Drawing.Point(12, 81);
            this.lblInformacionAlumno.Name = "lblInformacionAlumno";
            this.lblInformacionAlumno.Size = new System.Drawing.Size(162, 18);
            this.lblInformacionAlumno.TabIndex = 9;
            this.lblInformacionAlumno.Text = "Informacion del alumno";
            // 
            // FrmBuscadorDeAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 388);
            this.Controls.Add(this.lblInformacionAlumno);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lstboxInformacionAlumno);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblIngreseApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBuscadorDeAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador de alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ListBox lstboxInformacionAlumno;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblInformacionAlumno;
    }
}