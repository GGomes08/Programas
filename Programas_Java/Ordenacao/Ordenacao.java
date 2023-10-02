package Programas_Java.Ordenacao;

/*
 * Crie um algoritmo para ordenar um conjunto de palavras pelo seu tamanho. 
 Seu programa deve receber um conjunto de palavras e retornar este mesmo conjunto ordenado pelo 
 tamanho das palavras decrescente, se o tamanho das palavras for igual, deve-se ordernar por ordem alfabética.

Entrada
A primeira linha da entrada possui um único inteiro N, 
que indica o número de casos de teste Os caracteres poderão ser espaços, letras, ou números.

Saída
A saída deve conter o conjunto de palavras da entrada ordenado pelo tamanho das palavras e 
caso o tamanho das palavras for igual, deve-se ordernar por ordem alfabética.. 
Um espaço em branco deve ser impresso entre duas palavras.

Exemplo da Entrada              
3                               
Top Coder comp Wedn at midnight 
one three five 
I love cpp C 
sj sa df r e w f d s v c x z sd fd a   

Exemplo da Saída
midnight coder three comp five love wedn cpp one top at c 
 */
import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

public class Ordenacao {

    public static void main(String[] args) throws FileNotFoundException, IOException {

        String acharTxt = "./Programas/Programas_Java/Ordenacao/OrdenaPalavras.txt";
        FileWriter saida = new FileWriter("./Programas/Programas_Java/Ordenacao/Ordenados.txt");
        String linhaLida;
        int linhas;
        List<String> palavras = new ArrayList<>();
        String lista = " ";

        try {
            FileReader lerTxt = new FileReader(acharTxt);
            BufferedReader lerPal = new BufferedReader(lerTxt);
            linhas = Integer.parseInt(lerPal.readLine());
            for (int i = 0; i < linhas; i++) {
                linhaLida = lerPal.readLine();
                palavras.addAll(Arrays.stream(linhaLida.split(" ")).collect(Collectors.toList()));
                lista = palavras.stream()
                        .sorted(Comparator.comparingInt(String::length).reversed().thenComparing(String::compareToIgnoreCase))
                        .collect(Collectors.joining(" "));
                lista = lista.toLowerCase();
                

            }
            saida.write(lista);
            lerPal.close();
            saida.close();

        } catch (Exception e) {
            System.out.println("A um erro em sua entrada/saida " + e.getMessage());
        }
        System.out.println(lista);
    }
}
