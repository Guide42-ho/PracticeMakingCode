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
using Lists;
using System.Xml.Linq;

namespace GUICollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List C = new ArrayList(1);

        private void Add_Click(object sender, EventArgs e)
        {
            if (!AddTextBox.Text.Equals("")) 
            {
                C.add(AddTextBox.Text);
                AddTextBox.Clear();
                UpdateQuantityLabel();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

            if (!AddTextBox.Text.Equals("")) 
            {
                C.contains(AddTextBox.Text);
                message(AddTextBox.Text);
                AddTextBox.Clear();
            }
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            C.remove(AddTextBox.Text);
            AddTextBox.Clear();
            UpdateQuantityLabel();
            
        }
        private void UpdateQuantityLabel()
        {
            QuantityLabel.Text = "จำนวน "+C.size()+" คน";
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
        private void GetIndex_Click(object sender, EventArgs e)
        {
            int index = Index();
            if (C.contains(index) || index == -2) 
            {
                MessageBox.Show("ต้องเป็นตัวเลขเท่านั้น");
            }
            if (index > C.size() || C.isEmpty()) 
            {
                MessageBox.Show("ไม่มีข้อมูลในตำแหน่งที่ : "+ ++index);
            }
            else
            {
                ShowTextBox.Text = (String)C.get(index);
            }
        }
        private void Set_Click(object sender, EventArgs e)
        {
            int index = Index();
            if (C.size() < index)
            {
                MessageBox.Show("ไม่มีข้อมูลที่จะแก้ไข");
            }
            if (index != -2 & !ShowTextBox.Text.Equals("")) 
            {
            C.set(index, ShowTextBox.Text);
            ShowTextBox.Clear();GetIndextextBox.Clear();
            }
            else 
            {
                MessageBox.Show("ต้องใส่ตำแหน่งและข้อมูลที่จะแก้ไข ");
            }
        }
        private int Index()
        {
            int index;
            if (int.TryParse(GetIndextextBox.Text, out index))
            {
                return --index;
            }
            else
            {
                return -2;
            }
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            NameAllListBox.Items.Clear();
            for (int i = 0; i < C.size(); i++) 
            {
                NameAllListBox.Items.Add(C.get(i));
            }
        }
    }
}
