/* 
Faça um programa para calcular o valor de uma viagem:

1 - preco do combustivel.
2 - gasto medio do combustivel do carro por km.
3 - distancia em km da viagem.

Faça um calculo dos gastos dessa viagem..
*/


let precoCombustivel = 5.39;
let mediaGasto = 12;
let kmViagem = 100;

let valorGastoPorKm = precoCombustivel / mediaGasto;

let total = valorGastoPorKm * kmViagem;

console.log(total);