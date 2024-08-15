import java.util.Scanner; // import class Scanner
public class G2 {
    public static void main(String args[]) {
    
    Scanner inputInfo = new Scanner(System.in); //create scanner
        
        System.out.println("user prompt");
        System.out.print("input P : ");
        double P = inputInfo.nextDouble(); //get info P

        System.out.print("input r (0-100): ");
        double r = inputInfo.nextDouble(); //get info r
        double r_new = r*0.01 ;

        System.out.print("input t (1-100 C) : ");
        double t = inputInfo.nextDouble(); //get info t
        
        // info n = 1 
        int n = 1;
        
        // Process
        double A = P*Math.pow(1+(r_new/n),n*t); //output A
                System.out.println("ค่าAเมื่อกำหนดt=3คือ:"+A);

    }
}