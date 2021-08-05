using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisions_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass
            {
                Age = 5,
                Name = "asd"
            };
            MyClass m2 = new MyClass
            {
                Age = 5,
                Name = "12123"
            };

            Console.WriteLine(m == m2);

            //************************************************************************** virtual a.Equals(b):
            ////reference type
            //MyClass mc1 = new MyClass() { Age = 5 };//#1273
            //MyClass mc2 = new MyClass() { Age = 5 };//#4523
            //MyClass mc3 = mc1;//#1273
            //Console.WriteLine(mc1.Equals(mc2));//Output: false (reference comparison)
            //Console.WriteLine(mc1.Equals(mc3));//Output: true (reference comparison)

            ////value type
            //int i1 = 3;//3
            //int i2 = 3;//3
            //int i3 = i1;//3
            //Console.WriteLine(i1.Equals(i2));//Output: true (values comparison)
            //Console.WriteLine(i1.Equals(i3));//Output: true (values comparison)

            ////complex type
            //string s1 = "test";//test
            //string s2 = "test";//test
            //string s3 = s1;//test
            //Console.WriteLine(s1.Equals(s2));//Output: true (values comparison)
            //Console.WriteLine(s1.Equals(s3));//Output: true (values comparison)

            //************************************************************************** static object.Equals(a,b):(AreEquals Method)

            ////reference type
            //MyClass mc1 = new MyClass() { Age = 5 };
            //MyClass mc2 = new MyClass() { Age = 5 };
            //MyClass mc3 = mc1;
            //Console.WriteLine(object.Equals(mc1, mc2));//Output: false (reference comparsion)
            //Console.WriteLine(object.Equals(mc1, mc3));//Output: true (reference comparsion)
            ////value type
            //int i1 = 3;
            //int i2 = 3;
            //int i3 = i1;
            //Console.WriteLine(object.Equals(i1, i2));//Output: true (values comparsion)
            //Console.WriteLine(object.Equals(i1, i3));//Output: true (values comparsion)
            ////complex type
            //string s1 = "test";
            //string s2 = "test";
            //string s3 = s1;
            //Console.WriteLine(object.Equals(s1, s2));//Output: true (values comparsion)
            //Console.WriteLine(object.Equals(s1, s3));//Output: true (values comparsion)

            //************************************************************************** static object.ReferenceEquals(a,b)

            ////reference type
            //MyClass mc1 = new MyClass() { Age = 5 };
            //MyClass mc2 = new MyClass() { Age = 5 };
            //MyClass mc3 = mc1;
            //Console.WriteLine(object.ReferenceEquals(mc1, mc2));//Output: false (reference comparison)
            //Console.WriteLine(object.ReferenceEquals(mc1, mc3));//Output: true (reference comparison)
            ////value type
            //int i1 = 3;
            //int i2 = 3;
            //int i3 = i1;
            //Console.WriteLine(object.ReferenceEquals(i1, i2));//Output: false (boxing and then compare by references)
            //Console.WriteLine(object.ReferenceEquals(i1, i3));//Output: false (boxing and then compare by references)
            ////complex type
            //string s1 = "test";
            //string s2 = "test";
            //string s3 = s1;
            //Console.WriteLine(object.ReferenceEquals(s1, s2));//Output: true (reference comparison but used the pool)
            //Console.WriteLine(object.ReferenceEquals(s1, s3));//Output: true (reference comparison but used the pool)

            //************************************************************************** operator '=='
            ////reference type
            //MyClass mc1 = new MyClass() { Age = 5 };
            //MyClass mc2 = new MyClass() { Age = 5 };
            //MyClass mc3 = mc1;
            //Console.WriteLine(mc1 == mc2);//Output: false (reference comparison)
            //Console.WriteLine(mc1 == mc3);//Output: true (reference comparison)
            ////value type
            //int i1 = 3;
            //int i2 = 3;
            //int i3 = i1;
            //Console.WriteLine(i1 == i2);//Output: true (fields values comparison)
            //Console.WriteLine(i1 == i3);//Output: true (fields values comparison)
            ////complex type
            //string s1 = "test";
            //string s2 = "test";
            //string s3 = s1;
            //Console.WriteLine(s1 == s2);//Output: true (fields values comparison)
            //Console.WriteLine(s1 == s3);//Output: true (fields values comparison)




        }

        static bool AreEquals(object o1, object o2)
        {
            if (o1 == null && o2 == null)
                return true;
            else if (o1 == null || o2 == null)
                return false;
            else
                return o1.Equals(o2);
        }
    }
}
