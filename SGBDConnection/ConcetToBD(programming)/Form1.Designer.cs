namespace ConcetToBD_programming_
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
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido1 = new System.Windows.Forms.TextBox();
            this.textBoxApellido2 = new System.Windows.Forms.TextBox();
            this.textBoxPsswrd = new System.Windows.Forms.TextBox();
            this.textBoxFoto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxQuery = new System.Windows.Forms.ComboBox();
            this.labelQuery = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRestartComboBoxQuery = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(256, 216);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(743, 333);
            this.dataGridViewData.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(382, 67);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(213, 22);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellido1
            // 
            this.textBoxApellido1.Location = new System.Drawing.Point(382, 115);
            this.textBoxApellido1.Name = "textBoxApellido1";
            this.textBoxApellido1.Size = new System.Drawing.Size(213, 22);
            this.textBoxApellido1.TabIndex = 2;
            // 
            // textBoxApellido2
            // 
            this.textBoxApellido2.Location = new System.Drawing.Point(382, 166);
            this.textBoxApellido2.Name = "textBoxApellido2";
            this.textBoxApellido2.Size = new System.Drawing.Size(213, 22);
            this.textBoxApellido2.TabIndex = 3;
            // 
            // textBoxPsswrd
            // 
            this.textBoxPsswrd.Location = new System.Drawing.Point(701, 67);
            this.textBoxPsswrd.Name = "textBoxPsswrd";
            this.textBoxPsswrd.Size = new System.Drawing.Size(213, 22);
            this.textBoxPsswrd.TabIndex = 4;
            // 
            // textBoxFoto
            // 
            this.textBoxFoto.Location = new System.Drawing.Point(701, 116);
            this.textBoxFoto.Name = "textBoxFoto";
            this.textBoxFoto.Size = new System.Drawing.Size(213, 22);
            this.textBoxFoto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Primer apellido :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Segundo apellido :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contraseña :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Foto :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(635, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estado :";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "Desconectado",
            "Conectado"});
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(702, 168);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(212, 24);
            this.comboBoxEstado.TabIndex = 14;
            // 
            // comboBoxQuery
            // 
            this.comboBoxQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuery.FormattingEnabled = true;
            this.comboBoxQuery.Location = new System.Drawing.Point(78, 360);
            this.comboBoxQuery.Name = "comboBoxQuery";
            this.comboBoxQuery.Size = new System.Drawing.Size(121, 24);
            this.comboBoxQuery.TabIndex = 15;
            // 
            // labelQuery
            // 
            this.labelQuery.AutoSize = true;
            this.labelQuery.Location = new System.Drawing.Point(18, 363);
            this.labelQuery.Name = "labelQuery";
            this.labelQuery.Size = new System.Drawing.Size(55, 17);
            this.labelQuery.TabIndex = 16;
            this.labelQuery.Text = "Query :";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(101, 400);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Image = global::ConcetToBD_programming_.Properties.Resources.add_user_male_40px;
            this.buttonAddUser.Location = new System.Drawing.Point(939, 72);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(62, 63);
            this.buttonAddUser.TabIndex = 20;
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ConcetToBD_programming_.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(45, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRestartComboBoxQuery
            // 
            this.buttonRestartComboBoxQuery.Image = global::ConcetToBD_programming_.Properties.Resources.restart_30;
            this.buttonRestartComboBoxQuery.Location = new System.Drawing.Point(206, 353);
            this.buttonRestartComboBoxQuery.Name = "buttonRestartComboBoxQuery";
            this.buttonRestartComboBoxQuery.Size = new System.Drawing.Size(44, 42);
            this.buttonRestartComboBoxQuery.TabIndex = 21;
            this.buttonRestartComboBoxQuery.UseVisualStyleBackColor = true;
            this.buttonRestartComboBoxQuery.Click += new System.EventHandler(this.buttonRestartComboBoxQuery_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(310, 23);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(65, 17);
            this.labelUser.TabIndex = 22;
            this.labelUser.Text = "Usuario :";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(382, 21);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(150, 22);
            this.textBoxUser.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 567);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonRestartComboBoxQuery);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelQuery);
            this.Controls.Add(this.comboBoxQuery);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFoto);
            this.Controls.Add(this.textBoxPsswrd);
            this.Controls.Add(this.textBoxApellido2);
            this.Controls.Add(this.textBoxApellido1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.dataGridViewData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido1;
        private System.Windows.Forms.TextBox textBoxApellido2;
        private System.Windows.Forms.TextBox textBoxPsswrd;
        private System.Windows.Forms.TextBox textBoxFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxQuery;
        private System.Windows.Forms.Label labelQuery;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonRestartComboBoxQuery;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUser;
    }
}

