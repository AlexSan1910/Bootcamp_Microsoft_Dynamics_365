namespace Courese
{
    class EstruturaDoWhile{
        static void Main(string[] args){

            int numero = 0, soma = 0;

            // se antigamente era feito primeiro uma validação para a execução da estrutura através da condição e depois executada.
            // agora primeiro é executado, uma informação primaria, que irá executar sem a necessidade de uma condição, e depois iremos 
            // executar a partir apenas de uma condição.
            do{
                Console.Write("Digite um numero (0 para parar): ");
                numero = Convert.ToInt32(Console.ReadLine());

                soma += numero;

            }while(numero != 0);

            Console.WriteLine($"Total Soma {soma}");
        }
    }
}