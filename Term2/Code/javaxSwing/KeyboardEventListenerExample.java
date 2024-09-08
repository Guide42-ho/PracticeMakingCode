import javax.swing.*;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;


public class KeyboardEventListenerExample extends JFrame implements KeyListener {
    private JTextArea textArea;

    public KeyboardEventListenerExample() {
        // Set the title of the frame
        setTitle("Keyboard Event Listener Example");

        // Set the size of the frame
        setSize(400, 300);

        // Specify the layout manager
        setLayout(new java.awt.BorderLayout());

        // Ensure the application exits when the frame is closed
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        // Create a text area
        textArea = new JTextArea();
        textArea.addKeyListener(this);

        // Add the text area to the frame
        add(new JScrollPane(textArea), java.awt.BorderLayout.CENTER);
    }

    @Override
    public void keyTyped(KeyEvent e) {
        // Not used in this example
    }

    @Override
    public void keyPressed(KeyEvent e) {
        // Print the key that was pressed
        System.out.println("Key Pressed: " + e.getKeyChar());
        System.out.println("Key code: " + e.getKeyCode());
        //System.out.println(e);
        char keyChar = e.getKeyChar();
        switch (keyChar) {
            case 'a':
                System.out.println("Key 'a' was pressed.");
                break;
            case 's':
                System.out.println("Key 's' was pressed.");
                break;
            case 'd':
                System.out.println("Key 'd' was pressed.");
                break;
            case 'w':
                System.out.println("Key 'w' was pressed.");
                break;
        }
    
    }

    @Override
    public void keyReleased(KeyEvent e) {
        // Not used in this example
        
    }

    public static void main(String[] args) {
        // Create an instance of the KeyboardEventListenerExample class
        KeyboardEventListenerExample frame = new KeyboardEventListenerExample();

        // Make the frame visible
        frame.setVisible(true);
    }
}
