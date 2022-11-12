
namespace FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    partial class FormMenuPrincipal
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.buttonCrearSala = new System.Windows.Forms.Button();
            this.buttonHistorial = new System.Windows.Forms.Button();
            this.buttonEstadisticas = new System.Windows.Forms.Button();
            this.buttonJugar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxLogo.Image = global::FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_.Properties.Resources.ESPADA_LOGO_TRUCO;
            this.pictureBoxLogo.Location = new System.Drawing.Point(997, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 636);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelHeader.Controls.Add(this.buttonInicio);
            this.panelHeader.Controls.Add(this.buttonCrearSala);
            this.panelHeader.Controls.Add(this.buttonHistorial);
            this.panelHeader.Controls.Add(this.buttonEstadisticas);
            this.panelHeader.Controls.Add(this.buttonJugar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(997, 80);
            this.panelHeader.TabIndex = 2;
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonInicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicio.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonInicio.Location = new System.Drawing.Point(691, 0);
            this.buttonInicio.Margin = new System.Windows.Forms.Padding(10);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(160, 80);
            this.buttonInicio.TabIndex = 4;
            this.buttonInicio.Text = "INICIO";
            this.buttonInicio.UseVisualStyleBackColor = false;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // buttonCrearSala
            // 
            this.buttonCrearSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonCrearSala.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCrearSala.FlatAppearance.BorderSize = 0;
            this.buttonCrearSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearSala.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCrearSala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonCrearSala.Location = new System.Drawing.Point(531, 0);
            this.buttonCrearSala.Margin = new System.Windows.Forms.Padding(10);
            this.buttonCrearSala.Name = "buttonCrearSala";
            this.buttonCrearSala.Size = new System.Drawing.Size(160, 80);
            this.buttonCrearSala.TabIndex = 3;
            this.buttonCrearSala.Text = "CREAR SALA";
            this.buttonCrearSala.UseVisualStyleBackColor = false;
            this.buttonCrearSala.Click += new System.EventHandler(this.buttonCrearSala_Click);
            // 
            // buttonHistorial
            // 
            this.buttonHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonHistorial.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonHistorial.FlatAppearance.BorderSize = 0;
            this.buttonHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistorial.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonHistorial.Location = new System.Drawing.Point(371, 0);
            this.buttonHistorial.Margin = new System.Windows.Forms.Padding(10);
            this.buttonHistorial.Name = "buttonHistorial";
            this.buttonHistorial.Size = new System.Drawing.Size(160, 80);
            this.buttonHistorial.TabIndex = 2;
            this.buttonHistorial.Text = "HISTORIAL";
            this.buttonHistorial.UseVisualStyleBackColor = false;
            // 
            // buttonEstadisticas
            // 
            this.buttonEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonEstadisticas.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonEstadisticas.FlatAppearance.BorderSize = 0;
            this.buttonEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEstadisticas.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonEstadisticas.Location = new System.Drawing.Point(195, 0);
            this.buttonEstadisticas.Margin = new System.Windows.Forms.Padding(10);
            this.buttonEstadisticas.Name = "buttonEstadisticas";
            this.buttonEstadisticas.Size = new System.Drawing.Size(176, 80);
            this.buttonEstadisticas.TabIndex = 1;
            this.buttonEstadisticas.Text = "ESTADISTICAS";
            this.buttonEstadisticas.UseVisualStyleBackColor = false;
            // 
            // buttonJugar
            // 
            this.buttonJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.buttonJugar.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonJugar.FlatAppearance.BorderSize = 0;
            this.buttonJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJugar.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonJugar.Location = new System.Drawing.Point(0, 0);
            this.buttonJugar.Margin = new System.Windows.Forms.Padding(10);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(195, 80);
            this.buttonJugar.TabIndex = 0;
            this.buttonJugar.Text = "JUGAR";
            this.buttonJugar.UseVisualStyleBackColor = false;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 80);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(997, 556);
            this.panelContenedor.TabIndex = 3;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1097, 636);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.pictureBoxLogo);
            this.MinimumSize = new System.Drawing.Size(1080, 650);
            this.Name = "FormMenuPrincipal";
            this.Text = "MENU PRINCIPAL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonHistorial;
        private System.Windows.Forms.Button buttonEstadisticas;
        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonCrearSala;
    }
}