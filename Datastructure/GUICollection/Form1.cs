using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collections;
using Sets;

namespace GUICollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Set C = new ArraySet(1);

        private void button1_Click(object sender, EventArgs e)
        {
            C.add(textBox1.Text);
            textBox1.Clear();
            Updatelabel1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C.contains(textBox2.Text);
            message(textBox2.Text);
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C.remove(textBox3.Text);
            textBox3.Clear();
            Updatelabel1();
            
        }
        private void Updatelabel1()
        {
            label1.Text = "จำนวน"+C.size()+"คน";
        }
        private void message(object e)
        {
            
            if (C.contains(e))
            {
                MessageBox.Show("มีข้อมูล : "+ e );
            }
            else
            {
                MessageBox.Show("ไม่มีข้อมูล : " + e);
            }
        }
    }
}
