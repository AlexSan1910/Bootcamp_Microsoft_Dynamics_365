namespace Course{
    class Program{
        static void Main(string[] args){
            int[] arrayInteiros = new int[3]; // declarei um array ocm 3 posições
            
            // definindo valores aos respectivos espaços no array.
            arrayInteiros[0] = 72;
            arrayInteiros[1] = 64;
            arrayInteiros[2] = 50;

            // criando Estrutura de reetição para demonstração do conteudo da lista "ArrayInteiros"

            for(int contador = 0; contador < arrayInteiros.Length; contador++){
                Console.WriteLine($"Posição N: {contador} - {arrayInteiros[contador]}");
            }
        }
    }
}