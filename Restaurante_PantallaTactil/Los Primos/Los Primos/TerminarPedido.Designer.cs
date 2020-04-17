namespace Los_Primos
{
    partial class TerminarPedido
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminarPedido));
            this.label_Title = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button_Vuelta = new System.Windows.Forms.Button();
            this.button_addToCart = new System.Windows.Forms.Button();
            this.label_precio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.metodoDePago1 = new Los_Primos.MetodoDePago();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("Rubik", 40F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_Title.Location = new System.Drawing.Point(342, 91);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(832, 80);
            this.label_Title.TabIndex = 13;
            this.label_Title.Text = "RESUMEN DE MI PEDIDO";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(96, 214);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(944, 414);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // button_addToCart
            // 
            this.button_addToCart.BackColor = System.Drawing.Color.Gold;
            this.button_addToCart.FlatAppearance.BorderSize = 5;
            this.button_addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addToCart.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addToCart.ForeColor = System.Drawing.Color.Firebrick;
            this.button_addToCart.Location = new System.Drawing.Point(1104, 519);
            this.button_addToCart.Name = "button_addToCart";
            this.button_addToCart.Size = new System.Drawing.Size(299, 109);
            this.button_addToCart.TabIndex = 28;
            this.button_addToCart.Text = "ELEGIR METODO\r\nDE PAGO";
            this.button_addToCart.UseVisualStyleBackColor = false;
            this.button_addToCart.Click += new System.EventHandler(this.button_addToCart_Click);
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Font = new System.Drawing.Font("Rubik", 14.8F, System.Drawing.FontStyle.Bold);
            this.label_precio.ForeColor = System.Drawing.Color.Firebrick;
            this.label_precio.Location = new System.Drawing.Point(1162, 456);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(188, 29);
            this.label_precio.TabIndex = 29;
            this.label_precio.Text = "Precio final : 0";
            this.label_precio.Click += new System.EventHandler(this.label_precio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(1058, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 46);
            this.label1.TabIndex = 30;
            this.label1.Text = "         Si desea eliminar algún producto\r\nseleccio su imagen y pulse en la papel" +
    "era";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1212, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 73);
            this.button1.TabIndex = 31;
            this.toolTip1.SetToolTip(this.button1, "Eliminar producto");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // metodoDePago1
            // 
            this.metodoDePago1.BackColor = System.Drawing.Color.Gold;
            this.metodoDePago1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metodoDePago1.Location = new System.Drawing.Point(0, 0);
            this.metodoDePago1.Name = "metodoDePago1";
            this.metodoDePago1.Size = new System.Drawing.Size(1511, 669);
            this.metodoDePago1.TabIndex = 32;
            this.metodoDePago1.Load += new System.EventHandler(this.metodoDePago1_Load);
            this.metodoDePago1.VisibleChanged += new System.EventHandler(this.metodoDePago1_VisibleChanged);
            // 
            // TerminarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metodoDePago1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.button_addToCart);
            this.Controls.Add(this.button_Vuelta);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_Title);
            this.Name = "TerminarPedido";
            this.Size = new System.Drawing.Size(1511, 669);
            this.Load += new System.EventHandler(this.TerminarPedido_Load);
            this.VisibleChanged += new System.EventHandler(this.TerminarPedido_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_Vuelta;
        private System.Windows.Forms.Button button_addToCart;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private MetodoDePago metodoDePago1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
