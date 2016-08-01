using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace easySum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            lblVersion.Text += "30";
=======
            lblVersion.Text += "26";
>>>>>>> 126b215dd22d5a51abbeee3330e42d8b2a1271c2
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(tbFirst.Text);
                double b = Convert.ToDouble(tbSecond.Text);
                tbSum.Text = (a + b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("invalid input");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirst.Text = "";
            tbSecond.Text = "";
            tbSum.Text = "";
        }

    }
}
