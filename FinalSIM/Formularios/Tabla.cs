using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSIM.Formularios
{
    public partial class Frm_tabla : Form
    {
        Form1 form_config { get; set; }

        public Frm_tabla(Form1 form_config)
        {
            InitializeComponent();
            this.form_config = form_config;
        }

        private void Frm_tabla_Load(object sender, EventArgs e)
        {

        }

        public void cargarTabla(string[] cadena)
        {

            dataGridView1.Rows.Add(cadena);

            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            form_config.Show();
            this.Close();
        }
    }
}
