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
    public partial class Frm_Info : Form
    {

        int totalPaquetes { get; set; }
        int totalRedistribuido { get; set; }
        int totalRechazado { get; set; }
        double porcentaje { get; set; }

        public Frm_Info()
        {
            InitializeComponent();
        }

        private void Frm_Info_Load(object sender, EventArgs e)
        {
            string cadena = "Hubo un total de " + totalPaquetes.ToString() + " paquetes procesados, de los cuales " + totalRedistribuido.ToString() + "\n" +
                "fueron redistribuidos y " + totalRechazado.ToString() + " rechazados, lo cual representa un " + Math.Round( porcentaje, 2).ToString() + "% \ndel total... " +
                "el resto de paquetes se encuentran en el Buffer y/o siendo procesado " +
                "al finalizar la simulación";

            lbl_fin.Text = cadena;
        }

        public void actualizar(int SimMax, int cantPaquetesMin, double tamañoBuff, double tamañoPaqu, int maxBuff, double media, int totalPaquetes, int totalRedistribuido, int totalRechazado)
        {

            lbl_fila.Text += ": " + SimMax;
            lbl_cantPaque.Text += ": " + cantPaquetesMin;
            lbl_tamBuff.Text += ": " + tamañoBuff;
            lbl_tamPaq.Text += ": " + tamañoPaqu;
            lbl_capBuff.Text += ": " + maxBuff;
            lbl_media.Text += ": " + media;

            this.totalPaquetes = totalPaquetes;
            this.totalRedistribuido = totalRedistribuido;
            this.totalRechazado = totalRechazado;
            this.porcentaje = ((double)totalRechazado / (double)totalPaquetes) * 100;
        }

    }
}
