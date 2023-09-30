/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Programas_Java.Compactador;

import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

/*
Descrição do Problema:
Quando um caractere não alfabético (diferente de letra) é encontrado no arquivo não compactado, ele
é copiado diretamente para o arquivo compactado. Quando uma palavra é encontrada no arquivo não
compactado, ela é copiada diretamente para o arquivo compactado apenas se esta for a primeira
ocorrência da palavra. Nesse caso, a palavra é colocada no início da lista de palavras. Se não for a
primeira ocorrência, a palavra não é copiada para o arquivo compactado, ao invés disso, sua posição
na lista é copiada no arquivo compactado e a palavra é movida para a cabeça da lista. A numeração da
lista começa em 1, ou seja, o início da lista tem a posição 1.

O objetivo deste trabalho é implementar um programa em Java que receba como entrada um arquivo
não compactado (texto) e gera como saída um arquivo compactado (texto). Como desafio, depois de
finalizar o objetivo do trabalho, tente fazer o contrário, ou seja, que receba como entrada um arquivo
compactado e gera a reprodução do arquivo original não compactado como saída. Para armazenar as
palavras do arquivo utilize um vetor de palavras (Strings), considere que na entrada teremos no máximo
1000 palavra diferentes.

Exercicio refeito com mais clareza e sem nenhum erro na descrição.
 */

public class Compactador {

    public static void Insere(String vet[], String x, int cont) {
        for (int i = vet.length - 1; i > 0; i--) {
            if (vet[i - 1] != null) {
                vet[i] = vet[i - 1];
                cont++;
            }
        }
        vet[0] = x;
    }

    public static boolean VerificaPalavra(String vet[], String a, int b) {
        if (a.equals(vet[b])) {
            return true;
        }
        return false;
    }

    public static int BuscaRecursiva(String vet[], String a, int b, int c) {
        if (c < b) {
            return -1;
        }
        if (a.equals(vet[b])) {
            return b;
        }
        return BuscaRecursiva(vet, a, b + 1, c);
    }

    public static void RemovePalavras(String vet[], int a) {
        if (a >= 0 && a < vet.length) {
            for (int i = a; i < vet.length - 1; i++) {
                vet[i] = vet[i + 1];
                vet[i + 1] = null;
            }
        }

        contPalavras--;

    }

    public static int contPalavras = 0;

    public static void main(String[] args) throws IOException {
        System.out.println("Seja Bem Vindo a Aplicação de compactar um arquivo texto");
        System.out.println("Iremos compactar o conteudo que se encontra no"
                + " arquivo texto nomeado como 'TrabalhoNaoCompactado'.");
        FileReader entrada = new FileReader(
                "./Programas/Programas_Java/Compactador/TrabalhoNaoCompactado.txt");
        FileWriter saida = new FileWriter("./Programas/Programas_Java/Compactador/TrabalhoCompactado.txt");
        String[] vet = new String[1000];
        char letra;
        int posicao = 0;
        String palavra = "";
        boolean verifica = false;
        System.out.println(
                "--------------------------------------------------------------------------------------------------");
        do {
            letra = (char) entrada.read();

            if (Character.isLetter(letra)) {
                palavra = palavra + letra;
            } else {
                if (palavra.length() != 0) {
                    posicao = BuscaRecursiva(vet, palavra, 0, vet.length - 1);
                    if (posicao == -1) {
                        saida.write(palavra);
                    }
                    if (posicao >= 0) {
                        verifica = VerificaPalavra(vet, palavra, posicao);
                        if (posicao >= 0 && verifica == true) {
                            RemovePalavras(vet, posicao);
                            saida.write(posicao + 1 + "");

                        }

                    }

                    Insere(vet, palavra, contPalavras);
                    palavra = "";
                }
                saida.write(letra);
            }
        } while (letra != '0');
        System.out.println("\n");
        System.out.println("---------------------------------------------------------------------------------");
        System.out.println("Por favor, verifique o 'TrabalhoCompactado.txt' localizado na Raiz do projeto!");

        entrada.close();
        saida.close();

    }
}
