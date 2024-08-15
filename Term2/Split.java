import java.util.Scanner;
public class  Split{
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("input : ");
        String a = input.nextLine();
        String [] texts = a.split("-");

        for (String text : texts ) {
            System.out.print(text);
            
        }
    }
}