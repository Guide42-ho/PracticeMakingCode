import java.util.Scanner;
public class Math_powPA4_3_G3 {
    public static void main(String args[]) {
      Scanner input = new Scanner (System.in);
      System.out.print("Input P : ");
      int P = input.nextInt();
      System.out.print("Input i : ");
      int i1 = input.nextInt();
      System.out.print("Input n : ");
      int n1 = input.nextInt();
      
      double i = i1/100.0/12.0; 
      double n = n1*12.0;
      double M = P*(i*Math.pow(1.0+i,n)/(Math.pow(1.0+i,n)-1.0));
      System.out.println("M is "+Math.round(M)+" When P = "+P);
    }
}