namespace kalkulyatorOson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
                label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            label2.Text = label1.Text + " " + btn.Text;
            label1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label2.Text += " " + label1.Text + " =";
            string[] text = label2.Text.Split();
            double a = double.Parse(text[0]);
            double b = double.Parse(text[2]);
            switch(text[1])
            {
                case "+":
                    {
                        label1.Text = (a + b).ToString();
                        break;
                    }
                case "-":
                    {
                        label1.Text = (a - b).ToString();
                        break;
                    }
                case "*":
                    {
                        label1.Text = (a * b).ToString();
                        break;
                    }
                case "/":
                    {
                        label1.Text = (a / b).ToString();
                        break;
                    }
                case "%":
                    {
                        label1.Text = (a % b).ToString();
                        break;
                    }
                case "Sqrt":
                    {
                        label1.Text = (Math.Sqrt(a)).ToString();
                        break;
                    }
                case "^2":
                    {
                        label1.Text = (Math.Pow(a,2)).ToString();
                        break;
                    }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!label1.Text.Contains(","))
                label1.Text += ",";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            label2.Text = label1.Text + " " + btn.Text;
            label1.Text = "";
        }
    }
}