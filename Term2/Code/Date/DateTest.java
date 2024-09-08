public class DateTest { 
    public static void main(String[] args) { 
        Date date = new Date (20, 6, 2022); 

        System.out.println(date); 
        
        Date date1 = new Date(40,22,10000);
        System.out.println(date1);
        
        Date dateD = new Date(); // default constructor
        System.out.println(dateD);
        
        Date dateDay = new Date(11);
        System.out.println(dateDay);
        
        Date dateDayMonth = new Date(11,7);
        System.out.println(dateDayMonth);
        dateDayMonth.setYear(2024);
        System.out.println(dateDayMonth);

    } 

} 
