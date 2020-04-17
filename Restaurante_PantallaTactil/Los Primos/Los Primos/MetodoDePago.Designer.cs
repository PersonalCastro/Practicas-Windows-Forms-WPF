namespace Los_Primos
{
    partial class MetodoDePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetodoDePago));
            this.label_Title = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Vuelta = new System.Windows.Forms.Button();
            this.userControl11 = new Los_Primos.UserControl1();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("Rubik", 40F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_Title.Location = new System.Drawing.Point(419, 74);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(623, 80);
            this.label_Title.TabIndex = 12;
            this.label_Title.Text = "MÉTODO DE PAGO";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rubik", 32F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(862, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(475, 400);
            this.button2.TabIndex = 11;
            this.button2.Text = "Pago en caja";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rubik", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(174, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(483, 400);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pago con tarjeta";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Vuelta
            // 
            this.button_Vuelta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Vuelta.BackgroundImage")));
            this.button_Vuelta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Vuelta.Location = new System.Drawing.Point(3, 3);
            this.button_Vuelta.Name = "button_Vuelta";
            this.button_Vuelta.Size = new System.Drawing.Size(47, 49);
            this.button_Vuelta.TabIndex = 26;
            this.button_Vuelta.UseVisualStyleBackColor = true;
            this.button_Vuelta.Click += new System.EventHandler(this.button_Vuelta_Click);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Gold;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1511, 669);
            this.userControl11.TabIndex = 27;
            // 
            // MetodoDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button_Vuelta);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MetodoDePago";
            this.Size = new System.Drawing.Size(1511, 669);
            this.Load += new System.EventHandler(this.MetodoDePago_Load);
            this.VisibleChanged += new System.EventHandler(this.MetodoDePago_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Vuelta;
        private UserControl1 userControl11;
    }
}
