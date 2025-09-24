import java.io.FileWriter;
import java.io.IOException;
import java.io.FileReader;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws IOException {

        Scanner sc = new Scanner(System.in);
        System.out.println("Escribe un texto :");
        String text = sc.nextLine();
        // Cambia vocales por la letra 'i'
        text = text.replace('a', 'i').replace('e', 'i').replace('o', 'i').replace('u', 'i');
        System.out.println(text);
        sc.close();
        // Escribe los textos en un fichero, en el mismo directorio i carpeta que el proyecto
        FileWriter writer = new FileWriter("C:\\Users\\usuari\\Desktop\\DAM2\\UF1\\Fitxer\\fitxer.txt");
        writer.write(text);
        writer.close();

    }
}