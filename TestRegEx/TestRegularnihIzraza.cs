using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestRegEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                Search();
            }
            else
            {
                Replace();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                Search();
            }
            else
            {
                Replace();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                Search();
            }
            else
            {
                Replace();
            }
        }

        private void Search()
        {
            var text = textBox1.Text;
            var stringRegex = textBox2.Text;
            var regex = new Regex(stringRegex);
            var result = "";

            foreach (var item in regex.Matches(text))
            {
                result += item;
                result += "\n";
            }

            textBox4.Text = result;
        }

        private void Replace()
        {
            var text = textBox1.Text;
            var replacement = textBox3.Text;
            var stringRegex = textBox2.Text;
            var regex = new Regex(stringRegex);
            var result = regex.Replace(text, replacement);

            textBox4.Text = result;
        }
    }
}
