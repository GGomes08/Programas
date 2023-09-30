package Programas_Java.JogoCobra;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.FontMetrics;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.util.Random;

import javax.swing.*;

public class PainelCobra extends JPanel implements ActionListener {

    static final int LarguraTela = 500;
    static final int AlturaTela = 500;
    static final int TamanhoCubo = 25;
    static final int TamanhoUnidades = (LarguraTela * AlturaTela) / TamanhoCubo;
    static final int Atraso = 100;
    final int x[] = new int[TamanhoUnidades];
    final int y[] = new int[TamanhoUnidades];
    boolean comecou = false;
    int partesCobra = 3;
    int macaCome;
    int macaX;
    int macaY;
    char dir = 'S';
    Timer tempo;
    Random ale;

    PainelCobra() {
        this.setPreferredSize(new Dimension(LarguraTela, AlturaTela));
        this.setBackground(Color.lightGray);
        this.setFocusable(true);
        this.addKeyListener(new AdaptaTecla());
        ale = new Random();
        inicia();
    }

    public void inicia() {
        macaAparece();
        comecou = true;
        tempo = new Timer(Atraso, this);
        tempo.start();

    }

    public void pintarTela(Graphics graf) {
        if (comecou) {

            for (int i = 0; i < AlturaTela / TamanhoCubo; i++) {
                graf.drawLine(i * TamanhoCubo, 0, i * TamanhoCubo, AlturaTela);
                graf.drawLine(0, i * TamanhoCubo, LarguraTela, i * TamanhoCubo);
            }
            graf.setColor(Color.RED);
            graf.fillRect(macaX, macaY, TamanhoCubo, TamanhoCubo);

            for (int i = 0; i < partesCobra; i++) {
                if (i == 0) {
                    graf.setColor(Color.GREEN);
                    graf.fillRect(x[i], y[i], TamanhoCubo, TamanhoCubo);
                } else {
                    graf.setColor(new Color(45, 180, 0));
                    graf.fillRect(x[i], y[i], TamanhoCubo, TamanhoCubo);
                }
            }
            graf.setColor(Color.blue);
            graf.setFont(new Font("Ubuntu", Font.PLAIN, 40));
            FontMetrics fontPontua = getFontMetrics(graf.getFont());
            graf.drawString("Pontuação: " + macaCome,
                    (LarguraTela - fontPontua.stringWidth("Pontuação: " + macaCome)) / 2, graf.getFont().getSize());
        } else {
            termina(graf);
        }

    }

    public void paintComponent(Graphics graf) {
        super.paintComponent(graf);
        pintarTela(graf);

    }

    public void moverCobra() {
        for (int i = partesCobra; i > 0; i--) {
            x[i] = x[i - 1];
            y[i] = y[i - 1];

        }

        switch (dir) {
            case 'W':
                y[0] = y[0] - TamanhoCubo;
                break;
            case 'S':
                y[0] = y[0] + TamanhoCubo;
                break;
            case 'A':
                x[0] = x[0] - TamanhoCubo;
                break;
            case 'D':
                x[0] = x[0] + TamanhoCubo;
                break;
            default:
                break;
        }

    }

    public void macaAparece() {
        macaX = ale.nextInt((int) (LarguraTela / TamanhoCubo)) * TamanhoCubo;
        macaY = ale.nextInt((int) (AlturaTela / TamanhoCubo)) * TamanhoCubo;

    }

    public void termina(Graphics graf) {
        graf.setColor(Color.blue);
        graf.setFont(new Font("Ubuntu", Font.PLAIN, 40));
        FontMetrics fontPontua = getFontMetrics(graf.getFont());
        graf.drawString("Pontuação: " + macaCome, (LarguraTela - fontPontua.stringWidth("Pontuação: " + macaCome)) / 2,
                graf.getFont().getSize());
        graf.setColor(Color.red);
        graf.setFont(new Font("Ubuntu", Font.PLAIN, 50));
        FontMetrics fontFinal = getFontMetrics(graf.getFont());
        graf.drawString("Fim do Jogo", (LarguraTela - fontFinal.stringWidth("Fim do Jogo")) / 2, AlturaTela / 2);
        graf.setColor(Color.magenta);
        graf.setFont(new Font("Ubuntu", Font.PLAIN, 30));
        FontMetrics fontReinicia = getFontMetrics(graf.getFont());
        graf.drawString("Para reiniciar, aperte R",
                (LarguraTela - fontReinicia.stringWidth("Para reiniciar, aperte R")) / 2, 450);

    }

    public void comeuMaca() {
        if ((x[0] == macaX) && (y[0] == macaY)) {
            partesCobra++;
            macaCome++;
            macaAparece();
        }

    }

    public void verificaColi() {
        for (int i = partesCobra; i > 0; i--) {
            if ((x[0] == x[i]) && (y[0] == y[i])) {
                comecou = false;
            }
        }
        if (x[0] < 0 || x[0] > LarguraTela) {
            comecou = false;
        }
        if (y[0] < 0 || y[0] > AlturaTela) {
            comecou = false;
        }
        if (!comecou) {
            tempo.stop();
        }
    }

    public void reinicia() {
        setVisible(false);
        new TelaCobra();
    }

    public class AdaptaTecla extends KeyAdapter {
        @Override
        public void keyPressed(KeyEvent t) {
            switch (t.getKeyCode()) {
                case KeyEvent.VK_W:
                    if (dir != 'S') {
                        dir = 'W';
                    }
                    break;
                case KeyEvent.VK_S:
                    if (dir != 'W') {
                        dir = 'S';
                    }
                    break;
                case KeyEvent.VK_A:
                    if (dir != 'D') {
                        dir = 'A';
                    }
                    break;
                case KeyEvent.VK_D:
                    if (dir != 'A') {
                        dir = 'D';
                    }
                    break;
            }
            if (t.getKeyCode() == KeyEvent.VK_R) {
                reinicia();
            }
        }

    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (comecou) {
            moverCobra();
            verificaColi();
            comeuMaca();
        }
        repaint();

    }

}
