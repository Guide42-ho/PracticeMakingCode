import java.util.Scanner;
public class PrimeNumber {
 public static void main(String args[]) {
     Scanner Input = new Scanner(System.in);
      System.out.print("input number : "); 
     int number = Input.nextInt();
    int prime = 0;
      if( number == 0 || number == 1 ) prime = 1;

      if( prime == 0 ) {
        for( int i=2; i<=(number/2); i++) {
          if( number % i == 0 ) {
            prime = 1;
            break;
          }
        }  
      }

      if( prime == 0 ) {
        System.out.println("This is prime number");
      } else {
        System.out.println("Not prime");
      }
      
      prime = 0;
    } 
  } 
