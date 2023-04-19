namespace Course{
    class EstruturaForeach{
        static void Main(string[] args){

            int[] arrayInteiros = new int[3]; // declarei um array ocm 3 posições
            
            // definindo valores aos respectivos espaços no array.
            arrayInteiros[0] = 72;
            arrayInteiros[1] = 64;
            arrayInteiros[2] = 50;

            // basicamente estou pedindo para cada valor no array, que ele seja adici9onado dentro
            // da variavel valor e posteriormente printado com o Console.WriteLine().

            foreach(int valor in arrayInteiros){
                Console.WriteLine(valor);
            }

            // REDIMENSIONANDO UM ARRAY

            // Utilizando da classe Array.Resize para dobrarmos o valor do nosso Array.. como é de conhecimento de todos.. se um array criado
            // foi instanciado com apenas 3 espaços nele, ele terá sempre apenas esses unicos 3 endereços, porem com a classe Array.Resize, conseguimos
            // aumentar a sua capacidade maxima do array.

            // Neste caso utilzamos da classe Array.Resize, depois passamos como referencia o nome do array, e pegamos o legth do array "ou seja, o tamanho do array"
            // e multiplicamos por 2, ou seja, assim dobrando a sua capacidade.

            Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); 

            // COPIA DE ELEMENTOS DE UM ARRAY PARA UM OUTRO

            int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2]; // criando um array, com o dobro da capacidade do arrayInteiros
            

            // basicamente estou utilizando a classe array. com o metodo copy, e o primeiro parametro estou definindo o array que desejo copiar "arrayInteiros",
            // depois defino o array para qual será copiado "arrayInteirosDobrados", com a capacidade inteira de arrayInteiros que é arrayInteiro.length
            Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);

        }
    }
}