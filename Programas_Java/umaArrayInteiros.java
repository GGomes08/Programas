package Programas_Java;

public class umaArrayInteiros {

    /*
     * Dada uma array de números inteiros e um alvo inteiro, retorne os indices dos
     * dois números de forma que eles somam ao alvo.
     * 
     * Irei trazer 1(uma) abordagem por hora para esse exercicio, pretendo adicionar mais uma.
     */

     //Loop de dois For
    public int[] duasSoma(int[] numeros, int alvo) {
        for(int i=0; i<numeros.length; i++){
            for(int j=i+1; j<numeros.length; j++){
                if(numeros[j]== alvo-numeros[i]){
                    return new int[] {i,j};
                }
            }
        }
        //Retorna nulo se não tem solução
        return null;

    }

    //Com HashMap

}