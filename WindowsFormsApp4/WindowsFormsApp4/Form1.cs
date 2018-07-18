using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Font bigFont = new System.Drawing.Font("Times New Roman", 12F);
            label1.Font = bigFont;
            button1.Font = bigFont;
            button1.Text = "You clicked me";
            label1.BackColor = System.Drawing.Color.Blue;
            label1.ForeColor = System.Drawing.Color.DarkOrange;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://google.com");
            linkLabel1.LinkVisited = true;
        }

        double price = 11.99;
        const double ToppingPrice = 1.50;
        const double deliveryPrice = 3.00;

        private void onionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (onionCheckBox.Checked)
            {
                price += ToppingPrice;
            }
            else
            {
                price -= ToppingPrice;
            }
            priceLabel.Text = "Total Price:" + price.ToString("C");
        }

        private void pepperoniCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (pepperoniCheckBox.Checked)
                {
                    price += ToppingPrice;
                }
                else
                {
                    price -= ToppingPrice;
                }
                priceLabel.Text = "Total Price:" + price.ToString("C");
            }
        }


        private void frogLegsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (frogLegsCheckBox.Checked)
            {
                price += ToppingPrice;
            }
            else
            {
                price -= ToppingPrice;
            }
            priceLabel.Text = "Total Price:" + price.ToString("C");
        }

        private void tooMuchCheeseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tooMuchCheeseCheckBox.Checked)
            {
                price += ToppingPrice;
            }
            else
            {
                price -= ToppingPrice;
            }
            priceLabel.Text = "Total Price:" + price.ToString("C");
        }

        private void deliveryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Total Price:" + price.ToString("C");
        }

        private void dineInRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Total Price:" + price.ToString("C");
        }

        private void deliveryRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (deliveryRadioButton3.Checked)
            {
                price += deliveryPrice;
            }
            else
            {
                price -= deliveryPrice;
            }
            priceLabel.Text = "Total Price:" + price.ToString("C");

        }

        private void donateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Total Price:" + price.ToString("C");
        }

        bool isSpecialty= false;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSpecialty && listBox1.SelectedIndex == 0)
            {
                price -= 5.00;
            }

            if(!isSpecialty && listBox1.SelectedIndex > 0)
            {
                price += 5.00;
            }

            if (listBox1.SelectedIndex > 0)
            {
                isSpecialty = true;
            }
            else
            {
                isSpecialty = false;
            }

            priceLabel.Text = "Total Price:" + price.ToString("C");
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
