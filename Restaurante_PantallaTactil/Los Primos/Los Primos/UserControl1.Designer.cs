namespace Los_Primos
{
    partial class UserControl1
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("Rubik", 40F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_Title.Location = new System.Drawing.Point(161, 71);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(1053, 160);
            this.label_Title.TabIndex = 13;
            this.label_Title.Text = "   SU PEDIDO HA SIDO \r\nEFECTUADO CORRECTAMENTE";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Title.Click += new System.EventHandler(this.label_Title_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 24.8F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(314, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 50);
            this.label1.TabIndex = 20;
            this.label1.Text = "Label";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Title);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1511, 669);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.VisibleChanged += new System.EventHandler(this.UserControl1_VisibleChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserControl1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label1;
    }
}
