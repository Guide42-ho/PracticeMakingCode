import java.util.Scanner; // import scannee class
public class GradeCaculator {
    public static void main (String args[]){
        Scanner inputGrade = new Scanner(System.in); //create scanner
        
        System.out.print("input score1 : "); //show input score
        int score1 = inputGrade.nextInt(); // read input
        System.out.print("input score2 : "); 
        int score2 = inputGrade.nextInt();
        System.out.print("input score3 : "); 
        int score3 = inputGrade.nextInt();
        System.out.print("input score4 : "); 
        int score4 = inputGrade.nextInt();
        System.out.print("input score5 : "); 
        int score5 = inputGrade.nextInt();
        
        // average grade 
        double averaGerade = (score1+score2+score3+score4+score5)/5.0;
         System.out.println("The student's average grade is "+ averaGerade);
         
         // Cut grade
        if (averaGerade > 100 )
            System.out.print("Can't find the grade");
        else if ( averaGerade >= 90 && averaGerade <= 100)
            System.out.print("The student's letter grade is A.");
        else if ( averaGerade >= 80 && averaGerade <= 89)
            System.out.print("The student's letter grade is B.");
        else if ( averaGerade >= 70 && averaGerade <= 79)
            System.out.print("The student's letter grade is C.");
        else if ( averaGerade >= 60 && averaGerade <= 69)
            System.out.print("The student's letter grade is D.");
        else if (averaGerade <= 59)
            System.out.print("The student's letter grade is F.");
    
    }
}
