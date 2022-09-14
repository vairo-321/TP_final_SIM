using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalSIM.Formularios;

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

        private Frm_tabla formularioTabla { get; set; }


        public Controlador(int simulacionMaxima, int paquetesXMin, double tamañoBuff, double tamañoPaquete)
        {
            this.SimMax = simulacionMaxima;
            this.CantPaquetesMinutos = paquetesXMin;
            this.TamañoBufferMB = tamañoBuff;
            this.TamañoPaqueteKB = tamañoPaquete;
            maximoBuffer = (int)Math.Truncate((TamañoBufferMB * 1000) / TamañoPaqueteKB);
            media = 60.0 / (double)CantPaquetesMinutos;
            this.filaSIM = new Fila(media, maximoBuffer);
        }

        public void iniciarSimulacion()
        {
            Console.WriteLine(this.SimMax.ToString());
            Console.WriteLine(this.CantPaquetesMinutos.ToString());
            Console.WriteLine(this.TamañoBufferMB.ToString());
            Console.WriteLine(this.TamañoPaqueteKB.ToString());
            Console.WriteLine(maximoBuffer.ToString());
            Console.WriteLine(media.ToString());

            formularioTabla = new Frm_tabla();
            formularioTabla.Show();

            for (int i = 0; i <= SimMax; i++)
            {
                string[] cadena = filaSIM.calcularFilaNueva();

                formularioTabla.cargarTabla(cadena);

            }
        }
    }
 }
        
     


