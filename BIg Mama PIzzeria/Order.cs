using System;
using System.Collections.Generic;
using System.Text;

namespace BIg_Mama_PIzzeria
{
    class Order
    {
        private int _orderNo;
        private double totalPrice;
        private Pizza pizza;
        private Customers customers;


        public Order(int orderno, Pizza pizza, Customers customers) {

            _orderNo = orderno;
            this.pizza = pizza;
            CalculateTotalPrice(this.pizza.Price);
            this.customers = customers;


        }
        public Customers GetCustomers() {
            return customers;
        }

        public int OrderNo
        {
            get { return _orderNo; }
            set { _orderNo = value; }
        }

        public void CalculateTotalPrice(double price) {
            double totalPrice = price + 40;
            double taxes = 0.05 * price;
            this.totalPrice = totalPrice + taxes;

        }
        public double GetTotalPrice() {
            return this.totalPrice;
        }

        public override string ToString() {
            return "  Ordre nr.  :" + "( " + _orderNo + ") " + " (" + customers + ", ( " + pizza + ") " + " " + " = " + totalPrice + " kr. incl. taxes og delivery";
        }


    }
}
