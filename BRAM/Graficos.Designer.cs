namespace BRAM
{
    partial class Graficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graficos));
            this.chartErroresFacil = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chartTiempoDificil = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chartErroresDificil = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.labelErrores = new System.Windows.Forms.Label();
            this.chartTiempoFacil = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartErroresFacil)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiempoDificil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartErroresDificil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiempoFacil)).BeginInit();
            this.SuspendLayout();
            // 
            // chartErroresFacil
            // 
            this.chartErroresFacil.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.chartErroresFacil.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartErroresFacil.Legends.Add(legend5);
            this.chartErroresFacil.Location = new System.Drawing.Point(0, 143);
            this.chartErroresFacil.Name = "chartErroresFacil";
            this.chartErroresFacil.Size = new System.Drawing.Size(567, 274);
            this.chartErroresFacil.TabIndex = 1;
            this.chartErroresFacil.Text = "chart2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chartTiempoDificil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chartErroresDificil);
            this.groupBox1.Controls.Add(this.labelTiempo);
            this.groupBox1.Controls.Add(this.labelErrores);
            this.groupBox1.Controls.Add(this.chartTiempoFacil);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.buttonVolver);
            this.groupBox1.Controls.Add(this.chartErroresFacil);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 737);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 36);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tiempo - Modo Difícil";
            // 
            // chartTiempoDificil
            // 
            this.chartTiempoDificil.BackColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            this.chartTiempoDificil.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartTiempoDificil.Legends.Add(legend6);
            this.chartTiempoDificil.Location = new System.Drawing.Point(587, 457);
            this.chartTiempoDificil.Name = "chartTiempoDificil";
            this.chartTiempoDificil.Size = new System.Drawing.Size(567, 274);
            this.chartTiempoDificil.TabIndex = 26;
            this.chartTiempoDificil.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Errores - Modo Difícil";
            // 
            // chartErroresDificil
            // 
            this.chartErroresDificil.BackColor = System.Drawing.Color.Transparent;
            chartArea7.Name = "ChartArea1";
            this.chartErroresDificil.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartErroresDificil.Legends.Add(legend7);
            this.chartErroresDificil.Location = new System.Drawing.Point(-12, 457);
            this.chartErroresDificil.Name = "chartErroresDificil";
            this.chartErroresDificil.Size = new System.Drawing.Size(567, 274);
            this.chartErroresDificil.TabIndex = 24;
            this.chartErroresDificil.Text = "chart2";
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.Location = new System.Drawing.Point(609, 104);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(301, 36);
            this.labelTiempo.TabIndex = 23;
            this.labelTiempo.Text = "Tiempo - Modo Fácil";
            // 
            // labelErrores
            // 
            this.labelErrores.AutoSize = true;
            this.labelErrores.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrores.Location = new System.Drawing.Point(12, 104);
            this.labelErrores.Name = "labelErrores";
            this.labelErrores.Size = new System.Drawing.Size(302, 36);
            this.labelErrores.TabIndex = 22;
            this.labelErrores.Text = "Errores - Modo Fácil";
            // 
            // chartTiempoFacil
            // 
            this.chartTiempoFacil.BackColor = System.Drawing.Color.Transparent;
            chartArea8.Name = "ChartArea1";
            this.chartTiempoFacil.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartTiempoFacil.Legends.Add(legend8);
            this.chartTiempoFacil.Location = new System.Drawing.Point(587, 143);
            this.chartTiempoFacil.Name = "chartTiempoFacil";
            this.chartTiempoFacil.Size = new System.Drawing.Size(567, 274);
            this.chartTiempoFacil.TabIndex = 21;
            this.chartTiempoFacil.Text = "chart2";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(6, 16);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(581, 72);
            this.labelNombre.TabIndex = 20;
            this.labelNombre.Text = "Nombre de alumno";
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.Silver;
            this.buttonVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVolver.BackgroundImage")));
            this.buttonVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.Font = new System.Drawing.Font("Open Sans Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonVolver.Location = new System.Drawing.Point(910, 19);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(244, 50);
            this.buttonVolver.TabIndex = 19;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // Graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BRAM.Properties.Resources._360_F_412821610_95RpjzPXCE2LiWGVShIUCGJSktkJQh6P;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Graficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información de alumno";
            ((System.ComponentModel.ISupportInitialize)(this.chartErroresFacil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiempoDificil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartErroresDificil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiempoFacil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartErroresFacil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTiempoFacil;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelErrores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTiempoDificil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartErroresDificil;
    }
}