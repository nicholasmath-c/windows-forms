using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Interface
{
    class Operacao : IOperacao
    {
        public double CalcularAreaQuadrado(double val1, double val2)
        {
            return val1 * val2;
        }

        public double CalcularAreaRetangulo(double val1, double val2)
        {
            return val1 * val2;
        }

        public double CalcularAreaTriangulo(double val1, double val2)
        {
            return (val1 * val2) / 2;
        }

        public double CalcularIMC(double val1, double val2)
        {
            return val1 / (val2 * val2);
        }

        public double Dividir(double val1, double val2)
        {
            return val1 / val2;
        }

        public double Multiplicar(double val1, double val2)
        {
            return val1 * val2;
        }

        public double Somar(double val1, double val2)
        {
            return val1 + val2;
        }

        public double Subtrair(double val1, double val2)
        {
            return val1 - val2;
        }

        public bool VerificarCampoVazio(string campo)
        {
            if (campo == "")
                return true;
            else
                return false;
        }

        public bool VerificarPar(int val)
        {
            int modulo = val % 2;
            if(modulo == 0)
                return true;
            else
                return false;
        }
    }
}
