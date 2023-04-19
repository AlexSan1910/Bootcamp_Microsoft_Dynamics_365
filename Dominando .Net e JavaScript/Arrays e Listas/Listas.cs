namespace Course
{
    class Listas{
        static void Main(string[] args){

            // instanciando uma nova lista.

            List<string> listaString = new List<string>(); // basicamente chamos a lista, e entre maior e menos definimos o tipo primitivo da lista,
                                                           // depois definimos o nome da lista e logo após intanciamos ela.

                                                           // Assim como deve ter percebido, já na lista não tem a necessidade de definirmos um tamanho para ela
                                                           // basta apenas instanciarmos.


            // adicionando valores as listas

            listaString.Add("São Paulo");
            listaString.Add("Minas Gerais");
            listaString.Add("Bahia");
            

            Console.WriteLine("Percorrendo Lista com FOR");
            for(int contador = 0; contador < listaString.Count; contador++){
                Console.WriteLine($"Posição n {contador} - {listaString[contador]}");
            }


            Console.WriteLine("Percorrendo Lista com FOREACH");
            int contadorForeach = 0;
            foreach(string item in listaString){
                Console.Write($" Posição n {contadorForeach} - {item}");
                contadorForeach++;
            }

            // Trabalhando um pouco mais com os metodos da lista.
            
            //mostrando ingredientes da minha lista e a sua capacidade.
            Console.WriteLine($" Itens na minha lista: {listaString.Count} - Capacidade da minha lista: {listaString.Capacity}"); 

            //adicionando um novo item a minha lista e mostrando novamente os itens e sua capacidade.
            listaString.Add("Santa Catarina");

            Console.WriteLine($" Itens na minha lista: {listaString.Count} - Capacidade da minha lista: {listaString.Capacity}");

            // Removendo itens da lista e mostrando novamente os seus respectivos itens da lista e a sua capacidade.

            listaString.Remove("Bahia");

            Console.WriteLine($" Itens na minha lista: {listaString.Count} - Capacidade da minha lista: {listaString.Capacity}"); 

        }
    }
}