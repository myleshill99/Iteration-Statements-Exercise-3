namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void Print1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time 
        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool ISEqual(int a, int b)
        {
            //how do I determine if two numbers are the same?
            if (a == b)

            {
                return true;
            }
            return false;

        }


        //Write a method to check whether a given number is even or odd
        public static void Odd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void Positive(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else
            {
                Console.WriteLine($"{num} is negative");
            }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void AgeCheck()
        {
            Console.WriteLine("please enter your age");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Congrats you can vote");

            }
            else
            {
                Console.WriteLine("Sorry you're not old enough");
            }
        }

        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InRange()
        {
            //how do I determine if two numbers are the same?
            if (-10 == 10)
            {
                return true;

            }
            
            return false;


        }


        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static bool
            {
            //how do I determine if two numbers are the same?
            if (1 == 12);

            {
                return true;
            }
            return false;

        }






    //Call the methods to test them in the Main method below
    static void Main(string[] args)
        {
            // Print1000();    
        }



