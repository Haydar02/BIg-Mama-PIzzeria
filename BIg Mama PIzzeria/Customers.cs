using System;
using System.Collections.Generic;
using System.Text;

namespace BIg_Mama_PIzzeria
{
    class Customers
    {
        private string  _name;
        private string _addresse;
        private int _tlfNo;
        private string _email;

        public Customers(string name, string addresse, int tlfNo, string email) {
            _name = name;
            _addresse = addresse;
            _tlfNo = tlfNo;
            _email = email;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Addresse
        {
            get { return _addresse; }
            set { _addresse = value; }
        }
        public int TlfNo
        {
            get { return _tlfNo; }
            set { _tlfNo = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        
        }
        public override string ToString() {
            return " Customers name : " + _name + " Delivery to :" + _addresse +",   Tlf.number is  : " + _tlfNo + "  ,  e-mail : " + _email;
        }
    }
}
