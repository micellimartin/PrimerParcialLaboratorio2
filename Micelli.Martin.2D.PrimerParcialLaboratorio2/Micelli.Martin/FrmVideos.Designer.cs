namespace Micelli.Martin
{
    partial class FrmVideos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVideos));
            this.btnTiburoncito = new System.Windows.Forms.Button();
            this.btnSilbar = new System.Windows.Forms.Button();
            this.btnBloopers = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.wmpReproductorDeVideo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.wmpReproductorDeVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTiburoncito
            // 
            this.btnTiburoncito.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiburoncito.Location = new System.Drawing.Point(12, 12);
            this.btnTiburoncito.Name = "btnTiburoncito";
            this.btnTiburoncito.Size = new System.Drawing.Size(175, 56);
            this.btnTiburoncito.TabIndex = 0;
            this.btnTiburoncito.Text = "Tiburoncito";
            this.btnTiburoncito.UseVisualStyleBackColor = true;
            this.btnTiburoncito.Click += new System.EventHandler(this.btnTiburoncito_Click);
            // 
            // btnSilbar
            // 
            this.btnSilbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSilbar.Location = new System.Drawing.Point(210, 12);
            this.btnSilbar.Name = "btnSilbar";
            this.btnSilbar.Size = new System.Drawing.Size(175, 56);
            this.btnSilbar.TabIndex = 2;
            this.btnSilbar.Text = "Silbar";
            this.btnSilbar.UseVisualStyleBackColor = true;
            this.btnSilbar.Click += new System.EventHandler(this.btnSilbar_Click);
            // 
            // btnBloopers
            // 
            this.btnBloopers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloopers.Location = new System.Drawing.Point(414, 12);
            this.btnBloopers.Name = "btnBloopers";
            this.btnBloopers.Size = new System.Drawing.Size(175, 56);
            this.btnBloopers.TabIndex = 3;
            this.btnBloopers.Text = "Bloopers";
            this.btnBloopers.UseVisualStyleBackColor = true;
            this.btnBloopers.Click += new System.EventHandler(this.btnBloopers_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(613, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(175, 56);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // wmpReproductorDeVideo
            // 
            this.wmpReproductorDeVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmpReproductorDeVideo.Enabled = true;
            this.wmpReproductorDeVideo.Location = new System.Drawing.Point(12, 74);
            this.wmpReproductorDeVideo.Name = "wmpReproductorDeVideo";
            this.wmpReproductorDeVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpReproductorDeVideo.OcxState")));
            this.wmpReproductorDeVideo.Size = new System.Drawing.Size(776, 469);
            this.wmpReproductorDeVideo.TabIndex = 5;
            // 
            // FrmVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.wmpReproductorDeVideo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBloopers);
            this.Controls.Add(this.btnSilbar);
            this.Controls.Add(this.btnTiburoncito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmVideos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Videos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVideos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.wmpReproductorDeVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTiburoncito;
        private System.Windows.Forms.Button btnSilbar;
        private System.Windows.Forms.Button btnBloopers;
        private System.Windows.Forms.Button btnVolver;
        private AxWMPLib.AxWindowsMediaPlayer wmpReproductorDeVideo;
    }
}