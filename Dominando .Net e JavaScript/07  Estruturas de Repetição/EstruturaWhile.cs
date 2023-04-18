namespace Course{
    class EstruturaWhile{
        static void Main(string[] args){
            int tabuada = 8;
            int contadorWhile = 0;

            // basicamente com a estrutura wwile, eu irei executar a ação, sempre quando a condição for verdadeira.

            while(contadorWhile <= 10){
                 Console.WriteLine($"{tabuada} x {contadorWhile} = {tabuada * contadorWhile}");
                 contadorWhile++;

                 // nesse caso, para executar a mesma ação que o exercicio anterior, basta definir a condição como sempre quando o contador for menor ou igual a 10 executar a ação,
                 // e ao final do conteudo dessa estrutura, colocar uma condição que adicione sempre uma unidade ao executar essa estrutura.
            }
        }
    }
}