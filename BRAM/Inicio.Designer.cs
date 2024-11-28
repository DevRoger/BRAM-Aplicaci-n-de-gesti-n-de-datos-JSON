namespace BRAM
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.listViewArchivos = new System.Windows.Forms.ListView();
            this.buttonExaminar = new System.Windows.Forms.Button();
            this.checkBoxJSON = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFichDel = new System.Windows.Forms.Button();
            this.buttonFichMod = new System.Windows.Forms.Button();
            this.buttonFichCreate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDirMod = new System.Windows.Forms.Button();
            this.buttonDirCreate = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxGeneral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGeneral.Controls.Add(this.listViewArchivos);
            this.groupBoxGeneral.Controls.Add(this.buttonExaminar);
            this.groupBoxGeneral.Controls.Add(this.checkBoxJSON);
            this.groupBoxGeneral.Controls.Add(this.groupBox1);
            this.groupBoxGeneral.Controls.Add(this.groupBox2);
            this.groupBoxGeneral.Controls.Add(this.textBoxPath);
            this.groupBoxGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGeneral.Location = new System.Drawing.Point(12, 96);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(1160, 662);
            this.groupBoxGeneral.TabIndex = 0;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "Gestor de archivos";
            // 
            // listViewArchivos
            // 
            this.listViewArchivos.HideSelection = false;
            this.listViewArchivos.LargeImageList = this.imageList2;
            this.listViewArchivos.Location = new System.Drawing.Point(6, 325);
            this.listViewArchivos.MultiSelect = false;
            this.listViewArchivos.Name = "listViewArchivos";
            this.listViewArchivos.Size = new System.Drawing.Size(1148, 280);
            this.listViewArchivos.SmallImageList = this.imageList1;
            this.listViewArchivos.TabIndex = 21;
            this.listViewArchivos.UseCompatibleStateImageBehavior = false;
            this.listViewArchivos.SelectedIndexChanged += new System.EventHandler(this.listViewArchivos_SelectedIndexChanged);
            // 
            // buttonExaminar
            // 
            this.buttonExaminar.BackColor = System.Drawing.Color.Silver;
            this.buttonExaminar.BackgroundImage = global::BRAM.Properties.Resources.gradient_1080_1080__1_;
            this.buttonExaminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExaminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExaminar.Font = new System.Drawing.Font("Open Sans Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExaminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonExaminar.Image")));
            this.buttonExaminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExaminar.Location = new System.Drawing.Point(930, 35);
            this.buttonExaminar.Name = "buttonExaminar";
            this.buttonExaminar.Size = new System.Drawing.Size(200, 50);
            this.buttonExaminar.TabIndex = 20;
            this.buttonExaminar.Text = "Examinar";
            this.buttonExaminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExaminar.UseVisualStyleBackColor = false;
            this.buttonExaminar.Click += new System.EventHandler(this.buttonExaminar_Click);
            // 
            // checkBoxJSON
            // 
            this.checkBoxJSON.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxJSON.AutoSize = true;
            this.checkBoxJSON.FlatAppearance.BorderSize = 0;
            this.checkBoxJSON.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkBoxJSON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBoxJSON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkBoxJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxJSON.Font = new System.Drawing.Font("Open Sans Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxJSON.Image = global::BRAM.Properties.Resources.icons8_casilla_de_verificación_desactivada_26;
            this.checkBoxJSON.Location = new System.Drawing.Point(978, 610);
            this.checkBoxJSON.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxJSON.Name = "checkBoxJSON";
            this.checkBoxJSON.Size = new System.Drawing.Size(180, 47);
            this.checkBoxJSON.TabIndex = 19;
            this.checkBoxJSON.Text = "Solo JSON";
            this.checkBoxJSON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxJSON.UseVisualStyleBackColor = true;
            this.checkBoxJSON.CheckedChanged += new System.EventHandler(this.checkBoxJSON_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFichDel);
            this.groupBox1.Controls.Add(this.buttonFichMod);
            this.groupBox1.Controls.Add(this.buttonFichCreate);
            this.groupBox1.Location = new System.Drawing.Point(605, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(550, 230);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ficheros";
            // 
            // buttonFichDel
            // 
            this.buttonFichDel.BackColor = System.Drawing.Color.Silver;
            this.buttonFichDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFichDel.BackgroundImage")));
            this.buttonFichDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFichDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFichDel.Font = new System.Drawing.Font("Open Sans Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFichDel.Image = global::BRAM.Properties.Resources.icons8_trash_can_26;
            this.buttonFichDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFichDel.Location = new System.Drawing.Point(5, 176);
            this.buttonFichDel.Name = "buttonFichDel";
            this.buttonFichDel.Size = new System.Drawing.Size(540, 50);
            this.buttonFichDel.TabIndex = 13;
            this.buttonFichDel.Text = "Eliminar Fichero";
            this.buttonFichDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFichDel.UseVisualStyleBackColor = false;
            // 
            // buttonFichMod
            // 
            this.buttonFichMod.BackColor = System.Drawing.Color.Silver;
            this.buttonFichMod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFichMod.BackgroundImage")));
            this.buttonFichMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFichMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFichMod.Font = new System.Drawing.Font("Open Sans Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFichMod.Image = ((System.Drawing.Image)(resources.GetObject("buttonFichMod.Image")));
            this.buttonFichMod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFichMod.Location = new System.Drawing.Point(5, 111);
            this.buttonFichMod.Name = "buttonFichMod";
            this.buttonFichMod.Size = new System.Drawing.Size(540, 50);
            this.buttonFichMod.TabIndex = 12;
            this.buttonFichMod.Text = "Modificar Fichero";
            this.buttonFichMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFichMod.UseVisualStyleBackColor = false;
            // 
            // buttonFichCreate
            // 
            this.buttonFichCreate.BackColor = System.Drawing.Color.Silver;
            this.buttonFichCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFichCreate.BackgroundImage")));
            this.buttonFichCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFichCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFichCreate.Font = new System.Drawing.Font("Open Sans Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFichCreate.Image = ((System.Drawing.Image)(resources.GetObject("buttonFichCreate.Image")));
            this.buttonFichCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFichCreate.Location = new System.Drawing.Point(5, 46);
            this.buttonFichCreate.Name = "buttonFichCreate";
            this.buttonFichCreate.Size = new System.Drawing.Size(540, 50);
            this.buttonFichCreate.TabIndex = 11;
            this.buttonFichCreate.Text = "Crear Fichero";
            this.buttonFichCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFichCreate.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDirMod);
            this.groupBox2.Controls.Add(this.buttonDirCreate);
            this.groupBox2.Location = new System.Drawing.Point(6, 140);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(550, 180);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Directorios";
            // 
            // buttonDirMod
            // 
            this.buttonDirMod.BackColor = System.Drawing.Color.Silver;
            this.buttonDirMod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDirMod.BackgroundImage")));
            this.buttonDirMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDirMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDirMod.Font = new System.Drawing.Font("Open Sans Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDirMod.Image = ((System.Drawing.Image)(resources.GetObject("buttonDirMod.Image")));
            this.buttonDirMod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDirMod.Location = new System.Drawing.Point(5, 110);
            this.buttonDirMod.Name = "buttonDirMod";
            this.buttonDirMod.Size = new System.Drawing.Size(540, 50);
            this.buttonDirMod.TabIndex = 12;
            this.buttonDirMod.Text = "Modificar Directorio";
            this.buttonDirMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDirMod.UseVisualStyleBackColor = false;
            // 
            // buttonDirCreate
            // 
            this.buttonDirCreate.BackColor = System.Drawing.Color.Silver;
            this.buttonDirCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDirCreate.BackgroundImage")));
            this.buttonDirCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDirCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDirCreate.Font = new System.Drawing.Font("Open Sans Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDirCreate.Image = ((System.Drawing.Image)(resources.GetObject("buttonDirCreate.Image")));
            this.buttonDirCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDirCreate.Location = new System.Drawing.Point(5, 46);
            this.buttonDirCreate.Name = "buttonDirCreate";
            this.buttonDirCreate.Size = new System.Drawing.Size(540, 50);
            this.buttonDirCreate.TabIndex = 11;
            this.buttonDirCreate.Text = "Crear Directorio";
            this.buttonDirCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDirCreate.UseVisualStyleBackColor = false;
            // 
            // textBoxPath
            // 
            this.textBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPath.Location = new System.Drawing.Point(6, 39);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(897, 38);
            this.textBoxPath.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(146)))), ((int)(((byte)(172)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1090, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(146)))), ((int)(((byte)(172)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1187, 90);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "directory_icon.png");
            this.imageList1.Images.SetKeyName(1, "file_icon.png");
            this.imageList1.Images.SetKeyName(2, "json_icon.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "directory_icon.png");
            this.imageList2.Images.SetKeyName(1, "file_icon.png");
            this.imageList2.Images.SetKeyName(2, "json_icon.png");
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BRAM.Properties.Resources._360_F_412821610_95RpjzPXCE2LiWGVShIUCGJSktkJQh6P;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBoxGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inicio_FormClosed);
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDirCreate;
        private System.Windows.Forms.CheckBox checkBoxJSON;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFichDel;
        private System.Windows.Forms.Button buttonFichMod;
        private System.Windows.Forms.Button buttonFichCreate;
        private System.Windows.Forms.Button buttonDirMod;
        private System.Windows.Forms.Button buttonExaminar;
        private System.Windows.Forms.ListView listViewArchivos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}