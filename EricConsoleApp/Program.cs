﻿using System;
using EricConsoleApp.Unit4;
using EricConsoleApp.Unit5;
using EricConsoleApp.RPSGame;

namespace EricConsoleApp
{
    class Program
    {
        /// <summary>
        /// This method is called first when the program is executed
        /// </summary>
        static void Main(string[] args)
        {
            //TestDistanceConverter(); // T4.1
            //TestBook(); // T4.2 and T4.3
            //TestBMI(); // T4.4

            TestTournament();           // T5.1 and 5.3
            //TestSongs();                // T5.2
            //TestBubbleSort();             // T5.4
            //TestMotelBooking();         // T5.6
            //TestRPS_Game();
            
        }

        private static void TestBubbleSort()
        {
            Bubble NSort = new Bubble();

            NSort.InputNumbers();
            NSort.DisplayNumbers();
            NSort.SortNumbers();
        }

        private static void TestRPS_Game()
        {
            GameController controller = new GameController();
            controller.RunGame();
        }

        /// <summary>
        /// Task 4.2 Create a Book object and test that it writes chapter 1 and 2
        /// Task 4.3 Add a Book Constructor method to initialise all the attributes
        /// </summary>
        private static void TestBook()
        {
            Book book = new Book();
            SimpleIO.WriteTitle("Horror Story", "Task 4.1");

            //book.GetDetails();
            book.WriteChapter1();
            book.WriteChapter2();
        }

        private static void TestBMI()
        {
            BMI bmi = new BMI();

            bmi.GetDetails();
            bmi.CalculateBMI();
        }

        /// <summary>
        /// Task 5.2
        /// </summary>
        private static void TestSongs()
        {
            MP3Chart chart = new MP3Chart();

            chart.ShowSongs();

            bool finish = false;

            while (!finish)
            {
                int songNo = chart.GetVotes();
                if (songNo == 0) finish = true;
            }

            chart.ShowVotes();
        }

        /// <summary>
        /// Task 5.1 Create a new Tournament object
        /// and get the scores for each player and
        /// display them
        /// </summary>
        private static void TestTournament()
        {
            Tournament tournament = new Tournament();

            tournament.GetDetails();
            tournament.ShowDetails();
        }

        /// <summary>
        /// Task 4.1 Create a Converter and check that it converts between
        /// miles and feet using double numbers
        /// </summary>
        public static void TestDistanceConverter()
        {
            double miles = 1;
            double feet = 0;

            Console.WriteLine("Eric's Distance Converter");
            DistanceConverter converter = new DistanceConverter();
            int choice = 3;

            string[] choices = new string[]
            {
                "1. Convert Miles to Feet",
                "2. Convert Feet to Miles",
                "3. Quit Test"
            };
            do
            {
                choice = SimpleIO.GetChoice(choices);

                if (choice == 1)
                {

                    miles = converter.GetDouble("Miles");
                    feet = converter.ToFeet(miles);

                    Console.WriteLine("The no. of miles = " + miles);
                    Console.WriteLine("The no. of feet = " + feet);
                }
                else if (choice == 2)
                {
                    feet = converter.GetDouble("Feet");
                    miles = converter.ToMiles(feet);

                    Console.WriteLine("The no. of feet = " + feet);
                    Console.WriteLine("The no. of miles = " + miles);
                }
            } while (choice != 3);
        }

        /// <summary>
        /// A simple room booking system
        /// </summary>
        private static void TestMotelBooking()
        {
            BatesMotel motel = new BatesMotel();

            SimpleIO.WriteTitle("The Bates Motel", "Task 5.6");
            motel.RunMotel();
           
            Console.ReadKey();
        }
    }
}


