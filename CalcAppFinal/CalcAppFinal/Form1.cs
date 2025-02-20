using System;
using System.Windows.Forms;

namespace CalcAppFinal
{
    public partial class Form1 : Form
    {
        private double result = 0; // değişkenler atandı ve işlemleri devam etme karar yapısının ilk adımı atıldı.
        private string operation = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperationPerformed) // tüm rakamlar butonlara atandı
                textBox1.Clear();
            isOperationPerformed = false;
            textBox1.Text += ((Button)sender).Tag.ToString();
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            if (result != 0)
                PerformOperation(); //Önceki işlemi tamamlama
            operation = ((Button)sender).Tag.ToString();
            result = double.Parse(textBox1.Text);
            isOperationPerformed = true;

        }

        private void Equals_Click(object sender, EventArgs e)
        {
            PerformOperation(); //eşittir fonks.
            operation = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; //temizleme butonu fonks
            result = 0;
            operation = "";
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(".")) //birden fazla nokta koyulmasının önüne geçildi
                textBox1.Text += ".";
        }

        private void Negate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") // -1 ile çarparak yük değiştirme
                textBox1.Text = (double.Parse(textBox1.Text) * -1).ToString();
        }

        private void PerformOperation()
        {
            switch (operation) // methodlar özelliği il 6 işlem tek fonksiyonlar butonlara atandı
            {
                case "+": result += double.Parse(textBox1.Text); break;
                case "-": result -= double.Parse(textBox1.Text); break;
                case "*": result *= double.Parse(textBox1.Text); break;
                case "/": result /= double.Parse(textBox1.Text); break;
                case "%": result %= double.Parse(textBox1.Text); break;
                case "^": result = Math.Pow(result, double.Parse(textBox1.Text)); break;
            }
            textBox1.Text = result.ToString();
            isOperationPerformed = true;
        }
    }
}
