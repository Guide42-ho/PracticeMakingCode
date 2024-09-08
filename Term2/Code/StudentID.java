
import java.util.Scanner;

public class StudentID {
    public static void main(String[] args) {
        Scanner input = new Scanner (System.in);
        
        System.out.print("Student ID: ");
        String id =  input.nextLine();
            System.out.println("ID "+id);
            
            System.out.println(id.length());
        if (id.length()==10){
            System.out.println("Student ID is correct");
            
        }else{
            System.out.println("Please try again");
        }
    }
}
