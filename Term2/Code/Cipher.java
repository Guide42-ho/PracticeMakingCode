import java.util.Scanner;

public class Cipher {

    // เมทอดสำหรับเข้ารหัสข้อความด้วยซีเซอร์
    public static String encrypt(String plaintext, int shiftKey) {
        StringBuilder ciphertext = new StringBuilder();

        for (int i = 0; i < plaintext.length(); i++) {
            char ch = plaintext.charAt(i);

            // เช็คว่าเป็นตัวอักษรที่อยู่ในช่วง A-Z
            if (Character.isUpperCase(ch)) {
                char encryptedChar = Character.toLowerCase((char) ((ch + shiftKey - 'A') % 26 + 'A'));
                ciphertext.append(encryptedChar);
            }
            // เช็คว่าเป็นตัวอักษรที่อยู่ในช่วง a-z
            else if (Character.isLowerCase(ch)) {
                char encryptedChar = Character.toUpperCase((char) ((ch + shiftKey - 'a') % 26 + 'a'));
                ciphertext.append(encryptedChar);
            }
            // ถ้าไม่ใช่ตัวอักษรให้เก็บไว้เหมือนเดิม
            else {
                ciphertext.append(ch);
            }
        }

        return ciphertext.toString();
    }
  
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter plaintext: ");
        String plaintext = scanner.nextLine();

        System.out.print("key (-100 - 100): ");
        int shiftKey = scanner.nextInt();

        if (shiftKey >= -100 && shiftKey <= 100 ) {
            // เข้ารหัสข้อความ    
            String encryptedText = encrypt(plaintext, shiftKey);
            System.out.println("Encrypted text: " + encryptedText);
        } else {
            System.out.println("Error");
        }

        scanner.close();
    }
}
