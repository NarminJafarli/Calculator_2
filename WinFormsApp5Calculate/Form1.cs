using System.Data;
using System.Linq.Expressions;

namespace WinFormsApp5Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal Number1 = Convert.ToDecimal(textBox1.Text);
            Decimal Number2 = Convert.ToDecimal(textBox2.Text);
            Decimal total;
            string symbol = textBox3.Text;


            if (symbol == "+")
            {
                total = Number1 + Number2;
                label3.Text = total.ToString();
            }
            else if (symbol == "-")
            {
                total = Number1 - Number2;
                label3.Text = total.ToString();
            }
            else if (symbol == "*")
            {
                total = Number1 * Number2;
                label3.Text = total.ToString();
            }
            else if (symbol == "/")
            {
                total = Number1 / Number2;
                label3.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("operator daxil edin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            Button btn = (Button)sender;
            textBox3.Text += btn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            Button btn = (Button)sender;
            textBox3.Text += btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            Button btn = (Button)sender;
            textBox3.Text += btn.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            Button btn = (Button)sender;
            textBox3.Text += btn.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
