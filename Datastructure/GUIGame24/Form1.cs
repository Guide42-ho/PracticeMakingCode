using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collections;
using Lists;
using Stacks;

namespace GUIGame24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            random();
        }
        Random rand = new Random();
        List list = new ArrayList(5);
        int win = 0;
        private Button lastDisabledButton = null;
        // สุ่มตัวเลขให้กับปุ่ม
        private void random() 
        {        
            for (int i = 0; i < 4 ; i++)
            {
                list.add(i,rand.Next(1, 10));
            }
            Number();
        }
        // ตั้งค่าตัวเลขบนปุ่ม
        private void Number()
        {
            buttonNumber1.Text = list.get(0).ToString();
            buttonNumber2.Text = list.get(1).ToString();
            buttonNumber3.Text = list.get(2).ToString();
            buttonNumber4.Text = list.get(3).ToString();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
            textBox1.Clear();
        }
        // ฟังก์ชันรีเซ็ตค่า
        private void Reset()
        {
            // เปิดใช้งานทุกปุ่มตัวเลขอีกครั้ง
            buttonNumber1.Enabled = true;
            buttonNumber2.Enabled = true;
            buttonNumber3.Enabled = true;
            buttonNumber4.Enabled = true;

            lastDisabledButton = null;
        }
          
        private bool IsCorrectNumbersUsed()
        {
           // ดึงข้อมูลตัวเลขจาก textBox1 โดยแยกด้วยช่องว่าง
            string input = textBox1.Text;
            MatchCollection matches = Regex.Matches(input, @"\d+");

            // แปลง MatchCollection เป็นรายการตัวเลข
            List inputNumbers = new LinkedList();
            foreach (Match match in matches)
            {
                if (int.TryParse(match.Value ,out int num))
                {
                    inputNumbers.add(num);
                }
            }
            Stack CheckNumber = new ArrayStack(4);
            if (inputNumbers.size() == 4) 
            {
                for (int i = 0; i< inputNumbers.size(); i++)
                {
                    CheckNumber.push(list.get(i));
                    if (inputNumbers.contains(CheckNumber.peek()))
                    {
                        CheckNumber.pop();
                       // inputNumbers.remove(i);
                    }

                }
                return CheckNumber.isEmpty();
            }
            return false;


        }
    

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                list.set(i, rand.Next(1, 10));
            }
            Reset();
            Number();
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (!IsCorrectNumbersUsed())
            {
                MessageBox.Show("คุณต้องใช้ตัวเลขที่สุ่มมาให้ครบทั้ง 4 ตัวและไม่ใช่ตัวเลขอื่น", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // คำนวณโพสต์ฟิกและหาผลลัพธ์
                float n = ArrayStack.CalculatePostfix("(" + textBox1.Text + ")");
                
                // ตรวจสอบผลลัพธ์
                if (!(24 == n))
                {
                    MessageBox.Show("ผลลัพธ์ไม่เท่ากับ 24", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    listBox1.Items.Add(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("ผลลัพธ์: " + n.ToString(), "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label1.Text = "Win" + ++win;
                }
            }
            catch (Exception ex)
            {
                // แสดงข้อผิดพลาดหากการคำนวณล้มเหลว
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void settextBox()
        {  
            textBox1.Text += lastDisabledButton.Text ;
            lastDisabledButton.Enabled = false;
        }

        private void buttonNumber1_Click(object sender, EventArgs e)
        {
            lastDisabledButton = buttonNumber1;
            settextBox();
        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            lastDisabledButton = buttonNumber2;
            settextBox();
        }

        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            lastDisabledButton = buttonNumber3;
            settextBox();
        }

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            lastDisabledButton = buttonNumber4;
            settextBox();
        }

        private void buttonsymbol1_Click(object sender, EventArgs e)
        {
            textBox1.Text += buttonsymbol1.Text;
        }

        private void buttonsymbol2_Click(object sender, EventArgs e)
        {
            textBox1.Text += buttonsymbol2.Text;
        }

        private void buttonsymbol3_Click(object sender, EventArgs e)
        {
            textBox1.Text += buttonsymbol3.Text;
        }

        private void buttonsymbol4_Click(object sender, EventArgs e)
        {
            textBox1.Text += buttonsymbol4.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                textBox1.Text = selectedItem;
            }
            else
            {
                MessageBox.Show("กรุณาเลือกข้อมูลจาก ListBox");
            }
        }
    }
}
