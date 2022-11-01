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
    public partial class Form2 : Form
    {
        int grandTotal;
        public Form2()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int inputNumber;

            inputNumber = int.Parse(enterNumberTextbox.Text);
           

            grandTotal += inputNumber;

            
            grandTotalTextbox.Text = grandTotal.ToString();

        }
    }
}
