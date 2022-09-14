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
        public Frm_tabla()
        {
            InitializeComponent();
        }

        private void Frm_tabla_Load(object sender, EventArgs e)
        {

        }

        public void cargarTabla(string[] cadena)
        {

            dataGridView1.Rows.Add(cadena);

            
        }


    }
}
