
namespace FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_
{
    partial class FormHistorialPartida
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
            this.labelHistorialPartida = new System.Windows.Forms.Label();
            this.richTextBoxHistorial = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxLogo.Image = global::FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_.Properties.Resources.ESPADA_LOGO_TRUCO;
            this.pictureBoxLogo.Location = new System.Drawing.Point(666, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(134, 450);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelHistorialPartida
            // 
            this.labelHistorialPartida.AutoSize = true;
            this.labelHistorialPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.labelHistorialPartida.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHistorialPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelHistorialPartida.Location = new System.Drawing.Point(19, 19);
            this.labelHistorialPartida.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labelHistorialPartida.Name = "labelHistorialPartida";
            this.labelHistorialPartida.Size = new System.Drawing.Size(368, 43);
            this.labelHistorialPartida.TabIndex = 3;
            this.labelHistorialPartida.Text = "HISTORIAL PARTIDA.";
            // 
            // richTextBoxHistorial
            // 
            this.richTextBoxHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.richTextBoxHistorial.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.richTextBoxHistorial.Location = new System.Drawing.Point(19, 72);
            this.richTextBoxHistorial.Margin = new System.Windows.Forms.Padding(10);
            this.richTextBoxHistorial.Name = "richTextBoxHistorial";
            this.richTextBoxHistorial.Size = new System.Drawing.Size(634, 359);
            this.richTextBoxHistorial.TabIndex = 4;
            this.richTextBoxHistorial.Text = "";
            // 
            // FormHistorialPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxHistorial);
            this.Controls.Add(this.labelHistorialPartida);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "FormHistorialPartida";
            this.Text = "FormHistorialPartida";
            this.Load += new System.EventHandler(this.FormHistorialPartida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelHistorialPartida;
        private System.Windows.Forms.RichTextBox richTextBoxHistorial;
    }
}