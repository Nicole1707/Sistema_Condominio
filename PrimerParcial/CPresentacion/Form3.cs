using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CEntidad;
using CNegocio;
using InputKey;

namespace CPresentacion
{
    public partial class Form3 : Form
    {
        EntidadConfi adminis = new EntidadConfi();
        ClaseNegocio ejec = new ClaseNegocio();
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                adminis.Manzana= txtMan.Text;
                adminis.Edificio= txtEdi.Text;
                adminis.Apartamento= txtApa.Text;

                ejec.agregarConfi(adminis);

                MessageBox.Show("Agregado correctamente");
            }
            catch (Exception eex)
            {
                MessageBox.Show(eex.Message);

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control oControls in this.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; // Eliminar el texto del TextBox
                }
                if (oControls is ComboBox)
                {
                    oControls.Text = ""; // Eliminar el texto del TextBox
                }

            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
        }

        private void habitantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                adminis.Edificio = txtEdi.Text;
                ejec.agregarConfiE(adminis);

                MessageBox.Show("Agregado correctamente");
            }
            catch (Exception eex)
            {
                MessageBox.Show(eex.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                adminis.Manzana = txtMan.Text;

                ejec.agregarConfi(adminis);

                MessageBox.Show("Agregado correctamente");
            }
            catch (Exception eex)
            {
                MessageBox.Show(eex.Message);

            }
        }

        private void btnAgregar3_Click(object sender, EventArgs e)
        {
            try
            {
                adminis.Apartamento = txtApa.Text;

                ejec.agregarConfiA(adminis);

                MessageBox.Show("Agregado correctamente");
            }
            catch (Exception eex)
            {
                MessageBox.Show(eex.Message);

            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnLeer_Click_1(object sender, EventArgs e)
        {
            dgvApa.DataSource = ejec.LeerConfiA();
            dgvEdi.DataSource = ejec.LeerConfiE();
            dgvMan.DataSource = ejec.LeerConfi();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgvApa.DataSource = ejec.LeerConfiA();
            dgvEdi.DataSource = ejec.LeerConfiE();
            dgvMan.DataSource = ejec.LeerConfi();

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)

        {
            foreach (Control oControls in this.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; 
                }
            
                

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                adminis.Edificio = InputDialog.mostrar("Ingerse el valor ha actualizar: ");
                adminis.Mensaje = InputDialog.mostrar("Ingrese el nuevo dato: ");
                ejec.ActuConfiEdi(adminis);
                MessageBox.Show("Dato actualizado corerectamente.");
            }
            catch (Exception eex)
            {
                MessageBox.Show(eex.Message);

            }



        }

        private void btnEditM_Click(object sender, EventArgs e)
        {
            try
            {
                adminis.Manzana= InputDialog.mostrar("Ingerse el valor ha actualizar: ");
                adminis.Mensaje = InputDialog.mostrar("Ingrese el nuevo dato: ");
                ejec.ActuConfiMan(adminis);
                MessageBox.Show("Dato actualizado corerectamente.");
            }
            catch (Exception eex)
            {
                MessageBox.Show(eex.Message);

            }

        }

        private void btnEditA_Click(object sender, EventArgs e)
        {
            try
            {
                adminis.Apartamento = InputDialog.mostrar("Ingerse el valor ha actualizar: ");
                adminis.Mensaje = InputDialog.mostrar("Ingrese el nuevo dato: ");
                ejec.ActuConfiAp(adminis);
                MessageBox.Show("Dato actualizado corerectamente.");
            }
            catch (Exception eex)
            {
                MessageBox.Show(eex.Message);

            }

        }
    }
}
