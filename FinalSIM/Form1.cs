using FinalSIM.Clases;
using FinalSIM.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSIM
{
    public partial class Form1 : Form
    {
        Frm_Presentacion presentacion { get; set; }

        public Form1(Frm_Presentacion pres)
        {
            InitializeComponent();
            presentacion = pres;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int SimMax = Int32.Parse(msk_filasMax.Text);
                int CantPaquetesMinutos = Int32.Parse(msk_PaqueXMin.Text);
                double TamañoBufferMB = Double.Parse(txt_tamBuff.Text);
                double TamañoPaqueteKB = Double.Parse(txt_tamPaq.Text);
                int desde;
                int hasta;

                if (checkBox1.Checked)
                {
                    desde = Int32.Parse(msk_desde.Text);
                    hasta = Int32.Parse(msk_hasta.Text);
                }
                else
                {
                    desde = 0;
                    hasta = SimMax;
                }


                Controlador controlador = new Controlador(SimMax, CantPaquetesMinutos, TamañoBufferMB, TamañoPaqueteKB, this);

                controlador.iniciarSimulacion(desde, hasta);

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            presentacion.Close();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Frm_Enunciado enunciado = new Frm_Enunciado();
            enunciado.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }
    }
}
