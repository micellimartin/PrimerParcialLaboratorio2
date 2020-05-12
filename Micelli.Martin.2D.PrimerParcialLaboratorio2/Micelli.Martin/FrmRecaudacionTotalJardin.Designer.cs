namespace Micelli.Martin
{
    partial class FrmRecaudacionTotalJardin
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
            this.lblRecaudacionPorAula = new System.Windows.Forms.Label();
            this.lstboxRecaudacionPorAula = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblRecaudacionTotalJardin = new System.Windows.Forms.Label();
            this.txtRecaudacionTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRecaudacionPorAula
            // 
            this.lblRecaudacionPorAula.AutoSize = true;
            this.lblRecaudacionPorAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecaudacionPorAula.Location = new System.Drawing.Point(12, 18);
            this.lblRecaudacionPorAula.Name = "lblRecaudacionPorAula";
            this.lblRecaudacionPorAula.Size = new System.Drawing.Size(152, 18);
            this.lblRecaudacionPorAula.TabIndex = 18;
            this.lblRecaudacionPorAula.Text = "Recaudacion por aula";
            // 
            // lstboxRecaudacionPorAula
            // 
            this.lstboxRecaudacionPorAula.Enabled = false;
            this.lstboxRecaudacionPorAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxRecaudacionPorAula.FormattingEnabled = true;
            this.lstboxRecaudacionPorAula.ItemHeight = 18;
            this.lstboxRecaudacionPorAula.Location = new System.Drawing.Point(12, 51);
            this.lstboxRecaudacionPorAula.Name = "lstboxRecaudacionPorAula";
            this.lstboxRecaudacionPorAula.Size = new System.Drawing.Size(723, 310);
            this.lstboxRecaudacionPorAula.TabIndex = 21;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(615, 14);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 26);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblRecaudacionTotalJardin
            // 
            this.lblRecaudacionTotalJardin.AutoSize = true;
            this.lblRecaudacionTotalJardin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecaudacionTotalJardin.Location = new System.Drawing.Point(217, 385);
            this.lblRecaudacionTotalJardin.Name = "lblRecaudacionTotalJardin";
            this.lblRecaudacionTotalJardin.Size = new System.Drawing.Size(189, 18);
            this.lblRecaudacionTotalJardin.TabIndex = 23;
            this.lblRecaudacionTotalJardin.Text = "Recaudacion total del jardin";
            // 
            // txtRecaudacionTotal
            // 
            this.txtRecaudacionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecaudacionTotal.Location = new System.Drawing.Point(448, 382);
            this.txtRecaudacionTotal.Name = "txtRecaudacionTotal";
            this.txtRecaudacionTotal.ReadOnly = true;
            this.txtRecaudacionTotal.Size = new System.Drawing.Size(287, 24);
            this.txtRecaudacionTotal.TabIndex = 24;
            // 
            // FrmRecaudacionTotalJardin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 418);
            this.Controls.Add(this.txtRecaudacionTotal);
            this.Controls.Add(this.lblRecaudacionTotalJardin);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lstboxRecaudacionPorAula);
            this.Controls.Add(this.lblRecaudacionPorAula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRecaudacionTotalJardin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recaudacion total del jardin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecaudacionPorAula;
        private System.Windows.Forms.ListBox lstboxRecaudacionPorAula;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblRecaudacionTotalJardin;
        private System.Windows.Forms.TextBox txtRecaudacionTotal;
    }
}