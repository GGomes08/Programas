package Programas_Java;

import java.util.Scanner;

public class validaFibonacci {
    public static void main(String[] args){
        //Números para fazer a logica de Fibonacci e o número que será usado para fazer a validação
        int num1 = 0, num2 = 1, num3 = 0, numValida;

        Scanner leitor = new Scanner(System.in);
        System.out.println("Validador de Fibonacci");
        System.out.println("Digite um número que se encontre na Sequencia de Fibonacci");

        numValida = leitor.nextInt();

        while(numValida > num3){
            num3 = num1 + num2;
            num1 = num2;
            num2 = num3;
        }

        if( numValida == 0){
            System.out.println("Se encontra na sequencia é seu proximo número é: "+ num2);
        }else if(numValida==num3){
            System.out.println("Se encontra");
        } else {
            System.out.println("Não faz parte");
        }
    }

    
}