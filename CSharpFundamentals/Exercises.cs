﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFundamentals
{
    public class Exercises
    {
        static void Main (string[] args)
        {
            #region Control Flow 1 - Exercise 1
            // Ask the user for a number between 1 and 10
            // Display "Valid" if within 1 and 10 and "Invalid" otherwise.
            /*
            
            Console.Write("Please enter a number");

            var ex1UserInfo = Console.ReadLine();
            var ex1Number = Convert.ToInt32(ex1UserInfo);


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
            // Ask the user for two random numbers
            // Display the greater number
            /*
            
            Console.WriteLine("Please enter two numbers");

            var ex2UserNumber1 = Console.ReadLine();
            var ex2Number1 = Convert.ToInt32(ex2UserNumber1);

            var ex2UserNumber2 = Console.ReadLine();
            var ex2Number2 = Convert.ToInt32(ex2UserNumber2);

            if (ex2Number1 > ex2Number2)
            {
                Console.WriteLine("The greater number is {0}: ", ex2Number1);
            }
            else
            {
                Console.WriteLine("The greater number is {0}: ", ex2Number2);
            }
            */
            #endregion

            #region Control Flow 1 - Exercise 3
            // Ask the user for two numbers representing width and height of an image
            // Display to console landscape, portrait or square.
            /*
            
            Console.WriteLine("Please enter image width then image height");

            var ex3UserWidth = Console.ReadLine();
            var ex3Width = Convert.ToInt32(ex3UserWidth);

            var ex3UserHeight = Console.ReadLine();
            var ex3Height = Convert.ToInt32(ex3UserHeight);

            if (ex3Width > ex3Height)
            {
                Console.WriteLine("The image is landscape");
            }
            else
            {
                if (ex3Width < ex3Height)
                {
                    Console.WriteLine("The image is portrait");
                }

                else
                {
                    Console.WriteLine("The image is square");
                }
                
            }
            */
            #endregion

            #region Control Flow 1 - Exercise 4
            // Ask the user for a speed limit then a car speed
            // Display "Ok" if car speed under speed limit
            // If car speed is over speed limit then calculate number of demerit points
            // 1 Demerit point for every 5 miles over the speed limit
            // Display "License suspended" if number of demerit points are 12 or over

            /*
            Console.WriteLine("Please enter the speed limit");

            var ex1UserInfo = Console.ReadLine();
             var speedLimit = Convert.ToInt32(ex1UserInfo);

            Console.WriteLine("Please enter the car speed");

            ex1UserInfo = Console.ReadLine();
            var carSpeed = Convert.ToInt32(ex1UserInfo);

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");

            }
            else
            {
                var speedOver = carSpeed - speedLimit;

                if (speedOver/5 >= 12)
                {
                    Console.WriteLine("License suspended!");
                }
                else
                {
                    Console.WriteLine("Driving over the speed limit. Report {0} demerit points.", speedOver/5);
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
                userInfo = Console.ReadLine().ToUpper();

                if ( userInfo =="")
                {
                    Console.WriteLine("Please enter a number or type OK");
                }
                else
                {
                    if (userInfo == "OK")
                                    {
                                        Console.WriteLine("The sum of all your numbers is: " + sum);
                                        break;
                                    }

                                    sum += Convert.ToInt32(userInfo);
                }

                
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
            /*
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
            */
            #endregion

            #region Arrays and Lists - Exercise 2
            // Write a program and ask the user to enter their name
            // Use an array to reverse the name and then store the result in a new string
            // Display the reversed name on the console.
            
            Console.Write("Please enter your name: ");
            var userName = Console.ReadLine();

            var count = userName.Length;

            var charArray = new string[count];

            for (var i =0; i<count; i++)
            {
                charArray.SetValue(userName.Substring(i, 1), i);
                Console.WriteLine( charArray[i]);
            }

            Array.Reverse(charArray);

            for (var i = 0; i < count; i++)
            {
                Console.Write(charArray[i]);
            }

            Console.WriteLine();
            #endregion

        }

    }
}
