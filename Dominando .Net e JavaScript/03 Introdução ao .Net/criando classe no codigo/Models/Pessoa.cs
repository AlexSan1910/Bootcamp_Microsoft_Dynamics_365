using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace criando_classe_no_codigo.Models
{
    public class Pessoa // classe deve ser sempre escrita com a letra maiuscula
    {

        //Atributos

        public string Nome { get; set; } // Atributos deve ser escrito com letras maiusculas
        public int Idade { get; set; }


        // Metodos ou funções

        public void Apresentar(){
            Console.WriteLine($"Ola, meu nome é {Nome}, e tenho {Idade} anos"); // metodos são representados com a mesma cor, e nele são passados alguns parametros
                                                                                // nesse caso do writeLine, é um metodo que irá printa um conjunto de caracter na
                                                                                // na tela do usuario, e esses caracteres é tudo aquilo que digitarmos dentro dele 
                                                                            
        }
    }
}