/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author 6652300061
 */
public class Car implements Vehicle{

    @Override
    public void startEngine() {
        System.out.println("Vrooms Vrooms");
    }

    @Override
    public void stopEngine() {
        System.out.println("JoJO");
    }

    @Override
    public int getNumberOfWheels() {
        return 4;
    }
    
}
