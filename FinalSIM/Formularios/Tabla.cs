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
        Frm_Info info = new Frm_Info();

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

        public void armarInfo(int SimMax, int cantPaquetesMin, double tamañoBuff, double tamañoPaqu, int maxBuff, double media)
        {

            int ultimoIndice = dataGridView1.RowCount;
            DataGridViewRow fila = dataGridView1.Rows[ultimoIndice - 2];

            DataGridViewCell celda10 =  fila.Cells[10];
            DataGridViewCell celda11 = fila.Cells[11];
            DataGridViewCell celda12 = fila.Cells[12];
            DataGridViewCell celda13 = fila.Cells[13];



            int celda10i = Int32.Parse(celda10.Value.ToString()) ;
            int celda11i = Int32.Parse(celda11.Value.ToString());
            int celda12i = Int32.Parse(celda12.Value.ToString());
            int celda13i = Int32.Parse(celda13.Value.ToString());





            int totalPaquetes = celda10i + celda11i + celda12i + celda13i + 1;
            int totalRedistribuido = celda11i + celda12i;
            int totalRechazado = celda13i;

            info.actualizar( SimMax, cantPaquetesMin, tamañoBuff, tamañoPaqu, maxBuff, media, totalPaquetes, totalRedistribuido, totalRechazado);


        }






        private void btn_volver_Click(object sender, EventArgs e)
        {
            form_config.Show();
            this.Close();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            info.Show();
        }
    }
}
