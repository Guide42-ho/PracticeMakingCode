import java.util.Scanner; // import class Scanner
public class G3 {
    public static void main(String args[]) {
    
    Scanner inputInfo = new Scanner(System.in); //create scanner
        
        System.out.println("user prompt");
        System.out.print("input P : ");
        double P = inputInfo.nextDouble(); //get info P

        System.out.print("input i : ");
        double i = inputInfo.nextDouble(); //get info i
        double i_new = (i*0.01)/12; 

        System.out.print("input n : ");
        double n = inputInfo.nextDouble(); //get info n
        double n_new = n*12;

        // Process
        double M = P*i_new*Math.pow(1+i_new,n_new)/(Math.pow(1+i_new,n_new)-1); //output M
                System.out.println("M is " + Math.round(M) + " When P = " + P);

    }
}