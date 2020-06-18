using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    public class Exercises
    {
        static void Main (string[] args)
        {
            #region Control Flow 1 - Exercise 1
            /*
            Console.WriteLine("Please enter a number");

            ex1UserInfo = Console.ReadLine();
            ex1Number = Convert.ToInt32(ex1UserInfo);


            if (ex1Number >= 1 && ex1Number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            */
            #endregion 

            #region Control Flow 1 - Exercise 2
            /*
            Console.WriteLine("Please enter two numbers");

            ex2UserNumber1 = Console.ReadLine();
            ex2Number1 = Convert.ToInt32(ex2UserNumber1);

            ex2UserNumber2 = Console.ReadLine();
            ex2Number2 = Convert.ToInt32(ex2UserNumber2);

            if (ex2Number1 > ex2Number2)
            {
                Console.WriteLine(ex2Number1);
            }
            else
            {
                Console.WriteLine(ex2Number2);
            }
            */
            #endregion

            #region Control Flow 1 - Exercise 3
            /*
            Console.WriteLine("Please enter image width then image height");

            ex3UserWidth = Console.ReadLine();
            ex3Width = Convert.ToInt32(ex3UserWidth);

            ex3UserHeight = Console.ReadLine();
            ex3Height = Convert.ToInt32(ex3UserHeight);

            if (ex3Width > ex3Height)
            {
                Console.WriteLine("The image is landscape");
            }
            else
            {
                Console.WriteLine("The image is portrait");
            }
            */
            #endregion

            #region Control Flow 1 - Exercise 4
            /*
            Console.WriteLine("Please enter the speed limit");

            ex1UserInfo = Console.ReadLine();
            speedLimit = Convert.ToInt32(ex1UserInfo);

            Console.WriteLine("Please enter the car speed");

            ex1UserInfo = Console.ReadLine();
            carSpeed = Convert.ToInt32(ex1UserInfo);

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");

            }
            else
            {
                speedOver = carSpeed - speedLimit;

                if (speedOver/5 >= 12)
                {
                    Console.WriteLine("License suspended!");
                }
                else
                {
                    Console.WriteLine("You will be notified of your demerit points by mail");
                }
            }
            */
            #endregion
            
            #region Control Flow 2 - Exercise 1
            // Display all numbers divisible by 3 from 1 to 100 then display the overall count.
            /*
            int divisibleby3 =0;

            for (var i = 1; i <= 100; i++)
            {
                if (i %3 == 0)
                {
                    divisibleby3++;
                    Console.WriteLine(i + " is divisible (" + divisibleby3 + ")");  
                }
            }

            Console.WriteLine("There are " + divisibleby3 + " numbers divisible by 3 between 1 and 100");
            */
            #endregion

            #region Control Flow 2 - Exercise 2
            // Ask the user for some numbers or OK to EXIT then display the sum of all numbers.
            /*
            int sum = 0;
            string userInfo;

            while (true)
            {
                Console.WriteLine("Please enter a number or OK to exit");
                userInfo = Console.ReadLine();

                if (userInfo == "OK")
                {
                    Console.WriteLine("The sum of all your numbers is: " + sum);
                    break;
                }

                sum += Convert.ToInt32(userInfo);
            }
            */
            #endregion

            #region Control Flow 2 - Exercise 3
            // Ask the user for a number then calculate and display the factorial.
            /*

            Console.WriteLine("Please enter a number");
             var userNumber = Convert.ToInt32(Console.ReadLine());

            int factorial = userNumber;

            for (int i= (userNumber-1); i>0; i--)
            {
                factorial *= i;
                Console.WriteLine(factorial);
            }

            Console.WriteLine("Factorial of: " + userNumber + " = " + factorial);
            */
            #endregion

            #region Control Flow 2 - Exercise 4
            // Pick a random number and give the user 4 chances to guess the number.
            // If the user guesses the number, display "You won" otherwise display, "You lost".

            /*
            var random = new Random();
            var guesser = random.Next(1, 10);

            Console.WriteLine("Number to be guessed: " + guesser);

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Chance " + i + " of 4");
                Console.WriteLine("Please enter a number from 1 to 10");
                var userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == guesser)
                {
                    Console.WriteLine("You won");
                    break;
                }
                
                Console.WriteLine("You lost"); ;
            }
            */
            #endregion

            #region Control Flow 2 - Exercise 5

            // Ask the user to enter a series of numbers separated by comma.
            // Calculate the greater number and display it in the console.
            /*
            Console.WriteLine("Please enter ANY numbers separated by comma");
            var userNumbers = Console.ReadLine();

            var dewhitenen = userNumbers.Replace(" ", "");
            var formattedText = dewhitenen.Split(',');
            int greaterNumber = 0;

            for (int i = 0; i < formattedText.Length; i++)
            {
                Console.WriteLine(formattedText[i]);

                var formattedNumber = Convert.ToInt32(formattedText[i]);

                if (greaterNumber < formattedNumber)
                {
                    greaterNumber = formattedNumber;
                }
            }

            Console.WriteLine("The greater number is: " + greaterNumber);
            */
            #endregion

            #region Arrays and Lists - Exercise 1
            // Ask the user continuously for different names.
            //until the user presses ENTER (without a name)
            //Depending on the number of names, print a message based on Facebook like pattern.

            Console.Write("Please enter a name: ");
            var name = Console.ReadLine();
            var names = new List<string>();

            while (!string.IsNullOrWhiteSpace(name))
                {
                names.Add(name);
                Console.Write("Please enter another name: ");
                name = Console.ReadLine();
                continue;
                }

            if (names.Count > 2)
            {
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count-2);
            }
            else
            {
                if (names.Count > 1)
                {
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
                }
                else
                {
                    Console.WriteLine("{0} likes your post", names[0]);
                }
            }

            #endregion

            #region Arrays and Lists - Exercise 2

            Console.Write("Please enter your name: ");
            var userName = Console.ReadLine();

            var count = userName.Length;

            var charArray = new Array[count];

            for (var i =0; i<count; i++)
            {

            }

            #endregion

        }

    }
}
