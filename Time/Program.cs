using System;

namespace Time
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Week 2 homework!");
            Selector();

        }
        static private void Selector()
        {
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("\nPlease choose the program you would like to evaluate:");
            Console.WriteLine("1. Time Calculator\n2. Quadratic Equation\n3. Volume Calculator\n4. Trig Identities\n5. Number Scramble\nOr type exit to quit");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Problem1();
                    break;

                case "2":
                    Problem2();
                    break;

                case "3":
                    Problem3();
                    break;
                case "4":
                    Problem4();
                    break;
                case "5":
                    Problem5();
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine("I did not understand your choice.  Please input number 1-5\n");
                    Selector();
                    break;
            }
        }
        static private void Problem1()
        {
            //Prompts user for current time
            Console.WriteLine("----------------------TIME CALCULATOR----------------------");
            Console.WriteLine("\nWhat is the current hour?");
            var hourInp = Console.ReadLine();

            Console.WriteLine("What is the current minute?");
            var minuteInp = Console.ReadLine();

            Console.WriteLine("What is the current second?");
            var secondInp = Console.ReadLine();

            //Parses the user inputs to variable values
            int hour = int.Parse(hourInp);
            int minute = int.Parse(minuteInp);
            int second = int.Parse(secondInp);

            //Converts current time to number of seconds that have passed in the day
            int secsElapsed = (hour * 3600) + (minute * 60) + (second);

            Console.WriteLine("Seconds elapsed today: {0}", secsElapsed);

            int secsInDay = 86400;

            //Subtracts the seconds that have passed from the total number of seconds in a day
            int secToMidnight = secsInDay - secsElapsed;
            Console.WriteLine("The number of seconds to midnight is: {0}", secToMidnight);

            float percentOfDay = ((float)secsElapsed / (float)secsInDay) * 100;
            Console.WriteLine("{0}% of the day has passed.", percentOfDay);

            //Overwrites previous user input with current system time
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;

            Console.WriteLine("The current time is now {0}:{1}:{2}\n", hour, minute, second);

            secsElapsed = (hour * 3600) + (minute * 60) + (second);
            Console.WriteLine("Seconds elapsed today: {0}", secsElapsed);
            
            secToMidnight = secsInDay - secsElapsed;
            Console.WriteLine("The number of seconds to midnight is: {0}", secToMidnight);



            Selector();
        }
        static private void Problem2()
        {
            Console.WriteLine("----------------------QUADRATIC CALCULATOR----------------------");
            Console.WriteLine("\nx1 = (−b + √(b^2 − 4ac)) / 2a");

            double a, b, c, d, x1;
            Console.WriteLine("To calculate the quadratic formula, please enter value for A");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter value for B");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter value for C");
            c = Convert.ToDouble(Console.ReadLine());

            //Displaying user input
            Console.WriteLine("X = (−({1}) + √(({1})^2 − 4({0})({2}))) / 2({0})", a, b, c);

            //Creating variables to breakdown the formula for solving
            d = b * b - 4 * a * c;
            x1 = (-b + Math.Sqrt(d)) / 2 * a;
            
            Console.WriteLine("X = {0}\n", x1);

            //Looping back to the select screen
            Selector();
        }
        static private void Problem3()
        {
            Console.WriteLine("----------------------VOLUME CALCULATOR----------------------");
            Console.WriteLine("\nvolume = (4 / 3) πr^3");
            
            double r, volume;
            Console.WriteLine("To calculate the volume of a sphere, please enter value for R");
            r = Convert.ToDouble(Console.ReadLine());

            volume = (4 / 3 * Math.PI * r * r * r);
            Console.WriteLine("The volume is {0}\n", volume);

            Selector();
        }
        static private void Problem4()
        {
            Console.WriteLine("----------------------TRIG CALCULATOR----------------------");
            Console.WriteLine("\nc = sin2(theta) + cos2(theta)");

            double theta, trig;
            Console.WriteLine("To solve the formula, what is the value for theta?");
            theta = Convert.ToDouble(Console.ReadLine());

            trig = Math.Pow(Math.Sin(theta), 2) + Math.Pow(Math.Cos(theta), 2);
            Console.WriteLine("The answer is: {0}\n", trig);

            Selector();
        }
        static private void Problem5()
        {
            Console.WriteLine("----------------------NUMBER SCRAMBLE----------------------");
            Console.WriteLine("\nPlease enter a four digit number");
            int numInput = int.Parse(Console.ReadLine());

            Console.WriteLine("You typed: {0}", numInput);
            int firstNum = (numInput / 1000) % 10;
            int secondNum = (numInput / 100) % 10;
            int thirdNum = (numInput / 10) % 10;
            int fourthNum = numInput % 10;

            Console.WriteLine("The sum of all numbers is: {0}", firstNum + secondNum + thirdNum + fourthNum);
            Console.WriteLine("The reverse of your number is: {3}{2}{1}{0}", firstNum, secondNum, thirdNum, fourthNum);
            Console.WriteLine("Your number with the last number first: {3}{0}{1}{2}", firstNum, secondNum, thirdNum, fourthNum);
            Console.WriteLine("Your number with the last number first: {0}{2}{1}{3}\n", firstNum, secondNum, thirdNum, fourthNum);

            Selector();
        }
    }
}
