using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaConsoleApp
{
    public class Pizza
    {



        #region Instance Field
        string _name;
        int _price;
        #endregion


        #region Constructors 
        public Pizza(string name, int price)
        {
            _name = name;
            _price = price;
        }

        #endregion


        #region Properties
      
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        

        #region Methods

        public override string ToString()
        {
            return $"Pizza: {Name}, Price: {Price}";
        }

        #endregion


    }
}
