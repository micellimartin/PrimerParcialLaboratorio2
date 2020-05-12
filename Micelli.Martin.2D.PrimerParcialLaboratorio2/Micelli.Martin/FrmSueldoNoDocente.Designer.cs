namespace Micelli.Martin
{
    partial class FrmSueldoNoDocente
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
            this.lblSueldosNoDocentes = new System.Windows.Forms.Label();
            this.lstboxInformacionNoDocente = new System.Windows.Forms.ListBox();
            this.lblGastoTotal = new System.Windows.Forms.Label();
            this.txtGastoTotalSueldos = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSueldosNoDocentes
            // 
            this.lblSueldosNoDocentes.AutoSize = true;
            this.lblSueldosNoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldosNoDocentes.Location = new System.Drawing.Point(9, 19);
            this.lblSueldosNoDocentes.Name = "lblSueldosNoDocentes";
            this.lblSueldosNoDocentes.Size = new System.Drawing.Size(158, 18);
            this.lblSueldosNoDocentes.TabIndex = 17;
            this.lblSueldosNoDocentes.Text = "Sueldo por no docente";
            // 
            // lstboxInformacionNoDocente
            // 
            this.lstboxInformacionNoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxInformacionNoDocente.FormattingEnabled = true;
            this.lstboxInformacionNoDocente.ItemHeight = 18;
            this.lstboxInformacionNoDocente.Location = new System.Drawing.Point(12, 49);
            this.lstboxInformacionNoDocente.Name = "lstboxInformacionNoDocente";
            this.lstboxInformacionNoDocente.Size = new System.Drawing.Size(560, 310);
            this.lstboxInformacionNoDocente.TabIndex = 18;
            // 
            // lblGastoTotal
            // 
            this.lblGastoTotal.AutoSize = true;
            this.lblGastoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastoTotal.Location = new System.Drawing.Point(12, 378);
            this.lblGastoTotal.Name = "lblGastoTotal";
            this.lblGastoTotal.Size = new System.Drawing.Size(243, 18);
            this.lblGastoTotal.TabIndex = 19;
            this.lblGastoTotal.Text = "Gasto total en sueldos no docentes";
            // 
            // txtGastoTotalSueldos
            // 
            this.txtGastoTotalSueldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGastoTotalSueldos.Location = new System.Drawing.Point(285, 375);
            this.txtGastoTotalSueldos.Name = "txtGastoTotalSueldos";
            this.txtGastoTotalSueldos.ReadOnly = true;
            this.txtGastoTotalSueldos.Size = new System.Drawing.Size(287, 24);
            this.txtGastoTotalSueldos.TabIndex = 20;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(378, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(194, 31);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmSueldoNoDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 411);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtGastoTotalSueldos);
            this.Controls.Add(this.lblGastoTotal);
            this.Controls.Add(this.lstboxInformacionNoDocente);
            this.Controls.Add(this.lblSueldosNoDocentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSueldoNoDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sueldo no docente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSueldosNoDocentes;
        private System.Windows.Forms.ListBox lstboxInformacionNoDocente;
        private System.Windows.Forms.Label lblGastoTotal;
        private System.Windows.Forms.TextBox txtGastoTotalSueldos;
        private System.Windows.Forms.Button btnVolver;
    }
}