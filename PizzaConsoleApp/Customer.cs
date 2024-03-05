using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaConsoleApp
{
    public class Customer
    {


        #region Instance Fields
        private string _name;
        private string _phonenumber;


        #endregion


        #region Constructers
        public Customer(string name, string phonenumber)
        {
            Name = name;
            Phonenumber = phonenumber;
        }

        #endregion


        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public string Phonenumber

        {
            get { return _phonenumber; }
            set { _phonenumber = value; }
        }


        #endregion


        #region Methods
        public override string ToString()
        {

        return $"Customer: {Name} Phonenumber: {Phonenumber}";

        }
        #endregion

    }



}