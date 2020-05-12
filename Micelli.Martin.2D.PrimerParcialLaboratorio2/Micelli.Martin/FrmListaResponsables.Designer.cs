namespace Micelli.Martin
{
    partial class FrmListaResponsables
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
            this.lblSeleccioneResponsable = new System.Windows.Forms.Label();
            this.lstboxResponsables = new System.Windows.Forms.ListBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSeleccioneResponsable
            // 
            this.lblSeleccioneResponsable.AutoSize = true;
            this.lblSeleccioneResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneResponsable.Location = new System.Drawing.Point(12, 18);
            this.lblSeleccioneResponsable.Name = "lblSeleccioneResponsable";
            this.lblSeleccioneResponsable.Size = new System.Drawing.Size(186, 18);
            this.lblSeleccioneResponsable.TabIndex = 0;
            this.lblSeleccioneResponsable.Text = "Seleccione un responsable";
            // 
            // lstboxResponsables
            // 
            this.lstboxResponsables.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxResponsables.FormattingEnabled = true;
            this.lstboxResponsables.ItemHeight = 18;
            this.lstboxResponsables.Location = new System.Drawing.Point(12, 39);
            this.lstboxResponsables.Name = "lstboxResponsables";
            this.lstboxResponsables.Size = new System.Drawing.Size(573, 364);
            this.lstboxResponsables.TabIndex = 1;
            this.lstboxResponsables.DoubleClick += new System.EventHandler(this.lstboxResponsables_DoubleClick);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(381, 18);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(204, 18);
            this.lblInformacion.TabIndex = 2;
            this.lblInformacion.Text = "(Doble click para seleccionar)";
            // 
            // FrmListaResponsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 417);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lstboxResponsables);
            this.Controls.Add(this.lblSeleccioneResponsable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmListaResponsables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista responsables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccioneResponsable;
        private System.Windows.Forms.ListBox lstboxResponsables;
        private System.Windows.Forms.Label lblInformacion;
    }
}