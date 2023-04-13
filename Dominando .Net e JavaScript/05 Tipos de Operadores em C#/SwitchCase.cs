// para este exemplo de switch case, irei fazer um progrma que irá buscar um dado do usuario e posteriormente dizer se é vogal ou não.
using System;

namespace Course {
    class SwitchCase{
        static void Main(string[] args){
            Console.WriteLine("Digite uma letra por favor: ");
            String letra = Console.ReadLine();

            switch (letra){
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("é uma vogal!!");
                    break; // utilizado para parar o codigo ao executar a ação.

                default: // pra se caso nenhuma das opções case acima for selecionada.
                    Console.WriteLine("Não é uuma vogal!!");
                    break;
            }
        }
    }
}
