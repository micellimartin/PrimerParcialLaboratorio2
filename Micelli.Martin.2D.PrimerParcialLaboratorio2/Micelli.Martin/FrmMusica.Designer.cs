namespace Micelli.Martin
{
    partial class FrmMusica
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
            this.btnOneStop = new System.Windows.Forms.Button();
            this.btnFlourish = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOneStop
            // 
            this.btnOneStop.BackColor = System.Drawing.Color.Yellow;
            this.btnOneStop.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneStop.Location = new System.Drawing.Point(23, 24);
            this.btnOneStop.Name = "btnOneStop";
            this.btnOneStop.Size = new System.Drawing.Size(243, 82);
            this.btnOneStop.TabIndex = 0;
            this.btnOneStop.Text = "One Stop";
            this.btnOneStop.UseVisualStyleBackColor = false;
            this.btnOneStop.Click += new System.EventHandler(this.btnOneStop_Click);
            // 
            // btnFlourish
            // 
            this.btnFlourish.BackColor = System.Drawing.Color.Fuchsia;
            this.btnFlourish.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlourish.Location = new System.Drawing.Point(23, 140);
            this.btnFlourish.Name = "btnFlourish";
            this.btnFlourish.Size = new System.Drawing.Size(243, 82);
            this.btnFlourish.TabIndex = 1;
            this.btnFlourish.Text = "Flourish";
            this.btnFlourish.UseVisualStyleBackColor = false;
            this.btnFlourish.Click += new System.EventHandler(this.btnFlourish_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(23, 256);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(243, 82);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(293, 362);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnFlourish);
            this.Controls.Add(this.btnOneStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMusica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMusica_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOneStop;
        private System.Windows.Forms.Button btnFlourish;
        private System.Windows.Forms.Button btnVolver;
    }
}