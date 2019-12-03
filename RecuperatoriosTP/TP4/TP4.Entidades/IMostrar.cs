using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Entidades
{
    public interface IMostrar <T>
    {
       string MostrarDatos(IMostrar<T> elemento);
    }
}
