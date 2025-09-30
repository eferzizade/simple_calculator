namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double number1 = Convert.ToDouble(nb1.Text);
                double number2 = Convert.ToDouble(nb2.Text);
                string operations = operation.SelectedItem.ToString();
                double result = 0;

                if (operations == "+")
                {
                    result = number1 + number2;
                    string s = Convert.ToString(result);
                    MessageBox.Show("Nəticə: " + s);
                }
                else if (operations == "-")
                {
                    result = number1 - number2;
                    string s = Convert.ToString(result);
                    MessageBox.Show("Nəticə: " + s);
                }
                else if (operations == "*")
                {
                    result = number1 * number2;
                    string s = Convert.ToString(result);
                    MessageBox.Show("Nəticə: " + s);
                }
                else if (operations == "/")
                {
                    if (number2 != 0) { 
                        result = number1 / number2;
                        string s = Convert.ToString(result);
                        MessageBox.Show("Nəticə: " + s);
                    }
                    else
                    {
                        MessageBox.Show("0-a bölmək olmaz!");
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Zəhmət olmasa düzgün rəqəmlər daxil edin!");
            }

        }
    }
}
