using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace TP4.Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public  List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }
        
        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }

        public void FinEntregas()
        {
            for(int i = 0; i< this.mockPaquetes.Capacity; i++)
            {
                this.mockPaquetes[i].Abort();
            }
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            string mostrar = "";
            foreach(Paquete p in ((Correo)elemento).Paquetes)
            {
                mostrar += string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
                mostrar = "\n";
            }
            return mostrar;
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            bool esta = false ;
            for (int i = 0; i< c.Paquetes.Count;i++)
            {
                if(c.Paquetes[i] == p)
                {
                    esta = true;
                    throw new TrackingIdRepetidoException("El paquete que intento ingresar , ya existe");
                }
            }
            if(esta == false)
            {
                c.Paquetes.Add(p);
                Thread thread = new Thread(p.MockCicloDeVida);
                c.mockPaquetes.Add(thread);
                thread.Start();
            } 
            return c;
        }
    }
}
