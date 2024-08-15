/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */


import java.util.Scanner;

/**
 *
 * @author John
 */
public class Array2DInput {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Input 5 row 4 column : ");
        int matrix[][] = new int[5][4];
        for (int row = 0; row < matrix.length; row++) {

            for (int column = 0; column < matrix[row].length; column++) {
                matrix[row][column] = input.nextInt();
            }

        }

    }

}
