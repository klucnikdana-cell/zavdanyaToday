using System;
using System.Collections.Generic;
using System.Text;

namespace RefVal
{
    internal class Bank
    {
        private double _currentBalance;//поле класу
        private static double _bonus;

        public Bank(double initiaBalance)
        {
            _currentBalance = initiaBalance;
        }

        static Bank()
        {
            _bonus = 1.04;//initalize the static bobus
        }

        public double CurrentBalance//метод(setter,getter)
        {
            get {  return _currentBalance; } //getter
            set { _currentBalance = value; } //setter
        }
        public static double Bonus //статичний метод(setter,getter)
        {
            get { return _bonus;  }
            set { _bonus = value; }
        }

    }
}
