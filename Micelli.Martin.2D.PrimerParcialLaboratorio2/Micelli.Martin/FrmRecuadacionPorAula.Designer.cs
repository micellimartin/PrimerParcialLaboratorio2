namespace Micelli.Martin
{
    partial class FrmRecuadacionPorAula
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
            this.lblAula = new System.Windows.Forms.Label();
            this.cmbAula = new System.Windows.Forms.ComboBox();
            this.lblCuotaPorAlumno = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lstboxCuotaPorAlumno = new System.Windows.Forms.ListBox();
            this.lblRecaudacionTotalAula = new System.Windows.Forms.Label();
            this.txtGastoTotalSueldos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula.Location = new System.Drawing.Point(12, 27);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(36, 18);
            this.lblAula.TabIndex = 15;
            this.lblAula.Text = "Aula";
            // 
            // cmbAula
            // 
            this.cmbAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAula.FormattingEnabled = true;
            this.cmbAula.Location = new System.Drawing.Point(66, 24);
            this.cmbAula.Name = "cmbAula";
            this.cmbAula.Size = new System.Drawing.Size(501, 26);
            this.cmbAula.TabIndex = 16;
            this.cmbAula.SelectedValueChanged += new System.EventHandler(this.cmbAula_SelectedValueChanged);
            // 
            // lblCuotaPorAlumno
            // 
            this.lblCuotaPorAlumno.AutoSize = true;
            this.lblCuotaPorAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaPorAlumno.Location = new System.Drawing.Point(12, 72);
            this.lblCuotaPorAlumno.Name = "lblCuotaPorAlumno";
            this.lblCuotaPorAlumno.Size = new System.Drawing.Size(171, 18);
            this.lblCuotaPorAlumno.TabIndex = 17;
            this.lblCuotaPorAlumno.Text = "Precio cuota por alumno";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(447, 68);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 26);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lstboxCuotaPorAlumno
            // 
            this.lstboxCuotaPorAlumno.Enabled = false;
            this.lstboxCuotaPorAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxCuotaPorAlumno.FormattingEnabled = true;
            this.lstboxCuotaPorAlumno.ItemHeight = 18;
            this.lstboxCuotaPorAlumno.Location = new System.Drawing.Point(12, 100);
            this.lstboxCuotaPorAlumno.Name = "lstboxCuotaPorAlumno";
            this.lstboxCuotaPorAlumno.Size = new System.Drawing.Size(560, 310);
            this.lstboxCuotaPorAlumno.TabIndex = 20;
            // 
            // lblRecaudacionTotalAula
            // 
            this.lblRecaudacionTotalAula.AutoSize = true;
            this.lblRecaudacionTotalAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecaudacionTotalAula.Location = new System.Drawing.Point(12, 427);
            this.lblRecaudacionTotalAula.Name = "lblRecaudacionTotalAula";
            this.lblRecaudacionTotalAula.Size = new System.Drawing.Size(184, 18);
            this.lblRecaudacionTotalAula.TabIndex = 21;
            this.lblRecaudacionTotalAula.Text = "Recaudacion total por aula";
            // 
            // txtGastoTotalSueldos
            // 
            this.txtGastoTotalSueldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGastoTotalSueldos.Location = new System.Drawing.Point(285, 424);
            this.txtGastoTotalSueldos.Name = "txtGastoTotalSueldos";
            this.txtGastoTotalSueldos.ReadOnly = true;
            this.txtGastoTotalSueldos.Size = new System.Drawing.Size(287, 24);
            this.txtGastoTotalSueldos.TabIndex = 22;
            // 
            // FrmRecuadacionPorAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 457);
            this.Controls.Add(this.txtGastoTotalSueldos);
            this.Controls.Add(this.lblRecaudacionTotalAula);
            this.Controls.Add(this.lstboxCuotaPorAlumno);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblCuotaPorAlumno);
            this.Controls.Add(this.cmbAula);
            this.Controls.Add(this.lblAula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRecuadacionPorAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recaudacion por aula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.ComboBox cmbAula;
        private System.Windows.Forms.Label lblCuotaPorAlumno;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ListBox lstboxCuotaPorAlumno;
        private System.Windows.Forms.Label lblRecaudacionTotalAula;
        private System.Windows.Forms.TextBox txtGastoTotalSueldos;
    }
}