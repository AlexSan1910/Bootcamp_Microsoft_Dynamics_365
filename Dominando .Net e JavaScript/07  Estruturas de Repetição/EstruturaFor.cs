
// Utilização de Estrutura de repetição For 

namespace Course
{
    class EstruturaFOR{
        static void Main(string[] args){

            int numero = 5;

            // primeiro irei definir meu contador, com o nome de uma variavel qualquer, depois definirei a quantidade de repetições.. 
            // ou seja, irá repetir enquanto o contador for menor que 10, e depois irei definir de quanto em quanto ele irá saltar essas repetições.

            for(int contador = 0; contador <= 10; contador++){
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            }
        }
    }
}