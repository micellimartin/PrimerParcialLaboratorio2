namespace Micelli.Martin
{
    partial class FrmAltaResponsable
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
            this.btnAgregarNuevoResponsable = new System.Windows.Forms.Button();
            this.lblInformacionResponsable = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.lblParentesco = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.cmbParentesco = new System.Windows.Forms.ComboBox();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.btnUsarResponsableExistente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarNuevoResponsable
            // 
            this.btnAgregarNuevoResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNuevoResponsable.Location = new System.Drawing.Point(15, 350);
            this.btnAgregarNuevoResponsable.Name = "btnAgregarNuevoResponsable";
            this.btnAgregarNuevoResponsable.Size = new System.Drawing.Size(382, 33);
            this.btnAgregarNuevoResponsable.TabIndex = 7;
            this.btnAgregarNuevoResponsable.Text = "Agregar nuevo responsable";
            this.btnAgregarNuevoResponsable.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoResponsable.Click += new System.EventHandler(this.btnAgregarNuevoResponsable_Click);
            // 
            // lblInformacionResponsable
            // 
            this.lblInformacionResponsable.AutoSize = true;
            this.lblInformacionResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionResponsable.Location = new System.Drawing.Point(67, 18);
            this.lblInformacionResponsable.Name = "lblInformacionResponsable";
            this.lblInformacionResponsable.Size = new System.Drawing.Size(261, 18);
            this.lblInformacionResponsable.TabIndex = 34;
            this.lblInformacionResponsable.Text = "INFORMACION DEL RESPONSABLE";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(12, 95);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 18);
            this.lblApellido.TabIndex = 36;
            this.lblApellido.Text = "Apellido";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(12, 149);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(42, 18);
            this.lblSexo.TabIndex = 37;
            this.lblSexo.Text = "Sexo";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(12, 200);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 18);
            this.lblDni.TabIndex = 38;
            this.lblDni.Text = "DNI";
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTelefono.Location = new System.Drawing.Point(12, 252);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(139, 18);
            this.lblNumeroTelefono.TabIndex = 39;
            this.lblNumeroTelefono.Text = "Numero de telefono";
            // 
            // lblParentesco
            // 
            this.lblParentesco.AutoSize = true;
            this.lblParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentesco.Location = new System.Drawing.Point(12, 306);
            this.lblParentesco.Name = "lblParentesco";
            this.lblParentesco.Size = new System.Drawing.Size(181, 18);
            this.lblParentesco.TabIndex = 40;
            this.lblParentesco.Text = "Parentesco con el alumno";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(205, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(205, 95);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(189, 24);
            this.txtApellido.TabIndex = 2;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(205, 149);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(189, 26);
            this.cmbSexo.TabIndex = 3;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(205, 200);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(189, 24);
            this.txtDni.TabIndex = 4;
            // 
            // cmbParentesco
            // 
            this.cmbParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParentesco.FormattingEnabled = true;
            this.cmbParentesco.Items.AddRange(new object[] {
            "Madre",
            "Padre",
            "Tia",
            "Tio",
            "Abuela",
            "Abuelo",
            "Otro"});
            this.cmbParentesco.Location = new System.Drawing.Point(205, 298);
            this.cmbParentesco.Name = "cmbParentesco";
            this.cmbParentesco.Size = new System.Drawing.Size(189, 26);
            this.cmbParentesco.TabIndex = 6;
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTelefono.Location = new System.Drawing.Point(205, 246);
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(189, 24);
            this.txtNumeroTelefono.TabIndex = 5;
            // 
            // btnUsarResponsableExistente
            // 
            this.btnUsarResponsableExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsarResponsableExistente.Location = new System.Drawing.Point(15, 400);
            this.btnUsarResponsableExistente.Name = "btnUsarResponsableExistente";
            this.btnUsarResponsableExistente.Size = new System.Drawing.Size(382, 33);
            this.btnUsarResponsableExistente.TabIndex = 41;
            this.btnUsarResponsableExistente.Text = "Usar un responsable ya existente";
            this.btnUsarResponsableExistente.UseVisualStyleBackColor = true;
            this.btnUsarResponsableExistente.Click += new System.EventHandler(this.btnUsarResponsableExistente_Click);
            // 
            // FrmAltaResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 445);
            this.Controls.Add(this.btnUsarResponsableExistente);
            this.Controls.Add(this.txtNumeroTelefono);
            this.Controls.Add(this.cmbParentesco);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblParentesco);
            this.Controls.Add(this.lblNumeroTelefono);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblInformacionResponsable);
            this.Controls.Add(this.btnAgregarNuevoResponsable);
            this.MaximizeBox = false;
            this.Name = "FrmAltaResponsable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta responsable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarNuevoResponsable;
        private System.Windows.Forms.Label lblInformacionResponsable;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.Label lblParentesco;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox cmbParentesco;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Button btnUsarResponsableExistente;
    }
}