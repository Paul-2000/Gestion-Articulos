namespace Gestion_Art_Desktop
{
    partial class frmPrincipal
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtGestiondeArticulos = new System.Windows.Forms.Label();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(29, 411);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 55);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtGestiondeArticulos
            // 
            this.txtGestiondeArticulos.AutoSize = true;
            this.txtGestiondeArticulos.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestiondeArticulos.Location = new System.Drawing.Point(336, 9);
            this.txtGestiondeArticulos.Name = "txtGestiondeArticulos";
            this.txtGestiondeArticulos.Size = new System.Drawing.Size(388, 57);
            this.txtGestiondeArticulos.TabIndex = 3;
            this.txtGestiondeArticulos.Text = "Gestión de Artículos";
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListado.Location = new System.Drawing.Point(199, 411);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(164, 55);
            this.btnListado.TabIndex = 4;
            this.btnListado.Text = "&Listado";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.Location = new System.Drawing.Point(369, 411);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModificar.Size = new System.Drawing.Size(164, 55);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 478);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.txtGestiondeArticulos);
            this.Controls.Add(this.btnAgregar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(940, 457);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label txtGestiondeArticulos;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnModificar;
    }
}

