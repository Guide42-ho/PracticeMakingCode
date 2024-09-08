public class LoopWithArrayExample {
        public static void main(String[] args) {
        int[] numbers = {111, 222, 333, 444, 555};
        int sum = 0;
        for(int number : numbers){
            sum += number;
        }
            System.out.println(sum);
    }

}

