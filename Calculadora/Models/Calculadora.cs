using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjetoCalculadora.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza uma soma de dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro</param>
        /// <param name="y">O segundo número inteiro</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        /// <summary>
        /// Realiza uma subtração de dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro</param>
        /// <param name="y">O segundo número inteiro</param>
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        /// <summary>
        /// Realiza a multiplicação de dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro</param>
        /// <param name="y">O segundo número inteiro</param>
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        /// <summary>
        /// Realiza a divisão de dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro</param>
        /// <param name="y">O segundo número inteiro</param>
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        /// <summary>
        /// Realiza a potenciação do primeiro número.
        /// </summary>
        /// <param name="x">O primeiro número inteiro (base)</param>
        /// <param name="y">O segundo número inteiro (expoente)</param>
        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {potencia}");
        }

        /// <summary>
        /// Calcula o seno de um ângulo
        /// </summary>
        /// <param name="angulo">Valor do ângulo</param>
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O seno de {angulo}º = {Math.Round(seno,4)}");
        }

        /// <summary>
        /// Calcula o coseno de um ângulo
        /// </summary>
        /// <param name="angulo">Valor do ângulo</param>
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O coseno de {angulo}º = {Math.Round(coseno,4)}");
        }

        /// <summary>
        /// Calcula a tangente de um ângulo
        /// </summary>
        /// <param name="angulo">Valor do ângulo</param>
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"O tangente de {angulo}º = {Math.Round(tangente,4)}");
        }

        /// <summary>
        /// Calcula a raiz quadrada de um número
        /// </summary>
        /// <param name="x">Número inteiro</param>
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}