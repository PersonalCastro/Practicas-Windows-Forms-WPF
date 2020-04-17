namespace Los_Primos
{
    partial class UserControl_Shawarma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Shawarma));
            this.label_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Vuelta = new System.Windows.Forms.Button();
            this.button_ternera = new System.Windows.Forms.Button();
            this.button_cordero = new System.Windows.Forms.Button();
            this.button_pollo = new System.Windows.Forms.Button();
            this.info_Tarrina1 = new Los_Primos.Info_Tarrina();
            this.info_Hamburguesa1 = new Los_Primos.Info_Hamburguesa();
            this.info_durum1 = new Los_Primos.Info_durum();
            this.info_shawarma1 = new Los_Primos.Info_shawarma();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("Rubik", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_Title.Location = new System.Drawing.Point(276, 61);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(902, 71);
            this.label_Title.TabIndex = 10;
            this.label_Title.Text = "ESCOGE TU CARNE FAVORITA";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rubik", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(755, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 12;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Vuelta
            // 
            this.button_Vuelta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Vuelta.BackgroundImage")));
            this.button_Vuelta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Vuelta.Location = new System.Drawing.Point(0, 6);
            this.button_Vuelta.Name = "button_Vuelta";
            this.button_Vuelta.Size = new System.Drawing.Size(47, 49);
            this.button_Vuelta.TabIndex = 7;
            this.button_Vuelta.UseVisualStyleBackColor = true;
            this.button_Vuelta.Click += new System.EventHandler(this.button_Vuelta_Click);
            // 
            // button_ternera
            // 
            this.button_ternera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ternera.BackgroundImage")));
            this.button_ternera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ternera.FlatAppearance.BorderSize = 5;
            this.button_ternera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ternera.Font = new System.Drawing.Font("Rubik", 31.8F, System.Drawing.FontStyle.Bold);
            this.button_ternera.ForeColor = System.Drawing.Color.Firebrick;
            this.button_ternera.Location = new System.Drawing.Point(545, 184);
            this.button_ternera.Name = "button_ternera";
            this.button_ternera.Size = new System.Drawing.Size(386, 358);
            this.button_ternera.TabIndex = 3;
            this.button_ternera.Text = "Ternera";
            this.button_ternera.UseVisualStyleBackColor = true;
            this.button_ternera.Click += new System.EventHandler(this.button_ternera_Click);
            // 
            // button_cordero
            // 
            this.button_cordero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_cordero.BackgroundImage")));
            this.button_cordero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cordero.FlatAppearance.BorderSize = 5;
            this.button_cordero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cordero.Font = new System.Drawing.Font("Rubik", 31.8F, System.Drawing.FontStyle.Bold);
            this.button_cordero.ForeColor = System.Drawing.Color.Firebrick;
            this.button_cordero.Location = new System.Drawing.Point(992, 184);
            this.button_cordero.Name = "button_cordero";
            this.button_cordero.Size = new System.Drawing.Size(386, 358);
            this.button_cordero.TabIndex = 2;
            this.button_cordero.Text = "Cordero";
            this.button_cordero.UseVisualStyleBackColor = true;
            this.button_cordero.Click += new System.EventHandler(this.button_cordero_Click);
            // 
            // button_pollo
            // 
            this.button_pollo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_pollo.BackgroundImage")));
            this.button_pollo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_pollo.FlatAppearance.BorderSize = 5;
            this.button_pollo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pollo.Font = new System.Drawing.Font("Rubik", 31.8F, System.Drawing.FontStyle.Bold);
            this.button_pollo.ForeColor = System.Drawing.Color.Firebrick;
            this.button_pollo.Location = new System.Drawing.Point(88, 184);
            this.button_pollo.Name = "button_pollo";
            this.button_pollo.Size = new System.Drawing.Size(386, 358);
            this.button_pollo.TabIndex = 1;
            this.button_pollo.Text = "Pollo";
            this.button_pollo.UseVisualStyleBackColor = true;
            this.button_pollo.Click += new System.EventHandler(this.button2_Click);
            // 
            // info_Tarrina1
            // 
            this.info_Tarrina1.BackColor = System.Drawing.Color.DarkGray;
            this.info_Tarrina1.Location = new System.Drawing.Point(-2, 4);
            this.info_Tarrina1.Name = "info_Tarrina1";
            this.info_Tarrina1.Size = new System.Drawing.Size(1511, 669);
            this.info_Tarrina1.TabIndex = 16;
            this.info_Tarrina1.Load += new System.EventHandler(this.info_Tarrina1_Load);
            this.info_Tarrina1.VisibleChanged += new System.EventHandler(this.info_Tarrina1_VisibleChanged);
            // 
            // info_Hamburguesa1
            // 
            this.info_Hamburguesa1.BackColor = System.Drawing.Color.DarkGray;
            this.info_Hamburguesa1.Location = new System.Drawing.Point(0, 3);
            this.info_Hamburguesa1.Name = "info_Hamburguesa1";
            this.info_Hamburguesa1.Size = new System.Drawing.Size(1511, 669);
            this.info_Hamburguesa1.TabIndex = 15;
            this.info_Hamburguesa1.Load += new System.EventHandler(this.info_Hamburguesa1_Load);
            this.info_Hamburguesa1.VisibleChanged += new System.EventHandler(this.info_Hamburguesa1_VisibleChanged);
            // 
            // info_durum1
            // 
            this.info_durum1.BackColor = System.Drawing.Color.DarkGray;
            this.info_durum1.Location = new System.Drawing.Point(-2, 4);
            this.info_durum1.Name = "info_durum1";
            this.info_durum1.Size = new System.Drawing.Size(1511, 669);
            this.info_durum1.TabIndex = 14;
            this.info_durum1.Load += new System.EventHandler(this.info_durum1_Load);
            this.info_durum1.VisibleChanged += new System.EventHandler(this.info_durum1_VisibleChanged);
            // 
            // info_shawarma1
            // 
            this.info_shawarma1.BackColor = System.Drawing.Color.DarkGray;
            this.info_shawarma1.Location = new System.Drawing.Point(-3, 4);
            this.info_shawarma1.Name = "info_shawarma1";
            this.info_shawarma1.Size = new System.Drawing.Size(1511, 669);
            this.info_shawarma1.TabIndex = 13;
            this.info_shawarma1.Load += new System.EventHandler(this.info_shawarma1_Load);
            this.info_shawarma1.VisibleChanged += new System.EventHandler(this.info_shawarma1_VisibleChanged);
            // 
            // UserControl_Shawarma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.info_Tarrina1);
            this.Controls.Add(this.info_Hamburguesa1);
            this.Controls.Add(this.info_durum1);
            this.Controls.Add(this.info_shawarma1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button_Vuelta);
            this.Controls.Add(this.button_ternera);
            this.Controls.Add(this.button_cordero);
            this.Controls.Add(this.button_pollo);
            this.Name = "UserControl_Shawarma";
            this.Size = new System.Drawing.Size(1511, 709);
            this.Load += new System.EventHandler(this.UserControl_Shawarma_Load);
            this.VisibleChanged += new System.EventHandler(this.UserControl_Shawarma_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_pollo;
        private System.Windows.Forms.Button button_cordero;
        private System.Windows.Forms.Button button_ternera;
        private System.Windows.Forms.Button button_Vuelta;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label1;
        private Info_shawarma info_shawarma1;
        private Info_durum info_durum1;
        private Info_Hamburguesa info_Hamburguesa1;
        private Info_Tarrina info_Tarrina1;
    }
}
