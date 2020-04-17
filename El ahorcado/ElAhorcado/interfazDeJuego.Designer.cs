namespace ElAhorcado
{
    partial class interfazDeJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interfazDeJuego));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelAciertos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFallos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxAhorcado = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelrespuesta = new System.Windows.Forms.Label();
            this.labelIntentosRestantes = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelpistas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPistasDadas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAhorcado)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelAciertos);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // labelAciertos
            // 
            resources.ApplyResources(this.labelAciertos, "labelAciertos");
            this.labelAciertos.Name = "labelAciertos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFallos);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // labelFallos
            // 
            resources.ApplyResources(this.labelFallos, "labelFallos");
            this.labelFallos.Name = "labelFallos";
            this.labelFallos.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBoxAhorcado);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pictureBoxAhorcado
            // 
            this.pictureBoxAhorcado.Image = global::ElAhorcado.Properties.Resources._1;
            resources.ApplyResources(this.pictureBoxAhorcado, "pictureBoxAhorcado");
            this.pictureBoxAhorcado.Name = "pictureBoxAhorcado";
            this.pictureBoxAhorcado.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelrespuesta);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // labelrespuesta
            // 
            resources.ApplyResources(this.labelrespuesta, "labelrespuesta");
            this.labelrespuesta.Name = "labelrespuesta";
            this.labelrespuesta.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelIntentosRestantes
            // 
            resources.ApplyResources(this.labelIntentosRestantes, "labelIntentosRestantes");
            this.labelIntentosRestantes.Name = "labelIntentosRestantes";
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.Hola);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ElAhorcado.Properties.Resources.help;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // labelpistas
            // 
            resources.ApplyResources(this.labelpistas, "labelpistas");
            this.labelpistas.Name = "labelpistas";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Image = global::ElAhorcado.Properties.Resources.pista25;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPistasDadas
            // 
            resources.ApplyResources(this.labelPistasDadas, "labelPistasDadas");
            this.labelPistasDadas.Name = "labelPistasDadas";
            // 
            // interfazDeJuego
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPistasDadas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelpistas);
            this.Controls.Add(this.labelIntentosRestantes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "interfazDeJuego";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.interfazDeJuego_FormClosed);
            this.Load += new System.EventHandler(this.interfazDeJuego_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.interfazBuenaDeJuego_KeyPressed);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAhorcado)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFallos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAciertos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelIntentosRestantes;
        private System.Windows.Forms.PictureBox pictureBoxAhorcado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelrespuesta;
        private System.Windows.Forms.Label labelpistas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPistasDadas;
    }
}