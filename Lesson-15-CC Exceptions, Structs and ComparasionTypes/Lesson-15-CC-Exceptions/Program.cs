using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15_CC_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Chef c = new Chef();
            ShiftManager sm = new ShiftManager(c);
            Waiter w = new Waiter(sm);
            Client cl = new Client(w,18,"Moshe");

            cl.OrderDish();
            cl.OrderDish();
            cl.OrderDish();

            //foreach loop
            Client[] clients = new Client[3] { new Client(w,2,"1"), new Client(w, 4, "3"), new Client(w, 8, "momo") };
            foreach (Client currentClient in clients)
            {
                currentClient.OrderDish();
                Console.WriteLine(currentClient);
            }

            //int[] arr = new int[] { 0, 1, 23, 4, 5, 6, 7, 8, 3, 2 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = 5;
            //}












            try
            {
                int age = int.Parse(Console.ReadLine());
                if (age < 1)
                {
                    MyClass c1 = new MyClass();
                    //way 1
                    LowerThanOneException ex = new LowerThanOneException("input number larger than 1");
                    ArgumentException ex2 = new ArgumentException("Invalid Number", ex);
                    throw ex2;

                    //way 2
                    throw new LowerThanOneException("input number larger than 1");
                }
            }
            catch (LowerThanOneException exp)
            {
                Console.WriteLine();
            }
            catch (ArgumentException exp)
            {
                Console.WriteLine(exp.Message);
                Console.WriteLine(exp.InnerException.Message);
            }















            try
            {
                //MyClass myClass = null;
                //myClass.MyProperty = 3;
                Console.WriteLine("Open File");
                Foo();
                return;
                //Console.WriteLine("Open File");

                //DivideByZeroException dicExc = new DivideByZeroException("ניסון לחלק ב0");
                //throw dicExc;
            }
            catch (DivideByZeroException ex) when (DateTime.Now.Hour > 20)
            {
                Console.WriteLine("div By Zero " + ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Close File");

                Console.WriteLine("From Null Exception");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Close File");

                Console.WriteLine("rest exceptions");
            }
            finally
            {
                Console.WriteLine("Close File");
            }
        }

        static void Foo()
        {
            try
            {
                int x = 0;
                //Console.WriteLine(12 / x);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Args Exc");
            }
            finally
            {
                Console.WriteLine("Close File");
            }
        }
    }

    class MyClass
    {
        public int MyProperty { get; set; }
    }
}
