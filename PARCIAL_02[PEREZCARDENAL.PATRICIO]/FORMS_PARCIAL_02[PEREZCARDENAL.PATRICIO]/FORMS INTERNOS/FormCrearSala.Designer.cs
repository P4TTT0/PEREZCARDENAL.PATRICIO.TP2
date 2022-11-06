
namespace FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_.FORMS_INTERNOS
{
    partial class FormCrearSala
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelCrearSala = new System.Windows.Forms.Label();
            this.comboBoxCantidadJugadores = new System.Windows.Forms.ComboBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.buttonCrearSala = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxLogo.Image = global::FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_.Properties.Resources.ESPADA_LOGO_TRUCO;
            this.pictureBoxLogo.Location = new System.Drawing.Point(522, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(134, 332);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelCrearSala
            // 
            this.labelCrearSala.AutoSize = true;
            this.labelCrearSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.labelCrearSala.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCrearSala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelCrearSala.Location = new System.Drawing.Point(19, 19);
            this.labelCrearSala.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labelCrearSala.Name = "labelCrearSala";
            this.labelCrearSala.Size = new System.Drawing.Size(242, 43);
            this.labelCrearSala.TabIndex = 2;
            this.labelCrearSala.Text = "CREAR SALA.";
            // 
            // comboBoxCantidadJugadores
            // 
            this.comboBoxCantidadJugadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.comboBoxCantidadJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCantidadJugadores.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCantidadJugadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.comboBoxCantidadJugadores.FormattingEnabled = true;
            this.comboBoxCantidadJugadores.Location = new System.Drawing.Point(19, 136);
            this.comboBoxCantidadJugadores.Name = "comboBoxCantidadJugadores";
            this.comboBoxCantidadJugadores.Size = new System.Drawing.Size(458, 89);
            this.comboBoxCantidadJugadores.TabIndex = 3;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.labelUsuario.Location = new System.Drawing.Point(19, 72);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(458, 61);
            this.labelUsuario.TabIndex = 4;
            this.labelUsuario.Text = "Cantidad jugadores:";
            // 
            // buttonCrearSala
            // 
            this.buttonCrearSala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrearSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonCrearSala.FlatAppearance.BorderSize = 0;
            this.buttonCrearSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearSala.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCrearSala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonCrearSala.Location = new System.Drawing.Point(235, 253);
            this.buttonCrearSala.Name = "buttonCrearSala";
            this.buttonCrearSala.Size = new System.Drawing.Size(242, 62);
            this.buttonCrearSala.TabIndex = 13;
            this.buttonCrearSala.Text = "CREAR";
            this.buttonCrearSala.UseVisualStyleBackColor = false;
            this.buttonCrearSala.Click += new System.EventHandler(this.buttonCrearSala_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonCancelar.Location = new System.Drawing.Point(19, 253);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(197, 62);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormCrearSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 332);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCrearSala);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.comboBoxCantidadJugadores);
            this.Controls.Add(this.labelCrearSala);
            this.Controls.Add(this.pictureBoxLogo);
            this.MinimumSize = new System.Drawing.Size(672, 371);
            this.Name = "FormCrearSala";
            this.Text = "CREAR SALA";
            this.Load += new System.EventHandler(this.FormCrearSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelCrearSala;
        private System.Windows.Forms.ComboBox comboBoxCantidadJugadores;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button buttonCrearSala;
        private System.Windows.Forms.Button buttonCancelar;
    }
}