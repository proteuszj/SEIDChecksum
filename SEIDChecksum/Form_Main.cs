
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
            button_Calc.Enabled = textBox.Text.Length > 40;
        }

        private void button_Calc_Click(object sender, EventArgs e)
        {
            string input = textBox_ID.Text;
            if (input.Length > 41) input = input.Substring(0, 41);
            int sum = 0;
            for (int i=0;i<input.Length;i++)
            {
                char c = input[i];
                int number;
                if (c < '0' || c > '9')
                    number = 0;
                else
                    number = Convert.ToByte(c) - '0';
                if (0 == (i % 2))
                    sum += digitalSum(number * 2);
                else
                    sum += number;
            }
            textBox_IDWithChecksum.Text = input + $"{(10 - sum % 10) % 10}";
        }

        int digitalSum(int number)
        {
            if (number < 0 || number >= 100) return 0;
            if (number >= 10)
                return number / 10 + number % 10;
            else
                return number;
        }
    }
}
