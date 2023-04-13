namespace Course{
    class CondicionalNOT {
        static void Main(string[] args){
            bool choveu = true;
            bool estaTarde = true;

            // o condicional é utilizado no caso de quando há a necessidade de negarmos uma condição, ou seja o valor ao contrario do que ela é
            // se for esperado o valor false em uma condição, utilizando esse operador condicional NOT, ela se tornará true.

            // Esse operador condicional NOT é utilizado com o simbolo "!" exclamção na frente da variavel que queremos a negativação da mesma.

            if (choveu && estaTarde){
                Console.WriteLine("Vou pedalar!");
            }
            else{
                Console.WriteLine("Vou pedalar outro dia.");
            }
        }
    }
}