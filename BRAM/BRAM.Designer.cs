namespace BRAM
{
    partial class BRAM
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BRAM));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(358, 740);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Departamento de Desarrollo de Aplicaciones Multiplataforma - Centre d\'Estudis Pol" +
    "itécnics 2024-2025";
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackColor = System.Drawing.Color.Silver;
            this.buttonInicio.BackgroundImage = global::BRAM.Properties.Resources.gradient_1080_1080__1_;
            this.buttonInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInicio.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonInicio.Font = new System.Drawing.Font("Webdings", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.Location = new System.Drawing.Point(500, 600);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(200, 50);
            this.buttonInicio.TabIndex = 9;
            this.buttonInicio.Text = "Iniciar";
            this.buttonInicio.UseVisualStyleBackColor = false;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // BRAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BRAM.Properties.Resources._360_F_412821610_95RpjzPXCE2LiWGVShIUCGJSktkJQh6P;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.buttonInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BRAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BRAM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInicio;
    }
}

