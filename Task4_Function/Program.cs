using System;

namespace Task4_Function
{
    class Program
    {
        static void sumAndAvg(int[] arr)
        {
            int sum = 0;
            double avg;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = (double)sum / arr.Length;
            Console.WriteLine($"the Sum: {sum}");
            Console.WriteLine($"the average: {avg}");
        }
        static void cubeOfNumber(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Number is : {i} and cube of the {i} is: {i * i * i}");
            }
        }
        static void getYears(int[] years)
        {
            foreach (int year in years)
            {
                if (year > 1950)
                {
                    Console.WriteLine(year);
                }
            }
        }
        static int getAgeInDays(int year)
        {
            return year * 365;
        }
        static int getNumberOfLegs(int chickens, int cows, int pigs)
        {
            int legsPerCow = 4;
            int legsPerChicken = 2;
            int legsPerPig = 4;
            int result = (chickens * legsPerChicken) + (cows * legsPerCow) + (pigs * legsPerPig);
            return result;
        }
        static string Login(string[,] users, string userName, string password)
        {
            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (userName == users[i, 0] && password == users[i, 1])
                {
                    return "Pass";
                }

            }
            return "Failed";
        }
        static double powerOfNumber(double number, int exponent)
        {
            double power = 1;
            for (int i = 1; i <= exponent; i++)
            {
                power *= number;
            }
            return power;
        }
        static bool IsLeapYear(int year)
        {
            if (year < 1900 || year > 2024)
            {
                Console.WriteLine("Please enter a year within the range 1900-2024.");
                return false;
            }

            return DateTime.IsLeapYear(year);
        }
        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                Console.WriteLine("Please enter a number greater than or equal to 2.");
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false; 
                }
            }

            return true;
        }
        static int numberOfWord(string sentence)
        {
            int count = 1;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            // 1
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //sumAndAvg(numbers);


            // 2
            //Console.WriteLine("Enter The Number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //cubeOfNumber(number);


            //3
            //int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            // getYears(years);


            //4
            //Console.Write("Enter your Age in Years: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Age in Years: {age},\nAge in Days: {getAgeInDays(age)}");



            // 5
            //int numberOfCows = 3;
            //int numberOfChickens = 2;
            //int numberOfPigs = 5;
            //Console.WriteLine($"Total number of legs: {getNumberOfLegs(numberOfChickens, numberOfCows, numberOfPigs)}");



            // 6
            //string[,] users = { { "hasan", "hasan@123" }, { "mohammad", "mohammad@123" } };
            //Console.WriteLine(Login(users,"hasan", "hasan@123"));
            //Console.WriteLine(Login(users,"sameer", "sameer@123"));



            // 7
            //Console.Write("Enter The Number: ");
            //double number = Convert.ToDouble(Console.ReadLine());
            //Console.Write("\nEnter The Exponent of the Number: ");
            //int exponent = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The Power Of {number}: {powerOfNumber(number, Math.Abs(exponent))}");



            // 8
            //Console.WriteLine("Enter the years from 1990 to 2024 to return leap years: ");
            //int years = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(IsLeapYear(years));



            // 9
            //Console.Write("Enter The Number To Check the Prime Number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(IsPrime(num));


            
            // 10
            //string sentence1 = "This is a sample sentence.";
            //string sentence2 = "Count the words in this sentence without using Count method.";
            //Console.WriteLine(numberOfWord(sentence1));
            //Console.WriteLine(numberOfWord(sentence2));

        }
    }
}
