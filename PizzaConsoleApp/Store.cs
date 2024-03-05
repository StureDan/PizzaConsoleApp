using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaConsoleApp
{
    public class Store
    {

        public void Start()
        {

            //creating pizzas

            Pizza pizza1 = new Pizza("Pepperoni", 80);
            Pizza pizza2 = new Pizza("Helsíngør", 100);
            Pizza pizza3 = new Pizza("Monster Pizza", 120);

            //Creating customers
            Customer customer1 = new Customer("Mark Hansen", "30 14 28 30");
            Customer customer2 = new Customer("Jens Jensen", "41 28 30 99");
            Customer customer3 = new Customer("Hugh Mungus", "69 69 69 69");


            //Creating orders  

            Order order1 = new Order(pizza1, customer1);
            Order order2 = new Order(pizza2, customer2);
            Order order3 = new Order(pizza3, customer3);

            //printing out order information as well as total calculated price

            Console.WriteLine(order1);
            Console.WriteLine(order2); 
            Console.WriteLine(order3);


        }
    }
}
