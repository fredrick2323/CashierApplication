using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;


        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.item_discount = discount;
            discounted_price = 0;
            payment_amount = 0;
            change = 0;
        }
        public override double getTotalPrice()
        {

            discounted_price = item_price * (0.01 * item_discount);
            total_price = discounted_price * item_quantity;
            return total_price;
        }
        public override void setPayment(double amount)
        {
            payment_amount = amount;
        }
        public double getChange(double Total_amount)
        {
            change = payment_amount - Total_amount;
            return change;

        }
    }
}