﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }
        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
        }

        public void MockCicloDeVida() { }
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return string.Format("{0} para {1}", ((Paquete)elemento).TrackingID, ((Paquete)elemento).DireccionEntrega);
        }

        public static bool operator !=(Paquete p1 , Paquete p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Paquete p1 , Paquete p2)
        {
            return p1.TrackingID == p2.TrackingID;
        }

        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        public event DelegadoEstado InformaEstado;
        public delegate void DelegadoEstado(object source, EventArgs args);
        public enum EEstado
        {
            Ingresado,
            Enviaje,
            Entregado
        }
    }
}
