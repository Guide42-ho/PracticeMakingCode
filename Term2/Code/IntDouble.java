
import java.util.Arrays;
import java.util.Scanner;

public class IntDouble {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
       
        int sizearray = 2 ;
        double[] array = new double[sizearray] ;

            for (int i = 0; i < array.length; i++) 
           {
                System.out.println("Input Integer number: ");
                double a = input.nextDouble();
                array[i] = a ;

            }
            
        Arrays.sort(array);
            for (int i = array.length - 1 ; i>= 0 ; i--) 
            {
                System.out.print( array[i] ) ;
                System.out.print(" ");
            }
                  
              
    }
}