public class Date {

    /// instance variables
    private int day;
    private int month;
    private int year;

    // Constructor
    public Date(){ // Default Constructor
        
        this(0,0,0); // day = 0, month = 0, year = 0
    }
    public Date(int day) {
    
        this(day,0,0);
    }
    public Date(int day, int month) {
    
        this(day,month,0);
    }
    
    public Date(int day, int month, int year) {

        setDate(day, month, year);

    }

    // GET - Accessor Method 
    public int getDay() {

        return day;
    }

    public int getMonth() {
        return month;
    }

    public int getYear() {
        return year;
    }

    // SET - Mutator Method
    public void setDay(int day) {

        if (day >= 1 && day <= 31) {
            this.day = day;
        }
    }

    public void setMonth(int month) {
        if (month >= 1 && month <= 12) {
            this.month = month;
        }
    }

    public void setYear(int year) {

        if (year >= 1900 && year <= 9999) {
            this.year = year;
        }
    }

    public void setDate(int day, int month, int year) {

        setDay(day);
        setMonth(month);
        setYear(year);
    }

    @Override
    public String toString() {
        return String.format("%02d/%02d/%04d%n", day, month, year);
    }

}
