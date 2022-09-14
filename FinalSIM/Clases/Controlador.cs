using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSIM.Clases
{
    class Controlador
    {

        public int SimMax { get; set; }
        public int CantPaquetesMinutos { get; set; }
        public double TamañoBufferMB { get; set; }
        public double TamañoPaqueteKB { get; set; }


        private int maximoBuffer { get; set; }

        private double media { get; set; }
     
        private Fila filaSIM { get; set; }


        public Controlador(int simulacionMaxima, int paquetesXMin, double tamañoBuff, double tamañoPaquete)
        {
            this.SimMax = simulacionMaxima;
            this.CantPaquetesMinutos = paquetesXMin;
            this.TamañoBufferMB = tamañoBuff;
            this.TamañoPaqueteKB = tamañoPaquete;
            maximoBuffer = (int)Math.Truncate((TamañoBufferMB * 1000) / TamañoPaqueteKB);
            media = 60 / CantPaquetesMinutos;
            this.filaSIM = new Fila(media, maximoBuffer);
        }


        
     





    }
}
