namespace CPresentacion
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditM = new System.Windows.Forms.Button();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.dgvMan = new System.Windows.Forms.DataGridView();
            this.txtMan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditE = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvEdi = new System.Windows.Forms.DataGridView();
            this.txtEdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEditA = new System.Windows.Forms.Button();
            this.btnAgregar3 = new System.Windows.Forms.Button();
            this.txtApa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvApa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMan)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdi)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(139, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Condominio Marie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(205, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestionar condominio";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.habitantesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Image = global::CPresentacion.Properties.Resources.espalda__1_;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // habitantesToolStripMenuItem
            // 
            this.habitantesToolStripMenuItem.Image = global::CPresentacion.Properties.Resources.compartir;
            this.habitantesToolStripMenuItem.Name = "habitantesToolStripMenuItem";
            this.habitantesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.habitantesToolStripMenuItem.Text = "Habitantes";
            this.habitantesToolStripMenuItem.Click += new System.EventHandler(this.habitantesToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnEditM);
            this.groupBox2.Controls.Add(this.btnAgregar2);
            this.groupBox2.Controls.Add(this.dgvMan);
            this.groupBox2.Controls.Add(this.txtMan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(267, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 219);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manzanas";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnEditM
            // 
            this.btnEditM.BackColor = System.Drawing.Color.MistyRose;
            this.btnEditM.Image = global::CPresentacion.Properties.Resources.lapiz;
            this.btnEditM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditM.Location = new System.Drawing.Point(138, 178);
            this.btnEditM.Name = "btnEditM";
            this.btnEditM.Size = new System.Drawing.Size(86, 34);
            this.btnEditM.TabIndex = 16;
            this.btnEditM.Text = "Editar";
            this.btnEditM.UseVisualStyleBackColor = false;
            this.btnEditM.Click += new System.EventHandler(this.btnEditM_Click);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.BackColor = System.Drawing.Color.MistyRose;
            this.btnAgregar2.Image = global::CPresentacion.Properties.Resources.garrapata;
            this.btnAgregar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar2.Location = new System.Drawing.Point(6, 178);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(111, 35);
            this.btnAgregar2.TabIndex = 14;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = false;
            this.btnAgregar2.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvMan
            // 
            this.dgvMan.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvMan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMan.GridColor = System.Drawing.Color.MistyRose;
            this.dgvMan.Location = new System.Drawing.Point(13, 64);
            this.dgvMan.Name = "dgvMan";
            this.dgvMan.Size = new System.Drawing.Size(201, 108);
            this.dgvMan.TabIndex = 10;
            // 
            // txtMan
            // 
            this.txtMan.Location = new System.Drawing.Point(107, 22);
            this.txtMan.Name = "txtMan";
            this.txtMan.Size = new System.Drawing.Size(100, 20);
            this.txtMan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Manzana";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnEditE);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.dgvEdi);
            this.groupBox3.Controls.Add(this.txtEdi);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox3.Location = new System.Drawing.Point(25, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 219);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edificios";
            // 
            // btnEditE
            // 
            this.btnEditE.BackColor = System.Drawing.Color.MistyRose;
            this.btnEditE.Image = global::CPresentacion.Properties.Resources.lapiz;
            this.btnEditE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditE.Location = new System.Drawing.Point(142, 178);
            this.btnEditE.Name = "btnEditE";
            this.btnEditE.Size = new System.Drawing.Size(88, 34);
            this.btnEditE.TabIndex = 13;
            this.btnEditE.Text = "Editar";
            this.btnEditE.UseVisualStyleBackColor = false;
            this.btnEditE.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MistyRose;
            this.btnAgregar.Image = global::CPresentacion.Properties.Resources.garrapata;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(6, 178);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 35);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // dgvEdi
            // 
            this.dgvEdi.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvEdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdi.GridColor = System.Drawing.Color.MistyRose;
            this.dgvEdi.Location = new System.Drawing.Point(18, 64);
            this.dgvEdi.Name = "dgvEdi";
            this.dgvEdi.Size = new System.Drawing.Size(201, 108);
            this.dgvEdi.TabIndex = 11;
            // 
            // txtEdi
            // 
            this.txtEdi.Location = new System.Drawing.Point(124, 29);
            this.txtEdi.Name = "txtEdi";
            this.txtEdi.Size = new System.Drawing.Size(84, 20);
            this.txtEdi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edificio";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnEditA);
            this.groupBox4.Controls.Add(this.btnAgregar3);
            this.groupBox4.Controls.Add(this.txtApa);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dgvApa);
            this.groupBox4.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox4.Location = new System.Drawing.Point(509, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 219);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Apartamentos";
            // 
            // btnEditA
            // 
            this.btnEditA.BackColor = System.Drawing.Color.MistyRose;
            this.btnEditA.Image = global::CPresentacion.Properties.Resources.lapiz;
            this.btnEditA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditA.Location = new System.Drawing.Point(135, 184);
            this.btnEditA.Name = "btnEditA";
            this.btnEditA.Size = new System.Drawing.Size(94, 34);
            this.btnEditA.TabIndex = 17;
            this.btnEditA.Text = "Editar";
            this.btnEditA.UseVisualStyleBackColor = false;
            this.btnEditA.Click += new System.EventHandler(this.btnEditA_Click);
            // 
            // btnAgregar3
            // 
            this.btnAgregar3.BackColor = System.Drawing.Color.MistyRose;
            this.btnAgregar3.Image = global::CPresentacion.Properties.Resources.garrapata;
            this.btnAgregar3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar3.Location = new System.Drawing.Point(18, 184);
            this.btnAgregar3.Name = "btnAgregar3";
            this.btnAgregar3.Size = new System.Drawing.Size(111, 35);
            this.btnAgregar3.TabIndex = 16;
            this.btnAgregar3.Text = "Agregar";
            this.btnAgregar3.UseVisualStyleBackColor = false;
            this.btnAgregar3.Click += new System.EventHandler(this.btnAgregar3_Click);
            // 
            // txtApa
            // 
            this.txtApa.Location = new System.Drawing.Point(119, 15);
            this.txtApa.Name = "txtApa";
            this.txtApa.Size = new System.Drawing.Size(100, 20);
            this.txtApa.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Apartamento";
            // 
            // dgvApa
            // 
            this.dgvApa.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvApa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApa.GridColor = System.Drawing.Color.MistyRose;
            this.dgvApa.Location = new System.Drawing.Point(18, 64);
            this.dgvApa.Name = "dgvApa";
            this.dgvApa.Size = new System.Drawing.Size(201, 108);
            this.dgvApa.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnLeer);
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(540, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 62);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Image = global::CPresentacion.Properties.Resources.limpieza;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(116, 23);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 39);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.MistyRose;
            this.btnLeer.Image = global::CPresentacion.Properties.Resources.lista;
            this.btnLeer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeer.Location = new System.Drawing.Point(13, 23);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(97, 35);
            this.btnLeer.TabIndex = 1;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::CPresentacion.Properties.Resources._7b3a411680aa6ce8263c9f0e2946a347_fondo_de_vides_de_flor_de_naranja_by_vexels;
            this.ClientSize = new System.Drawing.Size(766, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitantesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvEdi;
        private System.Windows.Forms.TextBox txtEdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvApa;
        private System.Windows.Forms.TextBox txtApa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditM;
        private System.Windows.Forms.Button btnEditE;
        private System.Windows.Forms.Button btnEditA;
        private System.Windows.Forms.Button btnAgregar3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnLeer;
    }
}