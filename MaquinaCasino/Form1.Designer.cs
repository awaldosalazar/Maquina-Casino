namespace MaquinaCasino
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonJugar = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_10 = new System.Windows.Forms.Button();
            this.buttonAggCdt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCreditos = new System.Windows.Forms.Label();
            this.labelAgregaC = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_2 = new System.Windows.Forms.CheckBox();
            this.checkBox_20 = new System.Windows.Forms.CheckBox();
            this.checkBox_10 = new System.Windows.Forms.CheckBox();
            this.checkBox_5 = new System.Windows.Forms.CheckBox();
            this.buttonDarCambio = new System.Windows.Forms.Button();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.label_10 = new System.Windows.Forms.Label();
            this.label_20 = new System.Windows.Forms.Label();
            this.labelCambio = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonJugar
            // 
            this.buttonJugar.Location = new System.Drawing.Point(284, 365);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(49, 23);
            this.buttonJugar.TabIndex = 1;
            this.buttonJugar.Text = "Jugar";
            this.buttonJugar.UseVisualStyleBackColor = true;
            this.buttonJugar.Click += new System.EventHandler(this.ButtonJugar_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(57, 365);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(39, 23);
            this.button_2.TabIndex = 2;
            this.button_2.Text = "$2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.Button_2_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(12, 365);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(39, 23);
            this.button_1.TabIndex = 3;
            this.button_1.Text = "$1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.Button_1_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(102, 365);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(39, 23);
            this.button_5.TabIndex = 4;
            this.button_5.Text = "$5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.Button_5_Click);
            // 
            // button_10
            // 
            this.button_10.Location = new System.Drawing.Point(147, 365);
            this.button_10.Name = "button_10";
            this.button_10.Size = new System.Drawing.Size(39, 23);
            this.button_10.TabIndex = 5;
            this.button_10.Text = "$10";
            this.button_10.UseVisualStyleBackColor = true;
            this.button_10.Click += new System.EventHandler(this.Button_10_Click);
            // 
            // buttonAggCdt
            // 
            this.buttonAggCdt.Location = new System.Drawing.Point(192, 365);
            this.buttonAggCdt.Name = "buttonAggCdt";
            this.buttonAggCdt.Size = new System.Drawing.Size(86, 23);
            this.buttonAggCdt.TabIndex = 6;
            this.buttonAggCdt.Text = "AgregarCredito";
            this.buttonAggCdt.UseVisualStyleBackColor = true;
            this.buttonAggCdt.Visible = false;
            this.buttonAggCdt.Click += new System.EventHandler(this.ButtonAggCdt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(66, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Agrega 7 creditos para jugar una vez";
            // 
            // labelCreditos
            // 
            this.labelCreditos.AutoSize = true;
            this.labelCreditos.Location = new System.Drawing.Point(133, 11);
            this.labelCreditos.Name = "labelCreditos";
            this.labelCreditos.Size = new System.Drawing.Size(57, 13);
            this.labelCreditos.TabIndex = 8;
            this.labelCreditos.Text = "Creditos: 0";
            // 
            // labelAgregaC
            // 
            this.labelAgregaC.AutoSize = true;
            this.labelAgregaC.Location = new System.Drawing.Point(144, 349);
            this.labelAgregaC.Name = "labelAgregaC";
            this.labelAgregaC.Size = new System.Drawing.Size(47, 13);
            this.labelAgregaC.TabIndex = 9;
            this.labelAgregaC.Text = "CASINO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(123, 394);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Monedas disponibles ->";
            // 
            // checkBox_2
            // 
            this.checkBox_2.AutoSize = true;
            this.checkBox_2.Location = new System.Drawing.Point(170, 451);
            this.checkBox_2.Name = "checkBox_2";
            this.checkBox_2.Size = new System.Drawing.Size(15, 14);
            this.checkBox_2.TabIndex = 12;
            this.checkBox_2.UseVisualStyleBackColor = true;
            // 
            // checkBox_20
            // 
            this.checkBox_20.AutoSize = true;
            this.checkBox_20.Location = new System.Drawing.Point(295, 450);
            this.checkBox_20.Name = "checkBox_20";
            this.checkBox_20.Size = new System.Drawing.Size(15, 14);
            this.checkBox_20.TabIndex = 13;
            this.checkBox_20.UseVisualStyleBackColor = true;
            // 
            // checkBox_10
            // 
            this.checkBox_10.AutoSize = true;
            this.checkBox_10.Location = new System.Drawing.Point(249, 451);
            this.checkBox_10.Name = "checkBox_10";
            this.checkBox_10.Size = new System.Drawing.Size(15, 14);
            this.checkBox_10.TabIndex = 15;
            this.checkBox_10.UseVisualStyleBackColor = true;
            // 
            // checkBox_5
            // 
            this.checkBox_5.AutoSize = true;
            this.checkBox_5.Location = new System.Drawing.Point(208, 451);
            this.checkBox_5.Name = "checkBox_5";
            this.checkBox_5.Size = new System.Drawing.Size(15, 14);
            this.checkBox_5.TabIndex = 16;
            this.checkBox_5.UseVisualStyleBackColor = true;
            // 
            // buttonDarCambio
            // 
            this.buttonDarCambio.Location = new System.Drawing.Point(21, 450);
            this.buttonDarCambio.Name = "buttonDarCambio";
            this.buttonDarCambio.Size = new System.Drawing.Size(75, 23);
            this.buttonDarCambio.TabIndex = 17;
            this.buttonDarCambio.Text = "Dar cambio";
            this.buttonDarCambio.UseVisualStyleBackColor = true;
            this.buttonDarCambio.Click += new System.EventHandler(this.ButtonDarCambio_Click);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(34, 515);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(31, 13);
            this.label_1.TabIndex = 18;
            this.label_1.Text = "$1: 0";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Location = new System.Drawing.Point(34, 532);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(31, 13);
            this.label_2.TabIndex = 19;
            this.label_2.Text = "$2: 0";
            // 
            // label_5
            // 
            this.label_5.AutoSize = true;
            this.label_5.Location = new System.Drawing.Point(34, 548);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(31, 13);
            this.label_5.TabIndex = 20;
            this.label_5.Text = "$5: 0";
            // 
            // label_10
            // 
            this.label_10.AutoSize = true;
            this.label_10.Location = new System.Drawing.Point(34, 565);
            this.label_10.Name = "label_10";
            this.label_10.Size = new System.Drawing.Size(37, 13);
            this.label_10.TabIndex = 21;
            this.label_10.Text = "$10: 0";
            // 
            // label_20
            // 
            this.label_20.AutoSize = true;
            this.label_20.Location = new System.Drawing.Point(34, 583);
            this.label_20.Name = "label_20";
            this.label_20.Size = new System.Drawing.Size(37, 13);
            this.label_20.TabIndex = 22;
            this.label_20.Text = "$20: 0";
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Location = new System.Drawing.Point(28, 486);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(60, 13);
            this.labelCambio.TabIndex = 23;
            this.labelCambio.Text = "Cambio: $0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(146, 493);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(219, 145);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox_1
            // 
            this.pictureBox_1.Location = new System.Drawing.Point(78, 164);
            this.pictureBox_1.Name = "pictureBox_1";
            this.pictureBox_1.Size = new System.Drawing.Size(43, 72);
            this.pictureBox_1.TabIndex = 25;
            this.pictureBox_1.TabStop = false;
            // 
            // pictureBox_2
            // 
            this.pictureBox_2.Location = new System.Drawing.Point(137, 164);
            this.pictureBox_2.Name = "pictureBox_2";
            this.pictureBox_2.Size = new System.Drawing.Size(43, 72);
            this.pictureBox_2.TabIndex = 26;
            this.pictureBox_2.TabStop = false;
            // 
            // pictureBox_3
            // 
            this.pictureBox_3.Location = new System.Drawing.Point(194, 164);
            this.pictureBox_3.Name = "pictureBox_3";
            this.pictureBox_3.Size = new System.Drawing.Size(43, 72);
            this.pictureBox_3.TabIndex = 27;
            this.pictureBox_3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tabla de Premios";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox_3);
            this.Controls.Add(this.pictureBox_2);
            this.Controls.Add(this.pictureBox_1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelCambio);
            this.Controls.Add(this.label_20);
            this.Controls.Add(this.label_10);
            this.Controls.Add(this.label_5);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.buttonDarCambio);
            this.Controls.Add(this.checkBox_5);
            this.Controls.Add(this.checkBox_10);
            this.Controls.Add(this.checkBox_20);
            this.Controls.Add(this.checkBox_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelAgregaC);
            this.Controls.Add(this.labelCreditos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAggCdt);
            this.Controls.Add(this.button_10);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.buttonJugar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_10;
        private System.Windows.Forms.Button buttonAggCdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCreditos;
        private System.Windows.Forms.Label labelAgregaC;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_2;
        private System.Windows.Forms.CheckBox checkBox_20;
        private System.Windows.Forms.CheckBox checkBox_10;
        private System.Windows.Forms.CheckBox checkBox_5;
        private System.Windows.Forms.Button buttonDarCambio;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_5;
        private System.Windows.Forms.Label label_10;
        private System.Windows.Forms.Label label_20;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox_1;
        private System.Windows.Forms.PictureBox pictureBox_2;
        private System.Windows.Forms.PictureBox pictureBox_3;
        private System.Windows.Forms.Label label3;
    }
}

