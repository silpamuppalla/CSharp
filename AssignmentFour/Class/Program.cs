using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Food   //Food Class
    {

        public int price;   //State of the food Class
        public string nameOfFood;

        //There is no functionality implemented here for the class
        static void Main(string[] args)
        {
            Food myFood = new Food(); //Object Instantiation with new keyword

            myFood.price = 12;
            myFood.nameOfFood = "Fruit Salad";

            Console.WriteLine(" Name: {0} and Price is: ${1} dollars", myFood.nameOfFood, myFood.price);
            Console.ReadLine();
        } 
    }
}
