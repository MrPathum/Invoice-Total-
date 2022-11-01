using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{   
    public partial class Form1 : Form
    {
        double grandTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Total = double.Parse(invoiceTextbox.Text);
            double discountPresnt = double.Parse(discountPresentTextbox.Text);
            discountPresnt = discountPresnt / 100;
            double discountAmount = Total * discountPresnt;
            double netAmount = Total - discountAmount;

            discountPresentTextbox.Text = discountPresnt.ToString("p1");
            discountAmountTextbox.Text = discountAmount.ToString("N");
            invoiceTextbox.Text = Total.ToString("c");
            netAmountTextbox.Text = netAmount.ToString("C");

            grandTotal += netAmount;
            grandTotalTextbox.Text = grandTotal.ToString("c");


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            invoiceTextbox.Clear();
            discountPresentTextbox.Clear();
            discountAmountTextbox.Clear();
            netAmountTextbox.Clear();
            invoiceTextbox.Focus();
            grandTotalTextbox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grandTotalTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
