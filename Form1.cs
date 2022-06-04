using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         for(int i = 0; i <10; i++)
            {
                listBox1.Items.Add(i);
            }
        
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < listBox1.Items.Count +1; i = i + 2)
            {
                int number = Convert.ToInt32(listBox1.Items[i]);
                if (number % 2 == 1)
                {
                    listBox2.Items.Add(number);
                }

            }
        }
    }
}
