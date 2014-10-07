using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_vackarklocka
{
    class Program
    {

        //private string HorizontalLine = ("================================");

        static void Main(string[] args)
        {

            // Tests.
            // Test 1.
            AlarmClock test1 = new AlarmClock();
            ViewTestHeader("\nTest 1:\nStandard constructor test.");
            Console.WriteLine(test1.ToString());


            // Test 2.
            AlarmClock test2 = new AlarmClock(9, 42);
            ViewTestHeader("\nTest 2:\nTesting the constructor with two parameters, (9, 42).");
            Console.WriteLine(test2.ToString());


            // Test 3.
            AlarmClock test3 = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader("\nTest 3:\nTesting the constructor with four parameters, (13, 24, 7, 35).");
            Console.WriteLine(test3.ToString());


            // Test 4.
            AlarmClock test4 = new AlarmClock(23, 58, 7, 35);
            ViewTestHeader("\nTest 4:\nTesting the method 'TickTock'. Set the clock to 23:58 and let it go 13 minutes.");
            Run(test4, 13);


            // Test 5.
            AlarmClock test5 = new AlarmClock(6, 12, 6, 15);
            ViewTestHeader("\nTest 5:\nSetting an alarm and see that it works.");
            Run(test5, 6);


            // Test 6.
            AlarmClock test6 = new AlarmClock(25, 61, 35, 71);
            ViewTestHeader("\nTest 6:\nTesting the properties so that exceptions \nare thrown if the values are incorrect.");

            try
            {
                test6.Hour = 25;
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("ERROR! - The hour is out of range, it has to be within 0 - 23.");
            }

            try
            {
                test6.Minute = 61;
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("ERROR! - The minute is out of range, it has to be within 0 - 59.");
            }

            try
            {
                test6.AlarmHour = 24;
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("ERROR! - The hour of the alarm is out of range, it has to be within 0 - 23.");
            }

            try
            {
                test6.AlarmMinute = 61;
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("ERROR! - The minute of the alarm is out of range, it has to be within 0 - 59.");
            }


            // Test 7.
            ViewTestHeader("\nTest 7:\nTesting the constructors so that exceptions \nare thrown if the values are incorrect.");

            try
            {
                AlarmClock test7 = new AlarmClock(25, 0, 0, 0);
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("ERROR! - The hour is out of range, it has to be within 0 - 23");
            }

            try
            {
                AlarmClock test7 = new AlarmClock(0, 71, 0, 0);
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("ERROR! - The minute is out of range, it has to be within 0 - 59");
            }

            try
            {
                AlarmClock test7 = new AlarmClock(0, 0, 35, 0);
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("ERROR! - The hour of the alarm is out of range, it has to be within 0 - 23");
            }

            try
            {
                AlarmClock test7 = new AlarmClock(0, 0, 0, 71);
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("ERROR! - The minute of the alarm is out of range, it has to be within 0 - 23");
            }

        }

        private static void Run(AlarmClock tester, int minutes)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║       Väckarklockan URLED <TM>       ║ ");
            Console.WriteLine(" ║        Modellnr.:1DV402S2L2A         ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
            Console.WriteLine();

            for (int i = 0; i < minutes; i++)
            {
                if (tester.TickTock())
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(tester.ToString() + " Waky waky, Carpe diem and stuff!");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(tester.ToString());
                }
            }
        }

        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {

            Console.WriteLine("\n==================================================");
            Console.WriteLine(header);
            Console.WriteLine();
            
        }

    }
}
