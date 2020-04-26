namespace Gestion_Art_Desktop
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
            this.pgbArticulos = new System.Windows.Forms.DataGridView();
            this.picArt = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pgbArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArt)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbArticulos
            // 
            this.pgbArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbArticulos.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.pgbArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pgbArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.pgbArticulos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.pgbArticulos.Location = new System.Drawing.Point(29, 30);
            this.pgbArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgbArticulos.MultiSelect = false;
            this.pgbArticulos.Name = "pgbArticulos";
            this.pgbArticulos.RowHeadersWidth = 51;
            this.pgbArticulos.RowTemplate.Height = 24;
            this.pgbArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pgbArticulos.Size = new System.Drawing.Size(569, 347);
            this.pgbArticulos.TabIndex = 0;
            this.pgbArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pgbArticulos_CellContentClick);
            this.pgbArticulos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pgbArticulos_MouseClick);
            // 
            // picArt
            // 
            this.picArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picArt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picArt.Location = new System.Drawing.Point(640, 30);
            this.picArt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picArt.Name = "picArt";
            this.picArt.Size = new System.Drawing.Size(381, 347);
            this.picArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArt.TabIndex = 1;
            this.picArt.TabStop = false;
            this.picArt.Click += new System.EventHandler(this.ClickArt);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(29, 411);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 55);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 478);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.picArt);
            this.Controls.Add(this.pgbArticulos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(940, 457);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pgbArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pgbArticulos;
        private System.Windows.Forms.PictureBox picArt;
        private System.Windows.Forms.Button btnAgregar;
    }
}

