using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Interface
{
    interface IOperacao
    {
        //Somar 2 números
        double Somar(double val1, double val2);
        //Subtrair 2 números
        double Subtrair(double val1, double val2);
        //Multiplicar 2 números
        double Multiplicar(double val1, double val2);
        //Dividir 2 números
        double Dividir(double val1, double val2);
        //Calcular área do retângulo
        double CalcularAreaRetangulo(double val1, double val2);
        //Calcular área do quadrado
        double CalcularAreaQuadrado(double val1, double val2);
        //Calcular área do triângulo
        double CalcularAreaTriangulo(double val1, double val2);
        //Verificar se o número é par
        bool VerificarPar(int val);
        //Calcular IMC
        double CalcularIMC(double val1, double val2);
        //Verificar campo vazio
        bool VerificarCampoVazio(string campo);
    }
}
