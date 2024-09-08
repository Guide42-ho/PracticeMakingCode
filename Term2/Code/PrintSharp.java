import java.util.Scanner;
public class PrintSharp {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
       
        
        System.out.print("input : ");
        int n = input.nextInt();
       

        for (int i = 0; i < n ; i++) {
            for (int j = 0; j < i + 1 ; j++) {
                System.out.print("#");
                
            }
            System.out.println("");
        }
    }
}