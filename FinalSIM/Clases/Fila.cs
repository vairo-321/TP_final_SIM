using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSIM.Clases
{
    class Fila
    {
        private double media { get; set; }
        private double maximoBuffer { get; set; }
        private string Evento { get; set; }
        private double RelojSegundos { get; set; }
        private double? RND_paquete { get; set; }
        private double? Tiempo_llegada_paquete { get; set; }
        private double Proximo_paquete { get; set; }
        private double? RND_redireccion { get; set; }
        private int? Dominio { get; set; }
        private double? Tiempo_redireccion { get; set; }
        private double? Fin_redireccion { get; set; }
        private string EstadoBuffer { get; set; }
        private int ColaBuffer { get; set; }
        private int Dominio1 { get; set; }
        private int Dominio2 { get; set; }
        private int Paquete_descartado { get; set; }

        public bool primeraFila = true;

        private Random random = new Random();



        public Fila(double media, double maximoBuffer)
        {
            this.media = media;
            this.maximoBuffer = maximoBuffer;
            this.Evento = "inicio";
            this.RelojSegundos = 0.0;
            this.RND_paquete = random.NextDouble();
            this.Tiempo_llegada_paquete = Math.Round(-this.media * Math.Log((double)(1 - RND_paquete)), 2) ;
            this.Proximo_paquete = (double)(RelojSegundos + Tiempo_llegada_paquete);
            this.Fin_redireccion = null;
            this.EstadoBuffer = "libre";
            this.ColaBuffer = 0;
            this.Dominio1 = 0;
            this.Dominio2 = 0;
            this.Paquete_descartado = 0;
        }

        public string[] calcularFilaNueva()
        {

            if(primeraFila)
            {
                return vectorString();
            }
            else
            {
                calcular();
                return vectorString();
            }



        }


        private string[] vectorString()
        {
            if (primeraFila)
            {
                primeraFila = false;

                return new string[] { Evento, RelojSegundos.ToString(), RND_paquete.ToString(), Tiempo_llegada_paquete.ToString(), Proximo_paquete.ToString(), "",
                    "", "", "", EstadoBuffer, ColaBuffer.ToString(), Dominio1.ToString(), Dominio2.ToString(),
                    Paquete_descartado.ToString()};
            }
            else 
            {
                return new string[] { Evento, RelojSegundos.ToString(), RND_paquete.ToString(), Tiempo_llegada_paquete.ToString(), Proximo_paquete.ToString(), RND_redireccion.ToString(),
                    Dominio.ToString(), Tiempo_redireccion.ToString(), Fin_redireccion.ToString(), EstadoBuffer, ColaBuffer.ToString(), Dominio1.ToString(), Dominio2.ToString(),
                    Paquete_descartado.ToString()};
            } 
        
        }


        private void calcular() 
        {
            if (Proximo_paquete <= Fin_redireccion)
            {
                eventoLlegadaPaquete();
            }
            else
            {
                eventoFinRedireccion();
            }

        }

        private void eventoLlegadaPaquete()
        {
            this.Evento = "ingreso paquete";
            this.RelojSegundos = this.Proximo_paquete;
            this.RND_paquete = random.NextDouble();
            this.Tiempo_llegada_paquete = Math.Round(-this.media * Math.Log((double)(1 - RND_paquete)), 2);
            this.Proximo_paquete = (double)(RelojSegundos + Tiempo_llegada_paquete);

            //Aqui veo si hay paquete redireccionando o no... primera entrada es si no hay 
            if (Fin_redireccion == null )
            {
                RND_redireccion = random.NextDouble();
                if(RND_redireccion <= 0.25)
                {
                    this.Dominio = 1;
                    this.Tiempo_redireccion = 0.3;
                }
                else
                {
                    this.Dominio = 2;
                    this.Tiempo_redireccion = 0.6;
                }

                this.Fin_redireccion = Tiempo_redireccion + RelojSegundos;
            }
            else
            {
                RND_redireccion = null;
                Tiempo_redireccion = null;

                if(this.EstadoBuffer == "libre")
                {
                    this.ColaBuffer++;
                    if (ColaBuffer == maximoBuffer) EstadoBuffer = "lleno";
                }
                else
                {
                    this.Paquete_descartado++;
                }
            }
        }

        private void eventoFinRedireccion()
        {
            this.Evento = "paquete redireccionado";
            this.RelojSegundos = (double)this.Fin_redireccion;

            RND_paquete = null;
            Tiempo_llegada_paquete = null;

            //calculo si hay otro paquete para redireccionar en buffer
            if(ColaBuffer != 0)
            {
                ColaBuffer--;
                if (EstadoBuffer == "lleno") EstadoBuffer = "libre";

                RND_redireccion = random.NextDouble();
                if (RND_redireccion <= 0.25)
                {
                    this.Dominio = 1;
                    this.Tiempo_redireccion = 0.3;
                }
                else
                {
                    this.Dominio = 2;
                    this.Tiempo_redireccion = 0.6;
                }

                this.Fin_redireccion = Tiempo_redireccion + RelojSegundos;

            }
            else
            {
                RND_redireccion = null;
                if (Dominio == 1) Dominio1++;
                else Dominio2++;
                Dominio = null;
                Tiempo_redireccion = null;
                Fin_redireccion = null;
            }
        }



    }
}
