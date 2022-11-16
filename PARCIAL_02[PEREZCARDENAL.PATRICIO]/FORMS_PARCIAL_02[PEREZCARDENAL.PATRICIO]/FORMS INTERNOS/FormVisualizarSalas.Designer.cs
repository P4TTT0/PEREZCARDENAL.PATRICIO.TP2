
namespace FORMS_PARCIAL_02_PEREZCARDENAL.PATRICIO_.FORMS_INTERNOS
{
    partial class FormVisualizarSalas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelCrearSala = new System.Windows.Forms.Label();
            this.dataGridViewSalas = new System.Windows.Forms.DataGridView();
            this.buttonJugar = new System.Windows.Forms.Button();
            this.buttonVerTodas = new System.Windows.Forms.Button();
            this.buttonVerEnJuego = new System.Windows.Forms.Button();
            this.buttonVerHistorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalas)).BeginInit();
            this.SuspendLayout();
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
            this.labelCrearSala.Size = new System.Drawing.Size(138, 43);
            this.labelCrearSala.TabIndex = 3;
            this.labelCrearSala.Text = "SALAS.";
            // 
            // dataGridViewSalas
            // 
            this.dataGridViewSalas.AllowUserToAddRows = false;
            this.dataGridViewSalas.AllowUserToDeleteRows = false;
            this.dataGridViewSalas.AllowUserToResizeColumns = false;
            this.dataGridViewSalas.AllowUserToResizeRows = false;
            this.dataGridViewSalas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dataGridViewSalas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSalas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSalas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSalas.ColumnHeadersHeight = 30;
            this.dataGridViewSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSalas.EnableHeadersVisualStyles = false;
            this.dataGridViewSalas.Location = new System.Drawing.Point(20, 72);
            this.dataGridViewSalas.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewSalas.Name = "dataGridViewSalas";
            this.dataGridViewSalas.ReadOnly = true;
            this.dataGridViewSalas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSalas.RowHeadersVisible = false;
            this.dataGridViewSalas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dataGridViewSalas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSalas.RowTemplate.Height = 25;
            this.dataGridViewSalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalas.Size = new System.Drawing.Size(1078, 489);
            this.dataGridViewSalas.TabIndex = 4;
            this.dataGridViewSalas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSalas_CellClick);
            // 
            // buttonJugar
            // 
            this.buttonJugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonJugar.FlatAppearance.BorderSize = 0;
            this.buttonJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJugar.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonJugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonJugar.Location = new System.Drawing.Point(826, 574);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(271, 62);
            this.buttonJugar.TabIndex = 13;
            this.buttonJugar.Text = "JUGAR";
            this.buttonJugar.UseVisualStyleBackColor = false;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // buttonVerTodas
            // 
            this.buttonVerTodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonVerTodas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonVerTodas.FlatAppearance.BorderSize = 0;
            this.buttonVerTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerTodas.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVerTodas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonVerTodas.Location = new System.Drawing.Point(19, 574);
            this.buttonVerTodas.Name = "buttonVerTodas";
            this.buttonVerTodas.Size = new System.Drawing.Size(202, 62);
            this.buttonVerTodas.TabIndex = 14;
            this.buttonVerTodas.Text = "VER TODAS";
            this.buttonVerTodas.UseVisualStyleBackColor = false;
            this.buttonVerTodas.Click += new System.EventHandler(this.buttonVerTodas_Click);
            // 
            // buttonVerEnJuego
            // 
            this.buttonVerEnJuego.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonVerEnJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonVerEnJuego.FlatAppearance.BorderSize = 0;
            this.buttonVerEnJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerEnJuego.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVerEnJuego.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonVerEnJuego.Location = new System.Drawing.Point(227, 574);
            this.buttonVerEnJuego.Name = "buttonVerEnJuego";
            this.buttonVerEnJuego.Size = new System.Drawing.Size(202, 62);
            this.buttonVerEnJuego.TabIndex = 15;
            this.buttonVerEnJuego.Text = "VER SIN COMENZAR";
            this.buttonVerEnJuego.UseVisualStyleBackColor = false;
            this.buttonVerEnJuego.Click += new System.EventHandler(this.buttonVerEnJuego_Click);
            // 
            // buttonVerHistorial
            // 
            this.buttonVerHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonVerHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonVerHistorial.FlatAppearance.BorderSize = 0;
            this.buttonVerHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerHistorial.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVerHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonVerHistorial.Location = new System.Drawing.Point(435, 574);
            this.buttonVerHistorial.Name = "buttonVerHistorial";
            this.buttonVerHistorial.Size = new System.Drawing.Size(202, 62);
            this.buttonVerHistorial.TabIndex = 16;
            this.buttonVerHistorial.Text = "VER HISTORIAL";
            this.buttonVerHistorial.UseVisualStyleBackColor = false;
            this.buttonVerHistorial.Click += new System.EventHandler(this.buttonVerHistorial_Click);
            // 
            // FormVisualizarSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1116, 648);
            this.Controls.Add(this.buttonVerHistorial);
            this.Controls.Add(this.buttonVerEnJuego);
            this.Controls.Add(this.buttonVerTodas);
            this.Controls.Add(this.buttonJugar);
            this.Controls.Add(this.dataGridViewSalas);
            this.Controls.Add(this.labelCrearSala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVisualizarSalas";
            this.Text = "VISUALIZAR SALAS";
            this.Load += new System.EventHandler(this.FormVisualizarSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCrearSala;
        private System.Windows.Forms.DataGridView dataGridViewSalas;
        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.Button buttonVerTodas;
        private System.Windows.Forms.Button buttonVerEnJuego;
        private System.Windows.Forms.Button buttonVerHistorial;
    }
}