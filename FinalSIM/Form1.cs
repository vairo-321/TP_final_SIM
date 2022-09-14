using FinalSIM.Clases;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int SimMax = Int32.Parse(msk_filasMax.Text);
                int CantPaquetesMinutos = Int32.Parse(msk_PaqueXMin.Text);
                double TamañoBufferMB = Double.Parse(txt_tamBuff.Text);
                double TamañoPaqueteKB = Double.Parse(txt_tamPaq.Text);

                Controlador controlador = new Controlador(SimMax, CantPaquetesMinutos, TamañoBufferMB, TamañoPaqueteKB, this);

                controlador.iniciarSimulacion();

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
