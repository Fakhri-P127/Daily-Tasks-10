using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taskin shertini tam basha dushemdim ona gore bir neche yolla yazdim
            #region List ile(int)
            Lemon lemon = new Lemon(3);
            Apple apple = new Apple(9);
            Pineapple pineapple = new Pineapple(58);

            List<int> basketList = new List<int>
            {
                lemon.VitaminContent,
                apple.VitaminContent,
                pineapple.VitaminContent
            };

            int total = 0;
            Console.WriteLine("Total vitamin contents in Basket:");
            foreach (var item in basketList)
            {
                total += item;
            }
            Console.WriteLine(total);
            #endregion

            #region List ile(string)
            //Lemon lemon = new Lemon("Lemon:\nA vitamin - 3 IU, C vitamin - 44.1 mg");
            //Apple apple = new Apple("Apple:\nA vitamin - 9 IU, C vitamin - 12.0 mg");
            //Pineapple pineapple = new Pineapple("Pineapple:\nA vitamin - 58 IU, C vitamin - 47.8 mg");

            //List<string> basketList = new List<string>
            //{
            //    lemon.VitaminContent,
            //    apple.VitaminContent,
            //    pineapple.VitaminContent
            //};

            //Console.WriteLine("Vitamin contents per 100 gram:\n");
            //foreach (var item in basketList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion            

            #region Dictionary ile(int)
            //Lemon lemon = new Lemon(3);
            //Apple apple = new Apple(9);
            //Pineapple pineapple = new Pineapple(58);
            //Dictionary<string, int> dict = new Dictionary<string, int>
            //{
            //    {"Pineapple" , pineapple.VitaminContent},
            //    {"Apple" , apple.VitaminContent},
            //    {"Lemon" , lemon.VitaminContent}
            //};
            //foreach (var item in dict)
            //{
            //    Console.WriteLine(item);
            //}           
            #endregion

            #region Dictionary ile(string)
            //Dictionary<string, string> dict = new Dictionary<string, string>
            //{
            //    { "Pineapple", "A vitamin - 58 IU, C vitamin - 47.8 mg" },
            //    { "Apple", "A vitamin - 9 IU, C vitamin - 12.0 mg" },
            //    { "Lemon", "A vitamin - 3 IU, C vitamin - 44.1 mg" }
            //};

            //foreach (var item in dict)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
