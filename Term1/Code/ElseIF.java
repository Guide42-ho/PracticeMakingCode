import java.util.Scanner; // import scanner class 
public class ElseIF {
    public static void main (String args[] ){
        Scanner input = new Scanner(System.in);  //  creaate scanner info
        System.out.print("input number : "); // show input number 
        
        double number =  input.nextDouble(); // Read input
        //System.out.print(number); //check number
        
        if ( number>0 )
            System.out.println(number + " The number is positive."); //เต็มบวก
        else if ( number < 0)
            System.out.println(number + " The number is negative.");//เต็มลบ
        else if (number == 0 )
            System.out.println(number + " The number is zero.");//0

        
        
    }
}
