
namespace proyecto_noestructurados
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
            this.btn_doble = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_carta = new System.Windows.Forms.Button();
            this.btn_oficio = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_BlancoNegro = new System.Windows.Forms.Button();
            this.btn_ventana = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_doble
            // 
            this.btn_doble.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_doble.ForeColor = System.Drawing.Color.Black;
            this.btn_doble.Location = new System.Drawing.Point(32, 37);
            this.btn_doble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_doble.Name = "btn_doble";
            this.btn_doble.Size = new System.Drawing.Size(100, 28);
            this.btn_doble.TabIndex = 0;
            this.btn_doble.Text = "Doble Carta";
            this.btn_doble.UseVisualStyleBackColor = false;
            this.btn_doble.Click += new System.EventHandler(this.btn_doble_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(318, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "INFORMACION GENERAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(537, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_doble);
            this.groupBox1.Controls.Add(this.btn_carta);
            this.groupBox1.Controls.Add(this.btn_oficio);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Location = new System.Drawing.Point(99, 471);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(315, 129);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Hojas";
            // 
            // btn_carta
            // 
            this.btn_carta.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_carta.ForeColor = System.Drawing.Color.Black;
            this.btn_carta.Location = new System.Drawing.Point(32, 80);
            this.btn_carta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_carta.Name = "btn_carta";
            this.btn_carta.Size = new System.Drawing.Size(100, 28);
            this.btn_carta.TabIndex = 13;
            this.btn_carta.Text = "Carta";
            this.btn_carta.UseVisualStyleBackColor = false;
            this.btn_carta.Click += new System.EventHandler(this.btn_carta_Click);
            // 
            // btn_oficio
            // 
            this.btn_oficio.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_oficio.ForeColor = System.Drawing.Color.Black;
            this.btn_oficio.Location = new System.Drawing.Point(177, 60);
            this.btn_oficio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_oficio.Name = "btn_oficio";
            this.btn_oficio.Size = new System.Drawing.Size(100, 28);
            this.btn_oficio.TabIndex = 14;
            this.btn_oficio.Text = "Oficio";
            this.btn_oficio.UseVisualStyleBackColor = false;
            this.btn_oficio.Click += new System.EventHandler(this.btn_oficio_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_color);
            this.groupBox2.Controls.Add(this.btn_BlancoNegro);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.BurlyWood;
            this.groupBox2.Location = new System.Drawing.Point(599, 471);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(315, 129);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color de impresion";
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_color.ForeColor = System.Drawing.Color.Black;
            this.btn_color.Location = new System.Drawing.Point(185, 60);
            this.btn_color.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(108, 28);
            this.btn_color.TabIndex = 16;
            this.btn_color.Text = "Color";
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_BlancoNegro
            // 
            this.btn_BlancoNegro.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_BlancoNegro.ForeColor = System.Drawing.Color.Black;
            this.btn_BlancoNegro.Location = new System.Drawing.Point(31, 60);
            this.btn_BlancoNegro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BlancoNegro.Name = "btn_BlancoNegro";
            this.btn_BlancoNegro.Size = new System.Drawing.Size(135, 28);
            this.btn_BlancoNegro.TabIndex = 15;
            this.btn_BlancoNegro.Text = "Blanco/Negro";
            this.btn_BlancoNegro.UseVisualStyleBackColor = false;
            this.btn_BlancoNegro.Click += new System.EventHandler(this.btn_BlancoNegro_Click);
            // 
            // btn_ventana
            // 
            this.btn_ventana.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_ventana.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventana.Location = new System.Drawing.Point(411, 633);
            this.btn_ventana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ventana.Name = "btn_ventana";
            this.btn_ventana.Size = new System.Drawing.Size(175, 50);
            this.btn_ventana.TabIndex = 17;
            this.btn_ventana.Text = "Mostrar informacion";
            this.btn_ventana.UseVisualStyleBackColor = false;
            this.btn_ventana.Click += new System.EventHandler(this.btn_ventana_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(41, 89);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(443, 353);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 719);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_ventana);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_doble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_carta;
        private System.Windows.Forms.Button btn_oficio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_BlancoNegro;
        private System.Windows.Forms.Button btn_ventana;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

