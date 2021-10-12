using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateEvent
{
    class Program
    {//delegate
        public delegate bool Calc(int num);
        //public delegate void Find();

        //public delegate void Write(string word);

        public delegate void WriteGeneric<T>(T n);
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 15, 20, 56, 17 };
            //Console.WriteLine(Sum(arr1));
            //Console.WriteLine(Sum1(arr1));
            //Console.WriteLine(Sum2(arr1));
            //Console.WriteLine(Sum(arr1,FindThree));
            //Console.WriteLine(Sum(arr1,IsOdd));

            //Anonym method
            //Console.WriteLine(Sum(arr1, delegate (int num) { return num % 10 == 0; }));

            //Lambda expression
            //Console.WriteLine(Sum(arr1,n=>n%10==0));


            //Write write = new Write(StringMethod);

            //write += StringLen;
            //write += StringUp;
            //write -= StringLen;

            //write += delegate (string w) { Console.WriteLine(w.ToLower()); };

            //write += word => Console.WriteLine(word);


            //write.Invoke("Hello");

            //WriteGeneric<string> writeGeneric = new WriteGeneric<string>(StringMethod);
            //writeGeneric.Invoke("Hello");

            //WriteGeneric<int> writeGeneric1 = new WriteGeneric<int>(Test1);

            //writeGeneric1.Invoke(9);


            //Action<int> act = Test1;
            //act.Invoke(10);
            //Action<string> stract = StringLen;
            //stract.Invoke("Hello");
            //Action<int> s = delegate (int num) { Console.WriteLine(num); };
            //s.Invoke(5);

            //Func<string,int> meth = StringLen1;

            //Console.WriteLine(meth.Invoke("Hello"));

            //Predicate<int> premethod = IsOdd;

            //Console.WriteLine(premethod.Invoke(19));


            //Event
            Student s1 = new Student("Ehed", 55);
            Student s2 = new Student("Vusal", 60);

            s1.Notify += delegate (bool x)
              {
                  if (x)
                  {
                      Console.WriteLine("5500");
                  }
                  else
                  {
                      Console.WriteLine("Block");
                  }
              };
            s1.MethodNotify();

            s2.Notify += delegate (bool x)
              {
                  if (x)
                  {
                      Console.WriteLine("Tebrikler Vusal");
                  }
                  else
                  {
                      Console.WriteLine("Kecmediz Vusal");
                  }
              };
            s2.MethodNotify();
        }

        //Delegate
        public static void StringMethod(string word)
        {
            Console.WriteLine(word);
        }

        public static void StringLen(string s)
        {
            Console.WriteLine(s.Length);
        }

        public static int StringLen1(string s)
        {
            return s.Length;
        }

        public static void StringUp(string t)
        {
            Console.WriteLine(t.ToUpper());
        }
        public static void Test1(int num)
        {
            Console.WriteLine(num);
        }
        public static int Sum(int[] num,Calc method)
        {
            int result = 0;
            foreach (int item in num)
            {
                if (method(item))
                {
                    result += item;
                }
            }

            return result;
        }
       
        public static void Test()
        {
            Console.WriteLine("Hello");
        }



        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }


        public static bool IsOdd(int n)
        {
            return n % 2!= 0;
        }
        public static bool FindThree(int n)
        {
            return n % 3 == 0;
        }

    }
}
