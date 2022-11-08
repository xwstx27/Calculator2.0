namespace Calculator
{
    public partial class Main : Form
    {
        string Oper;
        public string tempParameter;
        public int i;
        double num1;




        public Main()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fold_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void TopPanel_Click(object sender, EventArgs e)
        {
            i++;
            if (i < 10)
            {
                string n = (sender as Button).Text;
                if (TextBox.Text == "0")
                {
                    TextBox.Clear();
                    TextBox.Text = TextBox.Text + n;
                }
                else
                {
                    TextBox.Text = TextBox.Text + n;
                }

            }

        }
        private void Fold_Click_1(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            i = 0;
            TextBox.Text = null;
            num1 = 0;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (Oper != null && TextBox.Text != "")
            {
                Result result = new Result();
                num1 = result.ResultOfOper(Oper, num1, TextBox.Text);
                TextBox.Text = Convert.ToString(num1);
            }
            Oper = (sender as Button).Text;
            if (TextBox.Text != "")
            {
                num1 = Convert.ToDouble(TextBox.Text);
            }

            TextBox.Text = null;
            i = 0;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            if (result.ResultOfOper(Oper, num1, TextBox.Text) < 999999999 && result.ResultOfOper(Oper, num1, TextBox.Text) > -999999999)
            {
                if (TextBox.Text != "")
                {
                    if (Oper != null)
                    {
                        TextBox.Text = result.ResultForTextBox(result.ResultOfOper(Oper, num1, TextBox.Text));
                        i = 0;
                        Oper = null;
                    }
                }
                else
                {
                    i = 0;
                    Oper = null;
                    TextBox.Text = Convert.ToString(result.ResultForTextBox(num1));
                }
            }
            else
            {
                i = 0;
                TextBox.Text = null;
                MessageBox.Show("Превышен лимит символов!");

            }
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "0" || TextBox.Text != "")
                TextBox.Text = Convert.ToString(-Convert.ToDouble(TextBox.Text));
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}