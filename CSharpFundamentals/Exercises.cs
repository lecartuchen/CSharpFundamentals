﻿using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    internal class Exercises
    {
        public static void Main(string[] args)
        {
            #region Initializations
            var courseNameList = new String[3] { "Beginner", "Intermediate", "Advanced" };
            var courseNumberList = new byte[3] { 1, 2, 3 };
            var sectionsNameBeginners = new List<string>()
            {
                "Introduction",
                "Introduction to C# and .NET Framework",
                "Primitive Types and Expressions",
                "Non-Primitive Types",
                "Control Flow",
                "Arrays and Lists",
                "Working with Dates",
                "Working with Text",
                "Working with Files",
                "Debugging Applications"
            };

            var sectionsNameIntermediate = new List<string>()
            {
                "About this course",
                "Classes",
                "Association between Classes",
                "Inheritance - Second pillar of OOP",
                "Polymorphism - Third pillar of OOP",
                "Interfaces"
            };
            var sectionsNameAdvanced = new List<string>()
            {
                "A",
                "B",
                "C"
            };
            #endregion

            Console.WriteLine("*** CSHARP COURSES ***");
            Console.WriteLine();

            foreach (var num in courseNumberList)
            {
                Console.WriteLine(num + " - " + courseNameList[num-1]);
            }

            Console.WriteLine();
            Console.Write("Type a course number: ");

            try
            {
                var userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput >= 1 && userInput <= 3)
                {
                    int i = 0;

                    switch (userInput)
                    {
                        case 1:
                            Console.WriteLine();
                            foreach (var num in sectionsNameBeginners)
                            {
                                Console.WriteLine(i+1 + " - " + sectionsNameBeginners[i]);
                                i++;
                            }
                            Console.WriteLine();
                            Console.Write("Type a Section Number: ");

                            userInput = Convert.ToInt32(Console.ReadLine());

                            if (userInput >=1 && userInput <= sectionsNameBeginners.Count)
                            {
                                i = 0;

                                switch (userInput)
                                {
                                    case 1:
                                        Console.WriteLine("This is an introduction.....");
                                        Console.WriteLine();
                                        break;

                                    case 2:
                                        Console.WriteLine("This is an introduction to C# and .NET Framework.....");
                                        Console.WriteLine();
                                        break;

                                    case 3:
                                        Console.WriteLine("This is an introduction to Primitive Types and Expressions.....");
                                        Console.WriteLine();
                                        break;

                                    case 4:
                                        Console.WriteLine("This is an introduction to C# and .NET Framework.....");
                                        Console.WriteLine();
                                        break;

                                    case 5:
                                        var section5Ex1 = new Section5Exercise1();
                                        section5Ex1();
                                        break;
                                }

                            }

                            break;

                        case 2:
                            Console.WriteLine();
                            foreach (var num in sectionsNameIntermediate)
                            {
                                Console.WriteLine(i + 1 + " - " + sectionsNameIntermediate[i]);
                                i++;
                            }
                            Console.WriteLine();
                            Console.WriteLine("Type a Section Number");
                            break;

                        case 3:
                            Console.WriteLine();
                            foreach (var num in sectionsNameAdvanced)
                            {
                                Console.WriteLine(i + 1 + " - " + sectionsNameAdvanced[i]);
                                i++;
                            }
                            Console.WriteLine();
                            Console.WriteLine("Type a Section Number");
                            break;
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Please enter a Course NUMBER");
            }



            ///<summary>
            /// CONTROL FLOW 1 - EXERCISES 1 to 4
            /// </summary>
            
            /// <summary>
            /// CF1-Ex1
            /// Ask the user for a number between 1 and 10
            /// Display "Valid" if within 1 and 10 and "Invalid" otherwise.
            /// </summary>

            

            ///<summary>
            /// CF1-Ex2
            /// Ask the user for two random numbers
            /// Display the greater number
            /// </summary>

            #region Control Flow 1 - Exercise 2
            /*
            Console.WriteLine("Please enter two numbers: ");

            var ex2UserNumber1 = Console.ReadLine();
            var ex2UserNumber2 = Console.ReadLine();

            var result = GreaterNumber(ex2UserNumber1, ex2UserNumber2);
            Console.WriteLine("The greater number is {0}: ", result);
            */
            #endregion

            /// <summary>
            /// CF1-Ex3
            /// Ask the user for two numbers representing width and height of an image
            /// Display to console landscape, portrait or square.
            /// </summary>

            #region Control Flow 1 - Exercise 3
            /*
            Console.WriteLine("Please enter image width then image height");

            var ex3UserWidth = Console.ReadLine();
            var ex3UserHeight = Console.ReadLine();
            var imageLayout = ImageLayout(ex3UserWidth, ex3UserHeight);

            Console.WriteLine("The image is {0}", imageLayout);
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
            // Display the reversed name on CAPITAL on the console.
            /*
            Console.Write("Please enter your name: ");
            var userName = Console.ReadLine();

            var count = userName.Length;

            var charArray = new string[count];

            for (var i =0; i<count; i++)
            {
                charArray.SetValue(userName.Substring(i, 1), i);
                Console.Write("{0} - ", charArray[i]);
            }

            Console.WriteLine();

            Array.Reverse(charArray);

            for (var i = 0; i < count; i++)
            {
                Console.Write(charArray[i].ToUpper());
            }

            Console.WriteLine();
            */

            #endregion

            #region Arrays and Lists - Exercise 3

            // Write a program and ask the user to enter 5 numbers
            // If a number has been previously entered, display an error message and ask the user to re-try
            // Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
            /*
            Console.Write("Please enter 5 different numbers 1 at a time: ");
            var userData = Console.ReadLine();

            var userNumber = Convert.ToInt32(userData);
            var numberArray = new int[5];
            numberArray.SetValue(userNumber, 0);

            for (var i=1; i<5; i++)
            {
                var counter = i + 1;
                Console.Write("Please enter the next ("+ counter +") number: ");
                userData = Console.ReadLine();

                userNumber = Convert.ToInt32(userData);
                numberArray.SetValue(userNumber, i);

                if (numberArray[i - 1] == numberArray[i])
                {
                    Console.WriteLine("Please enter different numbers. Try again ");
                    i--;
                }
            }

            Console.WriteLine();

            Array.Sort(numberArray);

            for (var i=0; i<5; i++)
            {
                Console.Write(numberArray[i] + " "); 
            }
            */

            #endregion

            #region Arrays and Lists - Exercise 4

            // Write a program and ask the user to continuously enter a number or type "Quit" to exit
            // The list of numbers may include duplicates
            // Display the unique numbers that the user has entered

            /*
            var userList = new List<int>();
            var finalList = new List<int>();
            string userInput;
            int userNumber = 0;


            while (true)
            {
                Console.Write("Please enter a number or type QUIT to exit: ");
                userInput = Console.ReadLine();

                if (userInput == "QUIT")
                {
                    break;
                }

                else
                {
                    userNumber = Convert.ToInt32(userInput);

                    userList.Add(userNumber);

                }
            }

            if (userList.Count > 1)
            {
                for (var i = 0; i < userList.Count; i++)
                {
                    var indexFirst = userList.IndexOf(userList[i]);
                    var indexLast = userList.LastIndexOf(userList[i]);

                    // Testing indexes
                    //Console.WriteLine("First index of: {0} is: {1}", userList[i], Convert.ToString(indexFirst));
                    //Console.WriteLine("Last index of: {0} is: {1}", userList[i], Convert.ToString(indexLast));

                    if (indexFirst == indexLast)
                    {
                        finalList.Add(userList[i]);
                    }

                }

                if (finalList.Count != 0)
                {
                    Console.WriteLine("Your unique numbers are: ");
                    foreach (var number in finalList)
                    {
                        Console.Write(number + " ");

                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("There are no unique numbers in the list");
                }


            }

            else
            {
                if (userList.Count == 1)
                {
                    Console.WriteLine("Your unique number is: {0}", userNumber);
                }

                else
                {
                    Console.WriteLine("Your list is empty");
                }
            }
            */

            #endregion

            #region Arrays and Lists - Exercise 5

            // Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10)
            // If the list is empty or includes less than 5 numbers, display "Invalid List" and
            // ask the user to re-try; otherwise, display the 3 smallest numbers in the list

            /*var splitStringList = new List<string>();
            var finaltrio = new int[3];

            int commaCount, smallest, secondSmallest, thirdSmallest;
            commaCount = smallest = secondSmallest = thirdSmallest = 0;

            while (true)
            {
                Console.WriteLine("Please provide at least 5 comma separated numbers");
                var fullString = Console.ReadLine();

                var deWhittenString = fullString.Replace(" ", "");

                //Console.WriteLine(deWhittenString);

                if (deWhittenString.Contains(","))
                {
                    if (deWhittenString.LastIndexOf(",") > 6)
                    {
                        foreach (var letter in deWhittenString)
                        {
                            if (letter.Equals(","))
                            {
                                commaCount++;
                            }
                        }

                        var splitStringArray = new String[commaCount + 1];
                        splitStringArray = deWhittenString.Split(',');

                        splitStringList.InsertRange(0, splitStringArray);

                        foreach (var item in splitStringList)
                        {
                            Console.WriteLine(item);
                        }


                        break;
                    }
                    else
                    {
                        Console.WriteLine("The List of numbers provided is invalid");
                        Console.WriteLine("Please introduce 5 or more numbers");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("The List of numbers provided is invalid");
                    Console.WriteLine("Please introduce commas between numbers");
                    Console.WriteLine();
                }

            }

            // Determines the smallest number in the list
            // Takes out the smallest number from the list

            var temp = Convert.ToInt32(splitStringList[0]);

            for (var i = 1; i < splitStringList.Count; i++)
            {
                var number = Convert.ToInt32(splitStringList[i]);

                if (temp <= number)
                {
                    smallest = temp;
                }
                else
                {
                    smallest = temp = number;
                }
            }

            for (var i = 0; i < splitStringList.Count; i++)
            {
                splitStringList.Remove(Convert.ToString(smallest));
            }

            Console.Write("First list: ");
            foreach (var item in splitStringList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Determines the SECOND smallest number in the list
            // Takes out the SECOND smallest number from the list

            temp = Convert.ToInt32(splitStringList[0]);

            for (var i = 1; i < splitStringList.Count; i++)
            {
                var number = Convert.ToInt32(splitStringList[i]);

                if (temp <= number)
                {
                    secondSmallest = temp;
                }
                else
                {
                    secondSmallest = temp = number;
                }
            }

            for (var i = 0; i < splitStringList.Count; i++)
            {
                splitStringList.Remove(Convert.ToString(secondSmallest));
            }

            Console.Write("Second list: ");
            foreach (var item in splitStringList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Determines the THIRD smallest number in the list
            // Takes out the THIRD smallest number from the list

            temp = Convert.ToInt32(splitStringList[0]);

            for (var i = 1; i < splitStringList.Count; i++)
            {
                var number = Convert.ToInt32(splitStringList[i]);

                if (temp <= number)
                {
                    thirdSmallest = temp;
                }
                else
                {
                    thirdSmallest = temp = number;
                }
            }

            for (var i = 0; i < splitStringList.Count; i++)
            {
                splitStringList.Remove(Convert.ToString(thirdSmallest));
            }

            Console.Write("Third list: ");
            foreach (var item in splitStringList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            Console.WriteLine("The three smallest numbers in the list are: {0}, {1} and {2}.", smallest, secondSmallest, thirdSmallest);*/

            #endregion

            #region Working with Text - Exercise 1

            // Write a program and ask the user to enter a few numbers separated by a hyphen.
            // Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or
            // "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            /*Console.WriteLine("Please provide a few numbers separated by a hyphen");
            var inputString = Console.ReadLine();

            var inputStringNumbers = inputString.Split('-');
            var inputNumbers = new int[inputStringNumbers.Length];
            int i = 0;
            bool resultIncrease = true;
            bool resultDecrease = true;

            foreach (var num in inputStringNumbers)
            {
                inputNumbers[i] = Convert.ToInt32(num);
                i++;
            }

            // CHECK IF INCREASING CONSECUTIVE
            for (i = 0; i < (inputNumbers.Length - 1); i++)
            {
                var tempNumber = inputNumbers[i];

                if ((tempNumber + 1) != inputNumbers[i + 1])
                {
                    resultIncrease = false;
                    break;
                }
            }

            // CHECK IF DECREASING CONSECUTIVE
            for (i = 0; i < (inputNumbers.Length - 1); i++)
            {
                var tempNumber = inputNumbers[i];

                if (tempNumber - 1 != inputNumbers[i + 1])
                {
                    resultDecrease = false;
                    break;
                }
            }

            if (resultIncrease || resultDecrease)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
            */

            #endregion

            #region Working with Text - Exercise 2

            // Write a program and ask the user to enter a few numbers separated by a hyphen.
            // If the user simply presses Enter, without supplying an input, exit immediately;
            // otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            /*Console.WriteLine("Please enter a few numbers separated by a hyphen");
            var inputString = Console.ReadLine();

            if (inputString.Length != 0)
            {
                var inputStringArray = inputString.Split('-');

                foreach (var num in inputStringArray)
                {
                    var counter = 0;

                    for (int i = 0; i < inputStringArray.Length; i++)
                    {
                        if (num == inputStringArray[i])
                        {
                            counter++;      
                        }
                    }

                    if (counter > 1)
                    {
                        Console.WriteLine("There are {0} Duplicates", counter);
                        break;
                    }
                }
            }*/

            #endregion

            #region Working with Text - Exercise 3

            // Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
            // A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok";
            // otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

            /*
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }*/

            #endregion

            #region Working with Text - Exercise 4

            /// <summary>
            /// Write a program and ask the user to enter a few words separated by a space.
            /// Use the words to create a variable name with PascalCase.
            /// For example, if the user types: "number of students", display "NumberOfStudents".
            /// Make sure that the program is not dependent on the input.
            /// So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
            /// </summary>

            /*
            Console.WriteLine("Please enter a few words separated by a space");
            var input = Console.ReadLine();

            var words = input.Split(' ');
            var lowerCase = new String[words.Length];
            var deCap = new String[words.Length];
            var capitalized = new String[words.Length];
            var i = 0;
            var jointResult = new StringBuilder();

            foreach (var word in words)
            {
                lowerCase[i] = word.ToLower();
                var firstLetter = Char.ToUpper(lowerCase[i].ElementAt(0));
                deCap[i] = lowerCase[i].Remove(0, 1);
                capitalized[i] = deCap[i].Insert(0, Convert.ToString(firstLetter));
                i++;
            }

            foreach (var word in capitalized)
            {
                jointResult.Append(word);
            }

            Console.WriteLine(jointResult);
            */

            #endregion

            #region Working with Text - Exercise 5

            /// <summary>
            /// Write a program and ask the user to enter an English word.
            /// Count the number of vowels (a, e, o, u, i) in the word.
            /// So, if the user enters "inadequate", the program should display 6 on the console.
            /// </summary>
            /*
            public static void Main()
            {
                Console.WriteLine("Please enter a word:");
                var inputWord = Console.ReadLine().ToLower();

                var letter = new char[inputWord.Length];
                var vocals = new char[5] { 'a', 'e', 'i', 'o', 'u' };
                byte counter = 0;

                for (int i = 0; i < inputWord.Length; i++)
                {
                    letter[i] = inputWord.ElementAt(i);

                    for (int y = 0; y < vocals.Length; y++)
                    {
                        if (letter[i] == vocals[y])
                            counter++;
                    }
                }

                Console.WriteLine("The word {0} has {1} vocals", inputWord, counter);
            }
            */

            #endregion

            #region SECTION 9: WORKING WITH FILES

            /// <summary>
            /// Write a program that reads a text file and displays the number of words.
            /// </summary>


            #region Working with Files - Exercise 1
            /*
            var numberOfWords = 0;
            */
            #endregion


            /// <summary>
            /// Write a program that reads a text file and displays the longest word in the file.
            /// </summary>

            #region Working with Files - Exercise 2



            #endregion

            #endregion
        }

        /// <summary>
        /// CF1-Ex1-Method
        /// </summary>
        /// <param name="ex1UserInfo"></param>
        /// <returns>result1, result2</returns>
        public static string OneToTen(string ex1UserInfo)
        {
            var ex1Number = Convert.ToInt32(ex1UserInfo);
            var result1 = "Valid";
            var result2 = "Invalid";

            if (ex1Number >= 1 && ex1Number <= 10)
            {
                return result1;
            }
            else
            {
                return result2;
            }
        }

        /// <summary>
        /// CF1-Ex2-Method
        /// </summary> 
        public static string GreaterNumber(string ex2UserNumber1, string ex2UserNumber2)
        {
            var ex2Number1 = Convert.ToInt32(ex2UserNumber1);
            var ex2Number2 = Convert.ToInt32(ex2UserNumber2);

            if (ex2Number1 > ex2Number2)
            {
                return ex2UserNumber1;
            }
            else
            {
                return ex2UserNumber2;
            }
        }

        /// <summary>
        /// CF1-Ex3-Method
        /// </summary>
        public static string ImageLayout(string ex3UserWidth, string ex3UserHeight)
        {
            var ex3Width = Convert.ToInt32(ex3UserWidth);
            var ex3Height = Convert.ToInt32(ex3UserHeight);
            var result = new string[3] { "landscape", "portrait", "square" };

            if (ex3Width > ex3Height)
            {
                return result[0];
            }
            else
            {
                if (ex3Width < ex3Height)
                {
                    return result[1];
                }

                else
                {
                    return result[2];
                }

            }
        }
    }
}
