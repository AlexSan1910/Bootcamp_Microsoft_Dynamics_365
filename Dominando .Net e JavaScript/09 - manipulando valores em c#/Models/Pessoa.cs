using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models{
    public class Pessoa{

        // Criando propriedades
        public string Nome { get; set; }
        public int Idade { get; set; }  

        // Criando metodo

        public void Apresentar(){
            Console.WriteLine($"Nome {Nome}, idade {Idade}");
        }
    }
}