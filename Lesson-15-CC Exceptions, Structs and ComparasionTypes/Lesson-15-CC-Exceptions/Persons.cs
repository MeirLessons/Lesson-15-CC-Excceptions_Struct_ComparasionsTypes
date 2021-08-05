using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15_CC_Exceptions
{
    public class Client
    {
        Waiter waiter;
        public int Age { get; set; }
        public string Name { get; set; }
        public Client(Waiter waiter, int age, string name)
        {
            this.waiter = waiter;
            Age = age;
            Name = name;
        }

        public void OrderDish()
        {
            try
            {
                Console.WriteLine("Client Order Dish");
                waiter.WriteOrder();
            }
            catch (OutOfPitotException ex)
            {
                Console.WriteLine(ex.StackTrace);

                if (ex.Message == "your dish is not valid right now.")
                {
                    Console.WriteLine(ex.StackTrace);
                    OrderDish();
                }
            }
        }

        public override string ToString()
        {
            return $"Age: {Age}. Name: {Name}";
        }
    }

    public class Waiter
    {
        ShiftManager shfMan;

        public Waiter(ShiftManager shfMan)
        {
            this.shfMan = shfMan;
        }

        public void WriteOrder()
        {
            //try
            //{

                Console.WriteLine("waiter pass the order to manager");
                shfMan.CallToChef();
            //}
            //catch (DishNotValidException ex)
            //{
            //    if (ex.Message == "no more pitot")
            //    {
            //        throw new DishNotValidException("your dish is not valid right now.", ex);
            //    }
            //}
        }
    }

    public class ShiftManager
    {
        Chef chef;

        public ShiftManager(Chef chef)
        {
            this.chef = chef;
        }

        public void CallToChef()
        {
            //try
            //{

                Console.WriteLine("manager call to chef");
                chef.MakeDish("pita+humus");
            //}
            //catch (OutOfPitotException ex)
            //{
            //    Console.WriteLine("send someone to buy more pitot...");
            //    Stock.Pitot += 20;
            //    throw new DishNotValidException("no more pitot");
            //}
        }
    }

    public class Chef
    {
        public void MakeDish(string dish)
        {
            //try
            //{
                switch (dish)
                {
                    case "pita+humus":
                        if (Stock.Pitot > 0)
                        {
                            Stock.Pitot--;
                            Console.WriteLine("Dish Is Ready");
                        }
                        else
                        {
                            throw new OutOfPitotException("no more pitot");
                        }
                        break;
                }
            //}
            //catch (OutOfPitotException ex)
            //{
            //    throw ex;
            //    //Console.WriteLine("buy");

            //}
        }
    }

    public static class Stock
    {
        public static int Pitot { get; set; }

        static Stock()
        {
            Pitot = 2;
        }
    }

}
