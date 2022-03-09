namespace CalculatorFormsUI
{
    public partial class Form1 : Form
    {
        public string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += ","; // TODO: check if previous character is not a symbol
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!= string.Empty && textBox1.Text!=null)
            {
                textBox1.Text += "^";
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox1.Text != null)
            {
                textBox1.Text += "!"; // TODO: place symbol before last entry in the decimal array
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "=\n";
            //var a = new Calculation(); 
        }
    }
}