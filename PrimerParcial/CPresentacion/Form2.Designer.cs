namespace CPresentacion
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBEdificio = new System.Windows.Forms.RadioButton();
            this.RBManzana = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbEleg = new System.Windows.Forms.ComboBox();
            this.dgvHabi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbManz = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEdif = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbApart = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(174, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Condominio Marie";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnLeer);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(266, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 298);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Image = global::CPresentacion.Properties.Resources.limpieza;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(21, 212);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 39);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.MistyRose;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Image = global::CPresentacion.Properties.Resources.dejar;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(21, 171);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(111, 35);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.MistyRose;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Image = global::CPresentacion.Properties.Resources.lapiz;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(21, 131);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(111, 34);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.MistyRose;
            this.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeer.Image = global::CPresentacion.Properties.Resources.lista;
            this.btnLeer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeer.Location = new System.Drawing.Point(21, 90);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(111, 35);
            this.btnLeer.TabIndex = 1;
            this.btnLeer.Text = "Actualizar";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MistyRose;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Image = global::CPresentacion.Properties.Resources.garrapata;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(21, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 35);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.RBEdificio);
            this.groupBox2.Controls.Add(this.RBManzana);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.cbEleg);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(440, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 105);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // RBEdificio
            // 
            this.RBEdificio.AutoSize = true;
            this.RBEdificio.BackColor = System.Drawing.Color.MistyRose;
            this.RBEdificio.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBEdificio.Location = new System.Drawing.Point(97, 41);
            this.RBEdificio.Name = "RBEdificio";
            this.RBEdificio.Size = new System.Drawing.Size(75, 20);
            this.RBEdificio.TabIndex = 5;
            this.RBEdificio.TabStop = true;
            this.RBEdificio.Text = "Edificio";
            this.RBEdificio.UseVisualStyleBackColor = false;
            // 
            // RBManzana
            // 
            this.RBManzana.AutoSize = true;
            this.RBManzana.BackColor = System.Drawing.Color.MistyRose;
            this.RBManzana.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBManzana.Location = new System.Drawing.Point(6, 41);
            this.RBManzana.Name = "RBManzana";
            this.RBManzana.Size = new System.Drawing.Size(83, 20);
            this.RBManzana.TabIndex = 4;
            this.RBManzana.TabStop = true;
            this.RBManzana.Text = "Manzana";
            this.RBManzana.UseVisualStyleBackColor = false;
            this.RBManzana.CheckedChanged += new System.EventHandler(this.RBManzana_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Buscar por";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MistyRose;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Image = global::CPresentacion.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(305, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 43);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbEleg
            // 
            this.cbEleg.FormattingEnabled = true;
            this.cbEleg.Location = new System.Drawing.Point(178, 41);
            this.cbEleg.Name = "cbEleg";
            this.cbEleg.Size = new System.Drawing.Size(121, 21);
            this.cbEleg.TabIndex = 1;
            this.cbEleg.SelectedIndexChanged += new System.EventHandler(this.cbEleg_SelectedIndexChanged);
            // 
            // dgvHabi
            // 
            this.dgvHabi.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvHabi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabi.GridColor = System.Drawing.Color.MistyRose;
            this.dgvHabi.Location = new System.Drawing.Point(440, 263);
            this.dgvHabi.Name = "dgvHabi";
            this.dgvHabi.Size = new System.Drawing.Size(367, 298);
            this.dgvHabi.TabIndex = 3;
            this.dgvHabi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 263);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(139, 296);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cedula";
            // 
            // cbManz
            // 
            this.cbManz.FormattingEnabled = true;
            this.cbManz.Location = new System.Drawing.Point(139, 331);
            this.cbManz.Name = "cbManz";
            this.cbManz.Size = new System.Drawing.Size(121, 21);
            this.cbManz.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Manzana";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Edificio";
            // 
            // cbEdif
            // 
            this.cbEdif.FormattingEnabled = true;
            this.cbEdif.Location = new System.Drawing.Point(139, 358);
            this.cbEdif.Name = "cbEdif";
            this.cbEdif.Size = new System.Drawing.Size(121, 21);
            this.cbEdif.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Apartamento";
            // 
            // cbApart
            // 
            this.cbApart.FormattingEnabled = true;
            this.cbApart.Location = new System.Drawing.Point(139, 391);
            this.cbApart.Name = "cbApart";
            this.cbApart.Size = new System.Drawing.Size(121, 21);
            this.cbApart.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem,
            this.siguienteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Image = global::CPresentacion.Properties.Resources.espalda__1_;
            this.atrasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.atrasToolStripMenuItem.Text = "   Inicio";
            this.atrasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // siguienteToolStripMenuItem
            // 
            this.siguienteToolStripMenuItem.Image = global::CPresentacion.Properties.Resources.compartir;
            this.siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            this.siguienteToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.siguienteToolStripMenuItem.Text = "   Configuracion";
            this.siguienteToolStripMenuItem.Click += new System.EventHandler(this.siguienteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = " ";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem4.Text = " ";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem3.Text = " ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = " ";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Image = global::CPresentacion.Properties.Resources.cerrar;
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::CPresentacion.Properties.Resources._2215d0f2abb8701eaed352fb688c2787_fondo_de_vides_flor_roja_by_vexels;
            this.ClientSize = new System.Drawing.Size(823, 573);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbApart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbEdif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbManz);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHabi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habitantes";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHabi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbManz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEdif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbApart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ComboBox cbEleg;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton RBEdificio;
        private System.Windows.Forms.RadioButton RBManzana;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}