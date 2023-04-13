using System;

namespace Course{
    class CondicionalAND {
        static void Main(string[] args){
            bool possuiPresencaMinima = true;
            double media = 7.5;

            // condicional ann é utilizado com o e comercial "&&", ele é utilizado nos casos em que todas as condições sejam verdadeiras
            // nesse caso ele só poderá funcionar se media for verdadeira e se a presença minima for verdadeira, ou seja, maior que 7.

            if (possuiPresencaMinima && media > 7){
                Console.WriteLine("Aprovado!");
            } 
            else{
                Console.WriteLine("Reprovado!");
            }

        }
    }
}