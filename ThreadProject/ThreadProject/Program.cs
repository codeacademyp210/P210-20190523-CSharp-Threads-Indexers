using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadProject
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //Thread t1 = new Thread(new ThreadStart(Test));
            //t1.Start();
            //Thread t2 = new Thread(new ThreadStart(Test2));
            //t2.Start();

            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write(0);
            //}

            //while (true)
            //{
            //    Thread.Sleep(1000);

            //    Console.Write(0);
            //}

            User user = new User();
            
            user.SetInt(0, 5);
            user.SetInt(1, 15);
            user.SetInt(2, 25);
            user.SetInt(3, 35);
            user.SetInt(4, 45);

            foreach (var item in user.GetInt())
            {
                Console.WriteLine(item);
            }

            UserIndexer indexer = new UserIndexer(10);
            indexer[0] = 5;
            indexer[1] = 15;
            indexer[2] = 25;
            indexer[3] = 35;
            indexer[4] = 45;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(indexer[i]);
            }

            Console.ReadLine();
        }


        public static void Test()
        {
            //Thread.Sleep(5000);
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }

        public static void Test2()
        {
           
            //Thread.Sleep(5000);
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(2);
            }
        }

        public static void Test3()
        {
            //Thread.Sleep(5000);
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(3);
            }
        }
    }
}
