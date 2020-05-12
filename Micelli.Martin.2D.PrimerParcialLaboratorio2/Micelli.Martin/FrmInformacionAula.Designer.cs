namespace Micelli.Martin
{
    partial class FrmInformacionAula
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
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblAlumnosEnSala = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lstboxAlumnosEnSala = new System.Windows.Forms.ListBox();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.Location = new System.Drawing.Point(12, 70);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(66, 18);
            this.lblProfesor.TabIndex = 13;
            this.lblProfesor.Text = "Profesor";
            // 
            // lblAlumnosEnSala
            // 
            this.lblAlumnosEnSala.AutoSize = true;
            this.lblAlumnosEnSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnosEnSala.Location = new System.Drawing.Point(9, 105);
            this.lblAlumnosEnSala.Name = "lblAlumnosEnSala";
            this.lblAlumnosEnSala.Size = new System.Drawing.Size(117, 18);
            this.lblAlumnosEnSala.TabIndex = 16;
            this.lblAlumnosEnSala.Text = "Alumnos en sala";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(12, 27);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 18);
            this.lblColor.TabIndex = 17;
            this.lblColor.Text = "Color";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(339, 27);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(47, 18);
            this.lblTurno.TabIndex = 18;
            this.lblTurno.Text = "Turno";
            // 
            // lstboxAlumnosEnSala
            // 
            this.lstboxAlumnosEnSala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstboxAlumnosEnSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxAlumnosEnSala.FormattingEnabled = true;
            this.lstboxAlumnosEnSala.ItemHeight = 18;
            this.lstboxAlumnosEnSala.Location = new System.Drawing.Point(12, 126);
            this.lstboxAlumnosEnSala.Name = "lstboxAlumnosEnSala";
            this.lstboxAlumnosEnSala.Size = new System.Drawing.Size(915, 382);
            this.lstboxAlumnosEnSala.TabIndex = 19;
            // 
            // txtProfesor
            // 
            this.txtProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfesor.Location = new System.Drawing.Point(90, 70);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.ReadOnly = true;
            this.txtProfesor.Size = new System.Drawing.Size(837, 24);
            this.txtProfesor.TabIndex = 22;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(774, 21);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(153, 30);
            this.btnVolver.TabIndex = 23;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(90, 24);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(183, 24);
            this.txtColor.TabIndex = 24;
            // 
            // txtTurno
            // 
            this.txtTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurno.Location = new System.Drawing.Point(392, 24);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.ReadOnly = true;
            this.txtTurno.Size = new System.Drawing.Size(249, 24);
            this.txtTurno.TabIndex = 25;
            // 
            // FrmInformacionAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 520);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.lstboxAlumnosEnSala);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblAlumnosEnSala);
            this.Controls.Add(this.lblProfesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmInformacionAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion Aula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblAlumnosEnSala;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ListBox lstboxAlumnosEnSala;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtTurno;
    }
}