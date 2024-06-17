using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using System.Diagnostics.Metrics;

namespace Homework_7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int shift = Convert.ToInt32(textBox3.Text);
            if (shift < 1 || shift > 25)
            {
                MessageBox.Show("Не коректне значення! Введіть зсув від 1 до 25.");
            }

            string text = textBox1.Text.ToLower();
            char letter;
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {

                int temp = Convert.ToInt32(text[i]);
                if (temp != 32)
                {
                    temp += shift;
                }

                if (temp > 122)
                {
                    temp -= 26;

                }
                
                letter = Convert.ToChar(temp);
                result += letter;
            }



            textBox2.Text = result;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "3";
        }


    }
}