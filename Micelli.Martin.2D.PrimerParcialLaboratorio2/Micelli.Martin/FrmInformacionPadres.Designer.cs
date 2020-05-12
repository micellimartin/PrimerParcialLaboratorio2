namespace Micelli.Martin
{
    partial class FrmInformacionPadres
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
            this.lblInfoResponsables = new System.Windows.Forms.Label();
            this.lstboxInformacionResponsables = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula.Location = new System.Drawing.Point(12, 15);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(36, 18);
            this.lblAula.TabIndex = 14;
            this.lblAula.Text = "Aula";
            // 
            // cmbAula
            // 
            this.cmbAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAula.FormattingEnabled = true;
            this.cmbAula.Location = new System.Drawing.Point(74, 12);
            this.cmbAula.Name = "cmbAula";
            this.cmbAula.Size = new System.Drawing.Size(501, 26);
            this.cmbAula.TabIndex = 15;
            this.cmbAula.SelectedValueChanged += new System.EventHandler(this.cmbAula_SelectedValueChanged);
            // 
            // lblInfoResponsables
            // 
            this.lblInfoResponsables.AutoSize = true;
            this.lblInfoResponsables.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoResponsables.Location = new System.Drawing.Point(12, 63);
            this.lblInfoResponsables.Name = "lblInfoResponsables";
            this.lblInfoResponsables.Size = new System.Drawing.Size(215, 18);
            this.lblInfoResponsables.TabIndex = 16;
            this.lblInfoResponsables.Text = "Informacion de los responables";
            // 
            // lstboxInformacionResponsables
            // 
            this.lstboxInformacionResponsables.Enabled = false;
            this.lstboxInformacionResponsables.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxInformacionResponsables.FormattingEnabled = true;
            this.lstboxInformacionResponsables.ItemHeight = 18;
            this.lstboxInformacionResponsables.Location = new System.Drawing.Point(15, 94);
            this.lstboxInformacionResponsables.Name = "lstboxInformacionResponsables";
            this.lstboxInformacionResponsables.Size = new System.Drawing.Size(560, 310);
            this.lstboxInformacionResponsables.TabIndex = 17;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(455, 55);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 26);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmInformacionPadres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 418);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lstboxInformacionResponsables);
            this.Controls.Add(this.lblInfoResponsables);
            this.Controls.Add(this.cmbAula);
            this.Controls.Add(this.lblAula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmInformacionPadres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion Padres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.ComboBox cmbAula;
        private System.Windows.Forms.Label lblInfoResponsables;
        private System.Windows.Forms.ListBox lstboxInformacionResponsables;
        private System.Windows.Forms.Button btnVolver;
    }
}