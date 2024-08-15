/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author John
 */
public class Array2Dshort {

    public static void main(String[] args) {
        int[][] matrix = {{1, 6, 11, 16},
        {2, 7, 12, 17},
        {3, 8, 13, 18},
        {4, 9, 14, 19},
        {5, 10, 15, 20}
        };
// Output Hint
        for (int[] matrix1 : matrix) { // datatype [] name : matrix
            for (int column = 0; column < matrix1.length; column++) {
                System.out.print(matrix1[column] + " ");
            }
            System.out.println();
        }

    }
}
