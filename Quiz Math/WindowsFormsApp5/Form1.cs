using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int addend1;
        int addend2;
        int timeLeft;
        int minuend;
        int subtrahend;
        int multiplicand;
        int multiplier;
        int dividend;
        int divisor;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void StartTheQuiz()
        {   //variables
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;

            //
            PlusLeftLabel.Text = addend1.ToString();
            PlusRightLabel.Text = addend2.ToString();
            MinusLeftLabel.Text = minuend.ToString();
            MinusRightLabel.Text = subtrahend.ToString();
            TimesLeftLabel.Text = multiplicand.ToString();
            TimesRightLabel.Text = multiplier.ToString();
            DevidedLeftLabel.Text = dividend.ToString();
            DevidedRightLabel.Text = divisor.ToString();

            //
            Sum.Value = 0;
            Difference.Value = 0;
            Product.Value = 0;
            Quotient.Value = 0;

            //start the timer
            timeLeft = 30;
            TimeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            button1.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You've got all the answers right!", "Congratulations!");
                button1.Enabled = true;
            }
            else if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                TimeLabel.Text = timeLeft + "seconds";
            }
            else
            {
                timer1.Stop();
                TimeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                Sum.Value = addend1 + addend2;
                Difference.Value = minuend + subtrahend;
                Product.Value = multiplicand * multiplier;
                Quotient.Value = dividend / divisor;
                button1.Enabled = true;
            }
            if(timeLeft <=5)
            {
                TimeLabel.BackColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == Sum.Value)
                &&(minuend-subtrahend ==Difference.Value)
                &&(multiplicand*multiplier ==Product.Value)
                &&(dividend/divisor ==Quotient.Value))
                return true;
            else
                return false;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if(answerBox !=null)
            {
                int lenghtOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lenghtOfAnswer);
            }
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
