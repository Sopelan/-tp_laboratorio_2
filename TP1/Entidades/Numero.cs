using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        private string setNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        public Numero()
        {
            numero = 0;
        }
        public Numero(double numero)
        {
            setNumero = Convert.ToString(numero);
        }
        public Numero(string numero)
        {
            setNumero = numero;
        }
        private double ValidarNumero(string strNumero)
        {
            bool validar = int.TryParse(strNumero, out int num);
            if (validar)
                return Convert.ToDouble(num);
            return 0;
        }
        public string BinarioDecimal(string binario)
        {
            bool validar = false;
            foreach (var i in binario)
            {
                if (i == '0' || i == '1')
                    validar = true;
                else
                {
                    validar = false;
                    break;
                }
            }
            if (validar)
                return Convert.ToInt32(binario, 2).ToString();
            else
                return "Numero invalido";
        }
        public string DecimalBinario(double numero)
        {
            long num = Convert.ToInt64(numero);
            string Binario = Convert.ToString(num, 2);
            return Binario;
        }
        public string DecimalBinario(string numero)
        {
            if (int.TryParse(numero, out int num))
                return Convert.ToString(num, 2);
            return "numero invalido";

        }
        public static double operator +(Numero n1 , Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1 , Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1 , Numero n2)
        {
            if (n2.numero == 0)
                return double.MinValue;
            else
                return n1.numero / n2.numero;
        }
    }
}
