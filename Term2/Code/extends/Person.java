/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author 6652300061
 */
public class Person {
    private final String name ;
    private String address ;
    public Person (String name , String address){
        this.address = address ;
        this.name = name ;
    }
    public String getName(){
        return name ;
    }
    public String getaddress(){
        return address ;
    }
    public void  setAddress(String address){
        this.address = address ;
    }
    @Override
    public String toString(){
        return  String.format("Person[name=%s,address=%s]",name,address); 
    }
    public static void main(String arge[]){
        Person kg = new Person("dd","dfd");
        System.out.println(kg.toString());
    }
}
