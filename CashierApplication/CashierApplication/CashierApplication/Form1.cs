using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private double total_amount;


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            double paymentRecieved = Convert.ToDouble(textBox5.Text);

            DiscountedItem discountedItem = new DiscountedItem("", 0, 0, 0);
            discountedItem.setPayment(paymentRecieved);
            double change = discountedItem.getChange(total_amount);
            label9.Text = change.ToString("0.00");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string item_name = textBox1.Text;
            double item_price = Convert.ToDouble(textBox2.Text);
            double item_discount = Convert.ToDouble(textBox3.Text);
            int item_quantity = Convert.ToInt32(textBox4.Text);

            DiscountedItem discountedItem = new DiscountedItem(item_name, item_price, item_quantity, item_discount);
            total_amount = discountedItem.getTotalPrice();
            label8.Text = total_amount.ToString("0.00");


        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}