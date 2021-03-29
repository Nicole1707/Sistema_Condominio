namespace CPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHabi = new System.Windows.Forms.Button();
            this.BtnConfi = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(74, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Condomino Marie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHabi
            // 
            this.btnHabi.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabi.ForeColor = System.Drawing.Color.Firebrick;
            this.btnHabi.Image = global::CPresentacion.Properties.Resources.carrera;
            this.btnHabi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHabi.Location = new System.Drawing.Point(79, 226);
            this.btnHabi.Name = "btnHabi";
            this.btnHabi.Size = new System.Drawing.Size(118, 73);
            this.btnHabi.TabIndex = 2;
            this.btnHabi.Text = "Habitantes";
            this.btnHabi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHabi.UseVisualStyleBackColor = true;
            this.btnHabi.Click += new System.EventHandler(this.btnHabi_Click);
            // 
            // BtnConfi
            // 
            this.BtnConfi.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfi.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnConfi.Image = global::CPresentacion.Properties.Resources.ajustes;
            this.BtnConfi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfi.Location = new System.Drawing.Point(237, 226);
            this.BtnConfi.Name = "BtnConfi";
            this.BtnConfi.Size = new System.Drawing.Size(129, 73);
            this.BtnConfi.TabIndex = 3;
            this.BtnConfi.Text = "Configuracion";
            this.BtnConfi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfi.UseVisualStyleBackColor = true;
            this.BtnConfi.Click += new System.EventHandler(this.BtnConfi_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCerrar.Image = global::CPresentacion.Properties.Resources.cerrar_sesion;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(173, 320);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 53);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar ";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::CPresentacion.Properties.Resources.fondos_flores_png;
            this.ClientSize = new System.Drawing.Size(428, 465);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.BtnConfi);
            this.Controls.Add(this.btnHabi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHabi;
        private System.Windows.Forms.Button BtnConfi;
        private System.Windows.Forms.Button btnCerrar;
    }
}

