import java.util.Scanner;

public class  SimpleCalculation {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

            int [] nambers = new int[20];
            String [] unique =  new String[20];

            int TimeNamber = 0 ;
            int TimeUnique = 0 ;
            boolean condition = true ;
            boolean end = true;
            int i = 0 ;
            int q = 1 ;
            double p = 0 ;
  
            while ( end) {
                if ( condition ) {
                    int namber = input.nextInt();
                    nambers[TimeNamber] = namber ;
                    TimeNamber++;
                    condition = false ;
                } else {
                    input.nextLine();
                    String Unique = input.nextLine();
                    end = !Unique.equals("=");
                    unique[TimeUnique] = Unique ;
                    TimeUnique++;
                    condition = true ;
                }            
            }
            while ( i < (TimeUnique-1) ) { 
                if (i == 0) {
                    p = nambers[0];
                } 
                   switch (unique[i]) {
                       case "+" :
                           p += nambers[q];
                           break;
                        case "^":
                            p = Math.pow(p, nambers[q]);
                            break;
                        case "/":
                            p = p /  nambers[q];
                            break;  
                       default:
                           System.out.println("Error");
                   }                 
                q++;
                i++;               
            }
            System.out.println(p);
    }       
} 
                


             
         
             
            


            
            
        
                    
                

    
