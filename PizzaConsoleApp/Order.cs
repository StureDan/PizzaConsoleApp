using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaConsoleApp
{
    public class Order
    {


        #region Instance Fields

        double _TaxPct; 
        int _DeliveryCosts;
        Pizza _pizza;
        Customer _customer;

        #endregion

        #region Constructers
        public Order(Pizza pizza, Customer customer)
        {
            _pizza = pizza;
            Customer = customer;
            TaxPct = 0.75;
            DeliveryCosts = 45;

        }



        #endregion


        #region Properties
        double TaxPct
        {
            get { return _TaxPct; }
            set { _TaxPct = value; }
        }

        int DeliveryCosts
        {
            get { return _DeliveryCosts; }
            set { _DeliveryCosts = value; }
        }
        public Pizza Pizza
        {
            get { return _pizza; }
            set { _pizza = value; }
        }
        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }


        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{Customer.ToString()}, {Pizza.ToString()}, Total Price: {CalculateTotalPrice()} kr.";
        }

        public double CalculateTotalPrice()
        {
            return Pizza.Price + (Pizza.Price * TaxPct) + DeliveryCosts;
        }


        #endregion

    }
}
