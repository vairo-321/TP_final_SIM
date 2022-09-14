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
            int SimMax = Int32.Parse(txt_maxSim.Text);
            int CantPaquetesMinutos = Int32.Parse(txt_cantPaq.Text);
            double TamañoBufferMB = Double.Parse(txt_tamBuff.Text);
            double TamañoPaqueteKB = Double.Parse(txt_tamPaq.Text);

            Controlador controlador = new Controlador(SimMax, CantPaquetesMinutos, TamañoBufferMB, TamañoPaqueteKB);

            controlador.iniciarSimulacion();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
