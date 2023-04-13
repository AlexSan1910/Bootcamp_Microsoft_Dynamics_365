using System;

namespace Course{
    class CondicionalOR{
        static void Main(string[] args){
            bool maiorDeIdade = true;
            bool possuiAutorização = false;

            // o operador logico OR é representado pelo pipe "||"

            // basicamente estamos fazendo uma condição no qual se alguem for maior de idade ou se possui autorização de um responsavel, ele irá dizer 
            // que a entrada está liberada. se nenhuma das duas for verdadeira, a entrada não estará liberada.

            if ( maiorDeIdade || possuiAutorização){
                Console.WriteLine("Entrada liberada!");
            }
            else{
                Console.WriteLine("Entrada não liberada!");
            }
        }
    }
}