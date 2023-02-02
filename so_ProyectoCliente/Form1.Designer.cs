namespace so_ProyectoCliente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.pCargarDatos = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pVerDatos = new System.Windows.Forms.Panel();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pCargarDatos.SuspendLayout();
            this.pVerDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Usuario";
            // 
            // btnConectar
            // 
            this.btnConectar.AutoSize = true;
            this.btnConectar.BackColor = System.Drawing.Color.Navy;
            this.btnConectar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConectar.Location = new System.Drawing.Point(431, 67);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(194, 33);
            this.btnConectar.TabIndex = 21;
            this.btnConectar.Text = "Establecer Conexión";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(154, 33);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Digite su nombre de usuario";
            this.txtUsername.Size = new System.Drawing.Size(230, 30);
            this.txtUsername.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cédula";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(13, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(154, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(13, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(154, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Teléfono";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCedula.Location = new System.Drawing.Point(184, 25);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PlaceholderText = "Digite # Cédula ";
            this.txtCedula.Size = new System.Drawing.Size(188, 34);
            this.txtCedula.TabIndex = 3;
            this.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(184, 163);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Digite su nombre ";
            this.txtNombre.Size = new System.Drawing.Size(188, 34);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTelefono.Location = new System.Drawing.Point(184, 280);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "Digite # teléfono";
            this.txtTelefono.Size = new System.Drawing.Size(188, 34);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.BackColor = System.Drawing.Color.Navy;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(226, 389);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(173, 38);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.AutoSize = true;
            this.btnVerDatos.BackColor = System.Drawing.Color.Navy;
            this.btnVerDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerDatos.ForeColor = System.Drawing.Color.White;
            this.btnVerDatos.Location = new System.Drawing.Point(436, 389);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(136, 38);
            this.btnVerDatos.TabIndex = 7;
            this.btnVerDatos.Text = "Ver Datos";
            this.btnVerDatos.UseVisualStyleBackColor = false;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
            // 
            // pCargarDatos
            // 
            this.pCargarDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pCargarDatos.BackgroundImage")));
            this.pCargarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pCargarDatos.Controls.Add(this.btnEnviar);
            this.pCargarDatos.Controls.Add(this.pVerDatos);
            this.pCargarDatos.Controls.Add(this.btnVerDatos);
            this.pCargarDatos.Controls.Add(this.btnLimpiar);
            this.pCargarDatos.Controls.Add(this.txtTelefono);
            this.pCargarDatos.Controls.Add(this.txtNombre);
            this.pCargarDatos.Controls.Add(this.txtCedula);
            this.pCargarDatos.Controls.Add(this.label4);
            this.pCargarDatos.Controls.Add(this.label3);
            this.pCargarDatos.Controls.Add(this.label2);
            this.pCargarDatos.Location = new System.Drawing.Point(12, 156);
            this.pCargarDatos.Name = "pCargarDatos";
            this.pCargarDatos.Size = new System.Drawing.Size(670, 499);
            this.pCargarDatos.TabIndex = 23;
            // 
            // btnEnviar
            // 
            this.btnEnviar.AutoSize = true;
            this.btnEnviar.BackColor = System.Drawing.Color.Navy;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(13, 389);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(184, 38);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar a Servidor";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // pVerDatos
            // 
            this.pVerDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pVerDatos.BackgroundImage")));
            this.pVerDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pVerDatos.Controls.Add(this.lstDatos);
            this.pVerDatos.Controls.Add(this.button2);
            this.pVerDatos.Location = new System.Drawing.Point(0, 127);
            this.pVerDatos.Name = "pVerDatos";
            this.pVerDatos.Size = new System.Drawing.Size(670, 263);
            this.pVerDatos.TabIndex = 9;
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 20;
            this.lstDatos.Location = new System.Drawing.Point(6, 73);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(641, 144);
            this.lstDatos.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(226, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cargar Datos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::so_ProyectoCliente.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 689);
            this.Controls.Add(this.pCargarDatos);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pCargarDatos.ResumeLayout(false);
            this.pCargarDatos.PerformLayout();
            this.pVerDatos.ResumeLayout(false);
            this.pVerDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVerDatos;
        private System.Windows.Forms.Panel pCargarDatos;
        private System.Windows.Forms.Panel pVerDatos;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEnviar;
    }
}
