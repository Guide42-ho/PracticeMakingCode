public class Calculate {
    public static int sum(int x, int y){
         int sum = 0;
        for (int i = x; i <= y; i++) {
            sum += i;
        }
        return sum;
    }
        
    public static double calculateAverage(int [] a){
        int sum = 0;
        for (int x : a){
            sum+= x;
        }
    return (double) sum /a.length;

    }
    public static void main(String[] args) {

        System.out.println("Sum from 1 to 10 is "+sum(1,10));
        System.out.println("Sum from 20 to 30 is "+sum(20,30));
        System.out.println("Sum from 35 to 45 is "+sum(35,45));
        
        int [] Average = {1,2,3,4,5,6,7,8,9,10};
        System.out.println("Average: "+ calculateAverage(Average));

    }
}
