algoritmo "Gasolina"
// Fun��o :
// Autor : Mariana Santiago e Yuri Telis
// Data : 22/03/2023
// Se��o de Declara��es 
var
   comb : caracter
   pre, val, lit, desc : real
inicio
// Se��o de Comandos
   escreva ("Digite o tipo de combust�vel (A- �lcool; G- gasolina):")
   leia(comb)
   escreva ("Digite quantos litros vai abastecer: ")
   leia (lit)
   se (comb="A") entao
   se (lit<=20) entao
      pre:=4,90*lit
      desc:=(3/100)*pre
      val:=pre-desc
   senao
      pre:=4,90*lit
      desc:=(5/100)*pre
      val:=pre-desc
   fimse
   senao
        se (comb="G") entao
        se (lit<=20) entao
           pre:=5,50*lit
           desc:=(4/100)*pre
           val:=pre-desc
        senao
             pre:=5,50*lit
             desc:=(4/100)*pre
             val:=pre-desc
        fimse
        fimse
   fimse
   escreva ("O valor a pagar �:", val)
fimalgoritmo
