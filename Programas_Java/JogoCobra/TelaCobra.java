package Programas_Java.JogoCobra;


import javax.swing.JFrame;

public class TelaCobra extends JFrame {

    TelaCobra(){
       
        this.add(new PainelCobra());
        this.setTitle("Cobrita");
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setResizable(true);
        this.setVisible(true);
        this.setLocation(400, 100);
        this.pack();
        
    }

    
}
