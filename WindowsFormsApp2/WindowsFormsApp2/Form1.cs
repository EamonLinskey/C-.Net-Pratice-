using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] total = { 0, 0, 0, 0 };
        private void OkayButton_Click(object sender, EventArgs e)
        {
            int dept;
            double contribution;

            dept = Convert.ToInt32(deptTextBox.Text);
            contribution = Convert.ToDouble(ContTextBox.Text);

            --dept;
            total[dept] += contribution;

            deptTextBox.Text = "";
            ContTextBox.Text = "";
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Dept Total";
            for(int i = 0; i < total.Length; i++)
            {
                outputLabel.Text +=
                    String.Format("\n {0}{1,10}", i + 1, total[i].ToString("C"));
            }
        }
    }
}
