
using System;
using System.Reflection;
using System.Windows.Forms;

namespace SEIDChecksum
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();

            string productName = ((AssemblyProductAttribute)Assembly.GetExecutingAssembly().GetCustomAttribute(typeof(AssemblyProductAttribute))).Product;
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string fileVersion = ((AssemblyFileVersionAttribute)Assembly.GetExecutingAssembly().GetCustomAttribute(typeof(AssemblyFileVersionAttribute))).Version;
            Text = $"{productName} v{version}";
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            label_IDLength.Text = $"({textBox.Text.Length})";

            setCalcEnable();
        }

        private void checkBoxs_CheckedChanged(object sender, EventArgs e)
        {
            setCalcEnable();
        }

        private void button_Calc_Click(object sender, EventArgs e)
        {
            string input = textBox_ID.Text.Trim();
            int index= input.IndexOf(' ');
            while (index  > 0)
            {
                input = input.Remove(index, 1);
                index = input.IndexOf(' ');
            }
            string header = string.Empty;
            if (checkBox_hasHeader.Checked)
            {
                header = input.Substring(0, 8);
                input = input.Remove(0, 8);
            }
            if (checkBox_hasChecksum.Checked) input = input.Remove(input.Length - 1);

            textBox_ID.SelectAll();
            textBox_ID.Focus();
            textBox_IDWithChecksum.Text = header + input + luhn(input);
        }

        string luhn(string input)
        {
            int sum = 0;
            bool doubled = true;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                char c = input[i];
                int number;
                if (c < '0' || c > '9')
                    number = 0;
                else
                    number = Convert.ToByte(c) - '0';
                if (doubled)
                    sum += digitalSum(number * 2);
                else
                    sum += number;
                doubled = !doubled;
            }
            return $"{(10 - sum % 10) % 10}";
        }

        int digitalSum(int number)
        {
            if (number < 0 || number >= 100) return 0;
            if (number >= 10)
                return number / 10 + number % 10;
            else
                return number;
        }

        void setCalcEnable()
        {
            int minLength = 0;
            if (checkBox_hasHeader.Checked) minLength += 8;
            if (checkBox_hasChecksum.Checked) minLength += 1;
            button_Calc.Enabled = textBox_ID.Text.Length > minLength;
        }

        private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && button_Calc.Enabled)
                button_Calc_Click(button_Calc, new EventArgs());
        }
    }
}
