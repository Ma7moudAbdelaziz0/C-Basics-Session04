using System;
using System.Linq;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Basics_Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            ////Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            ////the second price(index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region Q02
            ////Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            ////shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Q03
            ////Write a method called PrintWelcomeMessage that takes no parameters and prints
            ////"Welcome to the Library!".Call it from Main.
            //PrintWelcomeMessage();
            #endregion

            #region Q04
            ////Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            ////"Clean Code".
            //string bookTitle = "Clean Code";
            //PrintBookTitle(bookTitle);
            #endregion

            #region Q05
            ////Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            ////int pages = 400; and print pages afterward. What do you expect to see, and why?
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine($"Pages after calling AddBonusPages: {pages}");//400 because the method modify copy of the value (pass by value)
            #endregion

            #region Q06
            ////Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            ////with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            ////see, and why?
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine($"Price after calling ApplyDiscount: {prices[0]}");//20.5 because the method modify the array (pass by reference)
            #endregion

            #region Q07
            ////Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            ////all it and print pages afterward. How is the result different from question 5 ?
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine($"Pages after calling AddBonusPages: {pages}");//450 because the method modify the original value (pass by reference)
            #endregion

            #region Q08
            ////Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            ////new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
            ////afterward.
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine($"Prices length after calling ReplaceArray: {prices.Length}");//3 because the method modify the original array (pass by reference)
            #endregion

            #region Q09
            ////Write a method bool TryGetPrice(string title, out double price) that returns true and sets
            //// price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it
            ////and print the price if found
            //string bookTitle = "Clean Code";
            //if (TryGetPrice(bookTitle, out double price)==true)
            //{
            //    Console.WriteLine($"Price of '{bookTitle}': {price}");
            //}
            //else
            //{
            //    Console.WriteLine($"Price of '{bookTitle}' not found.");
            //}
            #endregion

            #region Q10
            ////Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call
            ////it once with only a title, and once passing both a title and pages.
            //string bookTitle = "Clean Code";
            //PrintBookInfo(bookTitle);
            //PrintBookInfo(bookTitle, 450);
            #endregion

            #region Q11
            ////Using the PrintBookInfo method from the question above, call it by naming the
            ////parameters, passing pages before title
            //PrintBookInfo(pages: 650, title: "Clean Code");
            #endregion

            #region Q12
            //Write a method PrintAllTitles(params string[] titles) that prints each title on its own line.
            //Call it with three book titles.
            PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Design Patterns");

            #endregion
        }
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        public static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book Title: {title}");
        }
        public static void AddBonusPages(int pages)
        {
            pages += 50;

        }
        public static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        public static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;

        }
        public static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        public static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        public static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Book Title: {title}, Pages: {pages}");
        }
        public static void PrintAllTitles(params string[] titles)
        {
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }

        }
    }
}
