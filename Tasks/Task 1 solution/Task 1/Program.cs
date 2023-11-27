namespace Task_1
{
    class Program
    {
        static void Main()
        {

            #region Question 1

            ////Write a program that allows the user to enter a number then print it.

            //Console.WriteLine("Input an number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The output:" + num);

            #endregion

            #region  Question 2

            //  /* Write a program that takes a number from the user 
            //   * then print yes if that number can be divided by 3 and otherwise print no. */

            //Console.WriteLine("Input an number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //string result = (number % 3 == 0) && (number % 4 == 0) ? "Yes" : "No";
            //Console.WriteLine(result);

            #endregion

            #region Question 3

            //Write a program that allows the user to insert 2 integers then print the max.

            //Console.WriteLine("Input tow integers : ");
            //int integer1 = Convert.ToInt32(Console.ReadLine());
            //int integer2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"first integer: {integer1} \nSecend integer: {integer2} ");

            //string max = (integer1 > integer2) && (integer2 > integer1) ? " integer 1 is max " : "integer 2 is max ";
            //Console.WriteLine(max);

            #endregion

            #region Question 4

            ///* Write a program that allows the user to insert an integer 
            // * then print negative if it is negative number 
            // * otherwise print positive.*/

            //Console.WriteLine("Input number: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //string output = (x < 0) ? "Negative " : "Positive";
            //Console.WriteLine(output);

            #endregion

            #region Question 5

            ////Write a program that takes 3 integers from the user then prints the max element and the min element

            //Console.WriteLine("Input Three integers : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Input: {a},{b},{c}");

            //int max= a;
            //int min = a;


            //if (b > max)
            //    max = b;
            //else if (b < min)
            //    min = b;

            //if (c > max)
            //    max = c;
            //else if (c < min)
            //    min = c;


            //Console.WriteLine($"the max integer is : {max} \nthe min integer is : {min}");

            #endregion

            #region Question 6

            //Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.WriteLine("Input an number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //string input = (num1 % 2 == 0) ? "the number is even" : "the number is odd";
            //Console.WriteLine(input);

            #endregion

            #region Question 7

            //Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //string[] vowel = { "a", "e", "i", "o", "u" };
            //Console.WriteLine("Inter chars: ");
            //string value = Console.ReadLine();

            //for (int i = 0; i < vowel.Length; i++)



            #endregion

            #region Question 8

            //8- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.WriteLine("enter a number:");
            //int num = Convert.ToInt32(Console.ReadLine());


            //for (int i = 1; i < num; i++)
            //{
            //    Console.Write(num + " ");
            //}
            // Console.ReadKey();

            #endregion

            #region Question 9

            //Console.Write("Enter an integer: ");
            //int userInput = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //    {
            //        int result = userInput * i;
            //        Console.Write(result + " ");
            //    }

            //    Console.ReadKey();
            #endregion

            #region Question 10

            //Console.Write("Enter an integer: ");
            //int Input = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i < Input; i++)
            
            //    if (Input % 2 == 0)
            //    {
            //        int result = i;
            //        Console.Write(result);
            //    }
               
            //} 

            #endregion

            #region Question 11

            //Write a program that takes two integers then prints the power.

            //Console.WriteLine("Enter two integer : ");
            //int int1 = Convert.ToInt32(Console.ReadLine());
            //int int2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Input: {int1} {int2}");

            //int power = Convert.ToInt32(Math.Pow(int1, int2));
            //Console.WriteLine("Output:" + power);

            #endregion

            #region Question 12

            //Write a program to enter marks of five subjects and calculate total, average and percentage.


            //Console.WriteLine("Enter Marks of five subjects : ");
            //int sub1 = Convert.ToInt32(Console.ReadLine());
            //int sub2 = Convert.ToInt32(Console.ReadLine());
            //int sub3 = Convert.ToInt32(Console.ReadLine());
            //int sub4 = Convert.ToInt32(Console.ReadLine());
            //int sub5 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sub1 + sub2 + sub3 + sub4 + sub5);

            //int sum = sub1 + sub2 + sub3 + sub4 + sub5;
            //Console.WriteLine("Total marks:" + sum);

            //double average = (sub1 + sub2 + sub3 + sub4 + sub5) / 5;
            //Console.WriteLine("Average marks:" + average);

            //Console.WriteLine("Percentage:" + average + "%");

            #endregion

            #region Question 14

            //Write a program to input marks of five subjects Physics, Chemistry, Biology, Mathematics and Computer, And Calculate percentage and grade.

            //Console.WriteLine("Enter Marks of five subjects : ");
            //int Physics = Convert.ToInt32(Console.ReadLine());
            //int Chemistry = Convert.ToInt32(Console.ReadLine());
            //int Biology = Convert.ToInt32(Console.ReadLine());
            //int Mathematics = Convert.ToInt32(Console.ReadLine());
            //int Computer = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Physics + Chemistry + Biology + Mathematics + Computer);

            //int sum = Physics + Chemistry + Biology + Mathematics + Computer;
            //double average = sum / 5;
            //double Percentage = +average;
            //Console.WriteLine("Percentage:" + Percentage + "%");

            //if (Percentage < 40)
            //{
            //    Console.WriteLine("Grade F");
            //}
            //else if (Percentage >= 40 && Percentage < 60)
            //{
            //    Console.WriteLine("Grade E ");
            //}
            //else if (Percentage >= 60 && Percentage < 70)
            //{
            //    Console.WriteLine("Grade D ");
            //}
            //else if (Percentage >= 70 && Percentage < 80)
            //{
            //    Console.WriteLine("Grade C ");
            //}
            //else if (Percentage >= 80 && Percentage < 90)
            //{
            //    Console.WriteLine("Grade B ");
            //}
            //else if (Percentage >= 90 && Percentage <= 100)
            //{
            //    Console.WriteLine("Grade A ");
            //}
            //else
            //{
            //    Console.WriteLine("unvalide");
            //}

            #endregion

            #region Question 15 

            //Write a program to check whether a number is positive or negative or zero.

            //Console.WriteLine("Input a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number > 0)
            //{
            //    Console.WriteLine(" the number is positive");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("the number is negative");
            //}
            //else
            //{
            //    Console.WriteLine("the number is zero");
            //}


            #endregion






            Console.ReadKey();
        }
    }
}