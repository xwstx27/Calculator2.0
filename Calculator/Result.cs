namespace Calculator
{
    public class Result
    {
        public double ResultOfOper(string Oper, double num1, string text)
        {
            switch (Oper)
            {
                case "/":
                    num1 = num1 / Convert.ToDouble(text);
                    break;
                case "*":
                    num1 = num1 * Convert.ToDouble(text);
                    break;
                case "+":
                    num1 = num1 + Convert.ToDouble(text);
                    break;
                case "-":
                    num1 = num1 - Convert.ToDouble(text);
                    break;
                default:
                    num1 = Convert.ToDouble(text);
                    break;
            }
            return num1;
        }
        public string ResultForTextBox(double num0)
        {
            num0 = Math.Round(num0, 8);
            int a;
            if (num0 < 0)
            {
                a = 11 - Convert.ToString(num0).Length;
            }
            else
            {
                a = 10 - Convert.ToString(num0).Length;
            }
            if (a < 0)
            {
                num0 = Math.Round(num0, 8 + a);
            }
            return Convert.ToString(num0);
        }
    }
}
