/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Programas_Java.Dicionario;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

/*
Descrição do Problema:
Como a descrição original não foi achada, segue a logica,
Ler um Arquivo .txt
Guarda as palavras do txt em um Vetor com 1000 de posições
Compara palavras com o "compareToIgnoreCase" e ordena alfabeticamente
Se a palavra a mesma mas se encontra em maisculo, deixa ela minuscula
Conta quantas palavras foram apresentadas
Apresenta o Vetor com as palavras ordenadas
 */
public class TrabalhoDicionario {

    public static void main(String[] args) throws IOException {
        String acharDocumento = "./Programas/Programas_Java/Dicionario/TrabalhoDicio.txt";
        String linhaLida;
        String valorLinhas = "";
        try {
            FileReader lerDocumento = new FileReader(acharDocumento);
            BufferedReader lerCaracteres = new BufferedReader(lerDocumento);
            linhaLida = lerCaracteres.readLine();
            valorLinhas = linhaLida;

            while (linhaLida == null) {
                linhaLida = lerCaracteres.readLine();
                valorLinhas = valorLinhas + linhaLida;
            }
            lerDocumento.close();
      
        } catch (IOException falha) {
            System.out.println("A um erro em sua entrada/saida " + falha.getMessage());
        }
        String[] vetorPalavras = valorLinhas.split(" ", 1000);
        int contPalavras = 0;
        
        for (int b = 0; b < vetorPalavras.length - 1; b++) {
            for (int c = 0; c <= vetorPalavras.length - 2; c++) {
                if ((vetorPalavras[c + 1].compareToIgnoreCase(vetorPalavras[c]) < 0)) {
                    String aux = vetorPalavras[c];
                    vetorPalavras[c] = vetorPalavras[c + 1];
                    vetorPalavras[c + 1] = aux;

                }
            }
        }
        for (int a = 0; a < vetorPalavras.length; a++) {
            if (!vetorPalavras[a].equals(vetorPalavras[a].toLowerCase())) {
                vetorPalavras[a] = vetorPalavras[a].toLowerCase();
            }
            
            if (!vetorPalavras[a].equals(" ")) {
                contPalavras++;
            }
        }

            for (int i = 0; i < vetorPalavras.length; i++) {
                System.out.println(vetorPalavras[i]);
            }
            System.out.println("Foram apresentadas ao dicionário: " + contPalavras + " palavras");
            System.out.println("Programa Finalizado");

        }
    }

