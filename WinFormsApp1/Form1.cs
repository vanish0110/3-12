namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);

            

            double n;
            double a;
            double b;
            a = Math.Min(x*x + y, y-z);
            b = Math.Max(x * x, y);
            n = a / b;
            
            textBox4.Text += "Результат работы программы" + " Уткин И.А." + Environment.NewLine;
            textBox4.Text += "При Х =" + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При Y =" + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При Z =" + textBox3.Text + Environment.NewLine;
            textBox4.Text += "n=" + n.ToString() + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }
    }
}