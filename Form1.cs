namespace calculator__
{
    public partial class Form1 : Form
    {
        bool multiply = false, plus = false, minus = false, devide = false;
        double num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void numclick(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) == 0)
                textBox1.Text = ((Button)sender).Text;
            else
                textBox1.Text += ((Button)sender).Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            multiply = true;
            textBox1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            minus = true;
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            plus = true;
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            devide = true;
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (multiply == true)
            {
                num2 = int.Parse(textBox1.Text) * num1;
                multiply = false;
                num1 = num2;
                textBox1.Text = num1.ToString();
            }
            else if (devide == true)
            {
                num2 = num1 / int.Parse(textBox1.Text);
                devide = false;
                num1 = num2;
                textBox1.Text = num1.ToString();
            }
            else if (plus == true)
            {
                num2 = int.Parse(textBox1.Text) * num1;
                plus = false;
                num1 = num2;
                textBox1.Text = num1.ToString();
            }
            if (minus == true)
            {
                num2 = num1 - int.Parse(textBox1.Text);
                minus = false;
                num1 = num2;
                textBox1.Text = num1.ToString();
            }
        }
    }
}
