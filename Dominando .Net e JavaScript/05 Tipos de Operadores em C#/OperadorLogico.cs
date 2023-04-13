using System;

namespace Course{
    class ProgramDois{
        static void Main(string[] args){
            int quantidadeEmEstoque = 10;
            int quantidadeCompra = 4;
            bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra; // vai nos retornar um valor verdadeiro ou falso.

            Console.WriteLine("Quantidade em estoque é " + quantidadeEmEstoque);
            Console.WriteLine("Quantidade de Compra: " + quantidadeCompra);
            Console.WriteLine("é possivel realizar a venda? " + possivelVenda);


            //existe tambem o if aninhado, que neste caso é um if e else, com varias condições para que assim você possa implementar diversas condições
            // em seu programa.

            if(quantidadeCompra == 0)
            {
                Console.WriteLine("Venda Invalida.");
            }
            else if (possivelVenda) 
            {
                Console.WriteLine("Venda Realizada.");
            }
            else
            {
                Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
            }
        }
    }
}

