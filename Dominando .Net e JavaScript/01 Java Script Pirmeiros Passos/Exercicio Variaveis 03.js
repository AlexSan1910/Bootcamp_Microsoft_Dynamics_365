/* 
3) Elabore um algoritmo que calcule o que deve ser pago por um produto, considerando o preço normal de etiqueta e a escolha da condição de pagamento. 
Utilize os códigos da tabela a seguir para ler qual a condição de pagamento escolhida e efetuar o cálculo adequado.

Código Condição de pagamento:
- À vista Débito, recebe 10% de desconto;
- À vista no Dinheiro ou PIX, recebe 15% de desconto;
- Em duas vezes, preço normal de etiqueta sem juros;
- Acima de duas vezes, preço normal de etiqueta mais juros de 10%;
*/

let valorProduto = 1050.00;
const condiçãoPagamento = 1;

console.log("      Código Condição de pagamento:" <br>
            "1 - À vista Débito, recebe 10% de desconto;" <br>
            "2 - À vista no Dinheiro ou PIX, recebe 15% de desconto;"<br>
            "3 - Em duas vezes, preço normal de etiqueta sem juros;"<br>
            "4 - Acima de duas vezes, preço normal de etiqueta mais juros de 10%;");

if(condiçãoPagamento === 1){
    valorProduto = (valorProduto * 0.10) - valorProduto;
    console.log("À vista Débito, recebe 10% de desconto: " + valorProduto);
}else if(condiçãoPagamento === 2){
    valorProduto = (valorProduto * 0.15) - valorProduto;
    console.log("À vista no Dinheiro ou PIX, recebe 15% de desconto: " + valorProduto);
}else if(condiçãoPagamento === 3){
    console.log("Em duas vezes, preço normal de etiqueta sem juros: " + valorProduto);
}else if(condiçãoPagamento === 4){
    valorProduto = (valorProduto * 0.10) + valorProduto;
    console.log("Acima de duas vezes, preço normal de etiqueta mais juros de 10%: " + valorProduto)
}