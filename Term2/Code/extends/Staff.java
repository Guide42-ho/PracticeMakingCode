/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author 6652300061
 */
public class Staff extends Person {
    private String school ;
    private double pay ;
    public Staff (String name,String address,String school,double pay ){
        super(name,address); // call person 
        this.pay=pay;
        this.school=school;
    }
    public String getSchool(){
        return school ;
        
    }
    public void setShool(String school){
        this.school = school ;
        
    }
    public double getpay(){
        return pay ;
        
    }
    public void setPay(double pay){
        this.pay = pay;
        
    }
    @Override
    public String toString(){
        return "Staff["+super.toString()+ String.format(",school=%s,pay=%.2f%n]",school,pay);
    } 
    public static void main(String arge[]){
        Staff kg = new Staff("dd","dfd","fddsdfd",421);
        System.out.println(kg.toString());
    }
}
