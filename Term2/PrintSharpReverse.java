import java.util.Scanner;
public class PrintSharpReverse {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        
        System.out.print("input : ");
        int n = input.nextInt();

        for (int i = n; 0 < n ; n--) {
            for (int j = 0; j < n ; j++) {
                
                System.out.print("#");
                
            }
            System.out.println("");
        
        }
    }
}