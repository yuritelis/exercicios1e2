algoritmo "Voto"
// Função :
// Autor : Mariana Santiago e Yuri Telis
// Data : 22/03/2023
// Seção de Declarações 
var
   porcentjs, porcentmj, porcentjt, votototal, votojs, votomj, votojt : real
   voto : caracter
   i : inteiro
inicio
// Seção de Comandos
   i:=0
   enquanto (i>=0) faca
            escreval ("Digite o seu voto:")
            leia (voto)
            se (voto="José da Silva") ou (voto="js") entao
               votojs:=1
               enquanto (votojs>1) faca
               votojs:=votojs+1
            fimse
            se (voto="Maria Juruma") ou (voto="mj") entao
               votomj:=1
               enquanto (votomj>1) faca
               votomj:=votomj+1
            fimse
            se (voto="João da Tapioca") ou (voto="jt") entao
               votojt:=1
               enquanto (votojt>1) faca
               votojt:=votojt+1
            fimse
            votototal:=votomj+votojs+votojt
            porcent
            se (votojs>votomj) e (votojs>votojt) entao
               escreva ("O vencedor é: José da Silva, com", votojs, "votos totais e", porcent, "porcento dos votos. O total de pessoas que votaram foi:", votototal)
            senao
fimalgoritmo
