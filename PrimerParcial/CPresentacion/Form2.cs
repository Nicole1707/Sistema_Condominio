using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidad;
using CNegocio;

namespace CPresentacion
{
    public partial class Form2 : Form
    {
        ClaseEntidad habitante = new ClaseEntidad();
        ClaseNegocio ejec = new ClaseNegocio();
        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             dgvHabi.DataSource = ejec.Leer();
            MostrarManza();
            MostrarEdif();
            MostrarApart();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                habitante.cedula = txtCedula.Text;
                habitante.Nombre = txtNombre.Text;
                habitante.Manzana = Convert.ToInt32(cbManz.SelectedValue);
                habitante.Edificio = Convert.ToInt32(cbEdif.SelectedValue);
                habitante.Apartamento = Convert.ToInt32(cbApart.SelectedValue);
                ejec.agregar(habitante);

                MessageBox.Show("Agregado correctamente");
            }
            catch (Exception eex)
            {
                MessageBox.Show(eex.Message);

            }

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            dgvHabi.DataSource = ejec.Leer();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control oControls in this.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; 
                }

                if (oControls is ComboBox)
                {
                    oControls.Text = ""; 
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                habitante.cedula = txtCedula.Text;
                habitante.Nombre = txtNombre.Text;
                habitante.Manzana = Convert.ToInt32(cbManz.SelectedValue);
                habitante.Edificio = Convert.ToInt32(cbEdif.SelectedValue);
                habitante.Apartamento = Convert.ToInt32(cbApart.SelectedValue);
                ejec.editar(habitante);
                ejec.Leer();
                MessageBox.Show("Editado correctamente");
            }
            catch (Exception eex)
            {
                MessageBox.Show(eex.Message);

            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                habitante.cedula = txtCedula.Text;
                
                ejec.borrar(habitante);

                MessageBox.Show("Borrado correctamente");
            }
            catch (Exception eex)
            {
                MessageBox.Show(eex.Message);

            }
        }

        private void siguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void MostrarManza()
        {
            cbManz.DataSource = ejec.MostrarM();
            cbManz.ValueMember = "id_manzana";
            cbManz.DisplayMember = "Manzana";
            cbManz.SelectedIndex = -1;
        }
        private void MostrarEdif()
        {
            cbEdif.DataSource = ejec.MostrarEd();
            cbEdif.ValueMember = "id_edificio";
            cbEdif.DisplayMember = "Edificio";
            cbEdif.SelectedIndex = -1;
        }
        private void MostrarApart()
        {
            cbApart.DataSource = ejec.MostrarApa();
            cbApart.ValueMember = "id_apartamento";
            cbApart.DisplayMember = "Apartamento";
            cbApart.SelectedIndex = -1;
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbC_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void RBManzana_CheckedChanged(object sender, EventArgs e)
        {
            if (RBManzana.Checked == true)
            {
                cbEleg.DataSource = null;
                cbEleg.DataSource = ejec.MostrarM();
                cbEleg.ValueMember = "id_manzana";
                cbEleg.DisplayMember = "Manzana";
                cbEleg.SelectedIndex = -1;

            }
            else if (RBEdificio.Checked == true)
            {
                cbEleg.DataSource = null;
                cbEleg.DataSource = ejec.MostrarEd();
                cbEleg.ValueMember = "id_edificio";
                cbEleg.DisplayMember = "Edificio";
                cbEleg.SelectedIndex = -1;
            }
        }

        private void cbEleg_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string val = cbEleg.Text;
            if (RBManzana.Checked == true)
            {
                dgvHabi.DataSource = ejec.BusquedaMnz(val);
            }
            else if (RBEdificio.Checked == true)
            {
                dgvHabi.DataSource = ejec.BusquedaEdif(val);
            }
        }
    }
}
