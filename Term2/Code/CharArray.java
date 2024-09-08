import java.util.Scanner;
public class CharArray {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("input : ");
        String n = input.nextLine();
        char [] a = n.toCharArray();
        
        for (int i = 0; i < a.length ; i++) {
            System.out.println(a[i]);

        }

    }
}