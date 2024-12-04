namespace MPG_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double miles;
            double gallons;
            double ans;

            miles = double.Parse(textBox1.Text);
            gallons = double.Parse(textBox2.Text);
            ans = miles / gallons;

            textBox3.Text = ans.ToString("n2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}