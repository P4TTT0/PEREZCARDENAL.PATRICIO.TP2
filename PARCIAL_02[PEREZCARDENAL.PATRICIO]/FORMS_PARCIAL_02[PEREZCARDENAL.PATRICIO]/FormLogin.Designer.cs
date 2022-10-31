
namespace FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    partial class FormLogin
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
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.pictureBoxLineaUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBoxLineaContraseña = new System.Windows.Forms.PictureBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.buttonMostrarContraseña = new System.Windows.Forms.Button();
            this.buttonJugar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelErrorUsuarioInexistente = new System.Windows.Forms.Label();
            this.panelDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLineaUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLineaContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDerecho
            // 
            this.panelDerecho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panelDerecho.Controls.Add(this.labelErrorUsuarioInexistente);
            this.panelDerecho.Controls.Add(this.pictureBox1);
            this.panelDerecho.Controls.Add(this.pictureBoxLogo);
            this.panelDerecho.Location = new System.Drawing.Point(340, 0);
            this.panelDerecho.MinimumSize = new System.Drawing.Size(428, 311);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(478, 436);
            this.panelDerecho.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxLogo.Image = global::FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_.Properties.Resources.ESPADA_LOGO_TRUCO;
            this.pictureBoxLogo.Location = new System.Drawing.Point(333, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(145, 436);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.labelLogin.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelLogin.Location = new System.Drawing.Point(19, 19);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(158, 43);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "SING IN.";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuario.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.textBoxUsuario.Location = new System.Drawing.Point(19, 150);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.PlaceholderText = "Usuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(300, 40);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.labelUsuario.Location = new System.Drawing.Point(10, 86);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(203, 61);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuario.";
            // 
            // pictureBoxLineaUsuario
            // 
            this.pictureBoxLineaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.pictureBoxLineaUsuario.Location = new System.Drawing.Point(19, 196);
            this.pictureBoxLineaUsuario.Name = "pictureBoxLineaUsuario";
            this.pictureBoxLineaUsuario.Size = new System.Drawing.Size(301, 10);
            this.pictureBoxLineaUsuario.TabIndex = 4;
            this.pictureBoxLineaUsuario.TabStop = false;
            // 
            // pictureBoxLineaContraseña
            // 
            this.pictureBoxLineaContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.pictureBoxLineaContraseña.Location = new System.Drawing.Point(19, 329);
            this.pictureBoxLineaContraseña.Name = "pictureBoxLineaContraseña";
            this.pictureBoxLineaContraseña.Size = new System.Drawing.Size(301, 10);
            this.pictureBoxLineaContraseña.TabIndex = 6;
            this.pictureBoxLineaContraseña.TabStop = false;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.textBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContraseña.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.textBoxContraseña.Location = new System.Drawing.Point(19, 283);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PlaceholderText = "Contraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(300, 40);
            this.textBoxContraseña.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(10, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 61);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contraseña.";
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonRegistrarse.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarse.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegistrarse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonRegistrarse.Location = new System.Drawing.Point(19, 355);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(158, 62);
            this.buttonRegistrarse.TabIndex = 10;
            this.buttonRegistrarse.Text = "REGISTRARME";
            this.buttonRegistrarse.UseVisualStyleBackColor = false;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // buttonMostrarContraseña
            // 
            this.buttonMostrarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.buttonMostrarContraseña.FlatAppearance.BorderSize = 0;
            this.buttonMostrarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrarContraseña.Image = global::FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_.Properties.Resources.OJO_SHOWPASSWORD3;
            this.buttonMostrarContraseña.Location = new System.Drawing.Point(263, 283);
            this.buttonMostrarContraseña.Name = "buttonMostrarContraseña";
            this.buttonMostrarContraseña.Size = new System.Drawing.Size(56, 40);
            this.buttonMostrarContraseña.TabIndex = 11;
            this.buttonMostrarContraseña.UseVisualStyleBackColor = false;
            this.buttonMostrarContraseña.Click += new System.EventHandler(this.buttonMostrarContraseña_Click);
            // 
            // buttonJugar
            // 
            this.buttonJugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonJugar.FlatAppearance.BorderSize = 0;
            this.buttonJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJugar.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonJugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonJugar.Location = new System.Drawing.Point(196, 355);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(123, 62);
            this.buttonJugar.TabIndex = 12;
            this.buttonJugar.Text = "JUGAR";
            this.buttonJugar.UseVisualStyleBackColor = false;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_.Properties.Resources.EXCLAMACION_ERROR;
            this.pictureBox1.Location = new System.Drawing.Point(10, 398);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelErrorUsuarioInexistente
            // 
            this.labelErrorUsuarioInexistente.AutoSize = true;
            this.labelErrorUsuarioInexistente.Enabled = false;
            this.labelErrorUsuarioInexistente.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErrorUsuarioInexistente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.labelErrorUsuarioInexistente.Location = new System.Drawing.Point(64, 401);
            this.labelErrorUsuarioInexistente.Name = "labelErrorUsuarioInexistente";
            this.labelErrorUsuarioInexistente.Size = new System.Drawing.Size(229, 26);
            this.labelErrorUsuarioInexistente.TabIndex = 2;
            this.labelErrorUsuarioInexistente.Text = "¡USUARIO INEXISTENTE!";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(813, 436);
            this.Controls.Add(this.buttonJugar);
            this.Controls.Add(this.buttonMostrarContraseña);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxLineaContraseña);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.pictureBoxLineaUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.panelDerecho);
            this.MinimumSize = new System.Drawing.Size(829, 475);
            this.Name = "FormLogin";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelDerecho.ResumeLayout(false);
            this.panelDerecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLineaUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLineaContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.PictureBox pictureBoxLineaUsuario;
        private System.Windows.Forms.PictureBox pictureBoxLineaContraseña;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.Button buttonMostrarContraseña;
        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelErrorUsuarioInexistente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

