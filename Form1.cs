using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppclasswork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string text1 = textBox1.Text.ToString();
            int textt = Convert.ToInt32(text1);
            string text2 = textBox2.Text.ToString();
            int textt2 = Convert.ToInt32(text2);
            listBox1.Items.Add(rnd.Next(textt, textt2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var i in listBox1.Items)
            {
                Convert.ToInt32(i);
                sum += (int)i;
            }
            double seredne = 0;
            
                 seredne = sum / listBox1.Items.Count;
            
            label1.Text += $"sum : {sum}\nseredne {seredne}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int index = listBox1.SelectedIndex;
            while (index != -1)
            {
                listBox1.Items.RemoveAt(index);
                index = listBox1.SelectedIndex;
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                int sum = 0;
            double seredne = 0;
                foreach (int name in listBox1.SelectedItems)
                {
                    sum = sum + name;
                    seredne = sum / listBox1.SelectedItems.Count;
                }
                label1.Text = $"Sum selected element {sum} \n seredne selected {seredne}";

            
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            listBox1.SelectionMode = (SelectionMode)domainUpDown1.SelectedItem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           var modes = Enum.GetValues(typeof(SelectionMode));
            domainUpDown1.Items.AddRange(modes);
            domainUpDown1.SelectedIndex = 1;
            listBox1.SelectionMode = SelectionMode.One;
        }
    }
}
