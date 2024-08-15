import java.util.Scanner;
public class Math_powPA4_2_G2 {
    public static void main(String args[]) {
      Scanner input = new Scanner (System.in);
      System.out.print("Input P : ");
      int P = input.nextInt();
      System.out.print("Input r between 0-100 : ");
      int r1 = input.nextInt();
      System.out.print("Input t between 1-100 : ");
      int t = input.nextInt();
      
      double r = r1/100.0; 
      int n = 1;
      double A = P*Math.pow(1.0+(r/n),n*t);
      System.out.println("ค่า A เมื่อกำหนด t = "+t+" คือ "+A);
    }
}