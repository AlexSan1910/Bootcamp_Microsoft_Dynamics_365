/* 
Faça um programa para calcular o valor de uma viagem:

1 - preco do etanol.
2 - preco da Gasolina.
3 - definir qual combustivel.
4 - gasto medio do combustivel do carro por km.
5 - distancia em km da viagem.

Faça um calculo utilizando de uma figura de condição para definir o comsbutivel.
*/



const tipoCobustivel = "etanol";
const precoGasolina = 5.39;
const precoEtanol = 3.79;
const mediaGasto = 12;
const kmViagem = 100;

if(tipoCobustivel === "etanol"){
     valorGastoPorKmEtanol = precoCombustivel / mediaGasto;
     valorGastoPorKmEtanol = valorGastoPorKmEtanol * kmViagem;
     console.log("A viagem custará com etanol: " + valorGastoPorKmEtanol)
}else{
     valorGastoPorKmGasolina = precoCombustivel / mediaGasto;
     valorGastoPorKmGasolina = valorGastoPorKmGasolina * kmViagem;
     console.log("A viagem custará com etanol: " + valorGastoPorKmGasolina)
}