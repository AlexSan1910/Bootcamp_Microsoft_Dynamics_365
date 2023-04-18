using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course{
    public class Calculadora{

        // função para Soma de dois numeros inteiros
        public void Somar(int numberX, int numberY){
                Console.WriteLine($"{numberX} + {numberY} = {numberX + numberY}");
        }

        //função para Subtração de dois numeros inteiros.

        public void Subtrair(int numberX, int numberY){
                Console.WriteLine($"{numberX} - {numberY} = {numberX - numberY}");
        }

        //função para Multiplicação de dois numeros inteiros.

        public void Multiplicar(int numberX, int numberY){
                Console.WriteLine($"{numberX} * {numberY} = {numberX * numberY}");
        }

        //função para Divisão de dois numeros inteiros.

        public void Dividir(int numberX, int numberY){
                Console.WriteLine($"{numberX} / {numberY} = {numberX / numberY}");
        }

        // Criando função utilizando a classe math

        public void Potencia(int numberX, int numberY){
            double pot = Math.Pow(numberX, numberY);
            Console.WriteLine($"{numberX} ^ {numberY} = {pot}");
        }

        // criando função para seno

        public void Seno(double angulo){
            double radiano = angulo * Math.PI / 100;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }

        // criando função para Coseno

        public void Coseno(double angulo){
            double radiano = angulo * Math.PI / 100;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(coseno, 4)}");
        }

        // criando função para Tangente

        public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 100;
            double conseno = Math.Tan(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(conseno, 4)}");
        }

        // criando função para calculo de raiz quadrada

        public void Raiz(double number){
            double raiz = Math.Sqrt(number);
            Console.WriteLine($"Raiz Quadrada de {number} é {raiz}");
        }

       
    }
}
