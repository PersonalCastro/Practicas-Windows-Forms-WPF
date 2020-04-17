namespace Los_Primos
{
    partial class Info_durum
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_durum));
            this.label_precio = new System.Windows.Forms.Label();
            this.button_addToCart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button_grand = new System.Windows.Forms.Button();
            this.button_medi = new System.Windows.Forms.Button();
            this.button_peque = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Vuelta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.n_pedidos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_precio.ForeColor = System.Drawing.Color.Firebrick;
            this.label_precio.Location = new System.Drawing.Point(1144, 467);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(303, 23);
            this.label_precio.TabIndex = 23;
            this.label_precio.Text = "Precio: (Selecciona el tamaño)";
            this.label_precio.Click += new System.EventHandler(this.label_precio_Click);
            // 
            // button_addToCart
            // 
            this.button_addToCart.BackColor = System.Drawing.Color.Gold;
            this.button_addToCart.FlatAppearance.BorderSize = 5;
            this.button_addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addToCart.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addToCart.ForeColor = System.Drawing.Color.Firebrick;
            this.button_addToCart.Location = new System.Drawing.Point(1078, 513);
            this.button_addToCart.Name = "button_addToCart";
            this.button_addToCart.Size = new System.Drawing.Size(286, 108);
            this.button_addToCart.TabIndex = 22;
            this.button_addToCart.Text = "AÑADIR";
            this.button_addToCart.UseVisualStyleBackColor = false;
            this.button_addToCart.Click += new System.EventHandler(this.button_addToCart_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_grand);
            this.panel1.Controls.Add(this.button_medi);
            this.panel1.Controls.Add(this.button_peque);
            this.panel1.Location = new System.Drawing.Point(1078, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 366);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(102, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "TAMAÑO DEL DÜRÜM";
            // 
            // button_grand
            // 
            this.button_grand.BackColor = System.Drawing.Color.Gold;
            this.button_grand.FlatAppearance.BorderSize = 5;
            this.button_grand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_grand.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_grand.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_grand.Location = new System.Drawing.Point(13, 223);
            this.button_grand.Name = "button_grand";
            this.button_grand.Size = new System.Drawing.Size(196, 119);
            this.button_grand.TabIndex = 19;
            this.button_grand.Text = "Grande";
            this.button_grand.UseVisualStyleBackColor = false;
            this.button_grand.Click += new System.EventHandler(this.button_grand_Click);
            // 
            // button_medi
            // 
            this.button_medi.BackColor = System.Drawing.Color.Gold;
            this.button_medi.FlatAppearance.BorderSize = 5;
            this.button_medi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_medi.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_medi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_medi.Location = new System.Drawing.Point(215, 166);
            this.button_medi.Name = "button_medi";
            this.button_medi.Size = new System.Drawing.Size(153, 85);
            this.button_medi.TabIndex = 18;
            this.button_medi.Text = "Mediano";
            this.button_medi.UseVisualStyleBackColor = false;
            this.button_medi.Click += new System.EventHandler(this.button_medi_Click);
            // 
            // button_peque
            // 
            this.button_peque.BackColor = System.Drawing.Color.Gold;
            this.button_peque.FlatAppearance.BorderSize = 5;
            this.button_peque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_peque.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_peque.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_peque.Location = new System.Drawing.Point(79, 114);
            this.button_peque.Name = "button_peque";
            this.button_peque.Size = new System.Drawing.Size(130, 76);
            this.button_peque.TabIndex = 17;
            this.button_peque.Text = "Pequeño";
            this.button_peque.UseVisualStyleBackColor = false;
            this.button_peque.Click += new System.EventHandler(this.button_peque_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Rubik", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(653, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 342);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredientes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.Firebrick;
            this.checkBox5.Location = new System.Drawing.Point(80, 72);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(88, 28);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Carne";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.Firebrick;
            this.checkBox4.Location = new System.Drawing.Point(186, 218);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(75, 28);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Maíz";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.Firebrick;
            this.checkBox3.Location = new System.Drawing.Point(80, 162);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(102, 28);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Tomate";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.checkBox2.Location = new System.Drawing.Point(80, 274);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(150, 28);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Salsa Yogurt";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.checkBox1.Location = new System.Drawing.Point(186, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 28);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Lechuga";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 12.8F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(48, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(904, 54);
            this.label1.TabIndex = 19;
            this.label1.Text = "Modo de presentar el döner enrollado en un pan plano, muy empleado en la cocina t" +
    "urca.\r\nPara su elaboración pueden emplearse dos tipos de pan plano: yufka y lava" +
    "sh.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("Rubik", 40F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_Title.Location = new System.Drawing.Point(421, 56);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(283, 80);
            this.label_Title.TabIndex = 18;
            this.label_Title.Text = "DÜRÜM";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Title.Click += new System.EventHandler(this.label_Title_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 377);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_Vuelta
            // 
            this.button_Vuelta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Vuelta.BackgroundImage")));
            this.button_Vuelta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Vuelta.Location = new System.Drawing.Point(3, 3);
            this.button_Vuelta.Name = "button_Vuelta";
            this.button_Vuelta.Size = new System.Drawing.Size(47, 49);
            this.button_Vuelta.TabIndex = 24;
            this.button_Vuelta.UseVisualStyleBackColor = true;
            this.button_Vuelta.Click += new System.EventHandler(this.button_Vuelta_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(1395, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 27;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(1395, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 40);
            this.button2.TabIndex = 28;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // n_pedidos
            // 
            this.n_pedidos.AutoSize = true;
            this.n_pedidos.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Bold);
            this.n_pedidos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.n_pedidos.Location = new System.Drawing.Point(1406, 558);
            this.n_pedidos.Name = "n_pedidos";
            this.n_pedidos.Size = new System.Drawing.Size(18, 20);
            this.n_pedidos.TabIndex = 0;
            this.n_pedidos.Text = "1";
            this.n_pedidos.Click += new System.EventHandler(this.label2_Click);
            // 
            // Info_durum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.n_pedidos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Vuelta);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.button_addToCart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Title);
            this.Name = "Info_durum";
            this.Size = new System.Drawing.Size(1511, 669);
            this.Load += new System.EventHandler(this.Info_durum_Load);
            this.VisibleChanged += new System.EventHandler(this.Info_durum_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Vuelta;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.Button button_addToCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_grand;
        private System.Windows.Forms.Button button_medi;
        private System.Windows.Forms.Button button_peque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label n_pedidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
