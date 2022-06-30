using System;
using System.Threading.Tasks;

namespace Lection_3_30_06
{
    class Program
    {
        //1. The user enters 2 numbers (A and B). If A > B, result is A+B, if A=B, result is A * B, if A < B, result is A-B.
        static int Task1(int a, int b)
        {
            int result = a;
            if (a > b)
            {
                result += b;
            }
            else if (a == b)
            {
                result *= b;
            }
            else
            {
                result -= b;
            }

            return result;
        }

        // 2. The user enters 2 numbers(X and Y). Determine which quarter the point with coordinates(X, Y) belongs to.
        static int Task2(int x, int y)
        {
            int result = default;
            if(x == 0 || y == 0)
            {
                return result;
            }

            if (x > 0)
            {
                if(y > 0)
                {
                    result = 1;
                }
                else
                {
                    result = 4;
                }
            }
            else
            {
                if (y > 0)
                {
                    result = 2;
                }
                else
                {
                    result = 3;
                }
            }

            return result;
        }

        //3. The user enters 3 numbers (A, B and C). Print them to the console in ascending order.
        static (int a, int b, int c) Task3(int a, int b, int c)
        {
            if(a > b)
            {
                Swap(ref a, ref b);
            }
            if(a > c)
            {
                Swap(ref a, ref c);
            }
            if(b > c)
            {
                Swap(ref b, ref c);
            }

            return (a, b, c);
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // 4.The user enters 3 numbers(A, B and C). Print to the console the solution(X-values) of the standard form quadratic equation, where AX^2+BX+C=0.
        static (double x1, double x2) Task4(float a, float b, float c)
        {
            double x1 = double.NaN;
            double x2 = double.NaN;
            double sqrtOfD = Math.Sqrt((b * b) - (4 * a * c));

            if (sqrtOfD >= 0)
            {
                x1 = (-b + sqrtOfD) / (2 * a);
                x2 = (-b - sqrtOfD) / (2 * a);
            }

            return (x1, x2);
        }

        //5. The user enters a two-digit number. Print the capitalization of this number to the console. For example, typing "25" will print "twenty-five" to the console.
        static string GetCapitalizationOfNumber(int a)
        {
            int firstDigit = a / 10;
            int secondDigit = a % 10;

            if (firstDigit != 1)
            {
                return $"{GetDozens(firstDigit)} {GetUnits(secondDigit)}";
            }

            return GetExceptionalNumbers(secondDigit);
        }

        private static string GetExceptionalNumbers(int secondDigit)
        {
            string result = string.Empty;
            switch (secondDigit)
            {
                case 0:
                    result = "ten";
                    break;
                case 1:
                    result = "eleven";
                    break;
                case 2:
                    result = "twelve";
                    break;
                case 3:
                    result = "thirteen";
                    break;
                case 4:
                    result = "fourteen";
                    break;
                case 5:
                    result = "fifteen";
                    break;
                case 6:
                    result = "sixteen";
                    break;
                case 7:
                    result = "seventeen";
                    break;
                case 8:
                    result = "eighteen";
                    break;
                case 9:
                    result = "nineteen";
                    break;
            }

            return result;
        }

        private static string GetUnits(int secondDigit)
        {
            string result = string.Empty;
            switch (secondDigit)
            {
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
            }

            return result;
        }

        private static string GetDozens(int firstDigit)
        {
            string result = string.Empty;
            switch (firstDigit)
            {
                case 2:
                    result = "twenty";
                    break;
                case 3:
                    result = "thirty";
                    break;
                case 4:
                    result = "fourty";
                    break;
                case 5:
                    result = "fifty";
                    break;
                case 6:
                    result = "sixty";
                    break;
                case 7:
                    result = "seventy";
                    break;
                case 8:
                    result = "eighty";
                    break;
                case 9:
                    result = "ninety";
                    break;
            }

            return result;
        }

        static int Task1(int numberOfHours)
        {
            return numberOfHours * 60;
        }

        //2. The user enters 2 numbers (A and B). Print the solution (5*A+B^2)/(B-A) to the console.
        //static float Task2(int a, int b)
        //{
        //    return (float)(5 * a + b * b) / (b - a);
        //}

        //3. The user enters 2 string values (A and B). Swap the contents of variables A and B.
        static void Task3(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //4. The user enters 2 numbers (A and B). Print to the console the result of dividing A by B and the division remainder.
        //static (int dividingResult, int divisionResult) Task4(in int a, in int b)
        //{
        //    int dividing = a / b;
        //    int division = a % b;

        //    return (dividing, division);
        //}

        //5. The user enters 3 non-zero numbers (A, B and C). Print to the console the solution (X value) of the standard linear equation, where A*X+B=C.
        static float Task5(float a, float b, float c)
        {
            return (float)Math.Round((c - b) / a, 5);
        }

        //6. The user enters 4 numbers (X1, Y1, X2, Y2) describing the coordinates of 2 points on the coordinate plane. Output the equation of a straight line in the format Y=AX+B passing through these points.
        static (float a, float b) Task6(float y1, float y2, float x1, float x2)
        {
            float a = (y1 - y2) / (x1 - x2);
            float b = y2 - a * x2;

            return (a, b);
        }

        //7. The variable N stores a natural two-digit number (10-99). Write a program that calculates and displays the sum of the digits of n.
        static int Task7(int n)
        {
            int first = n / 10;
            int second = n % 10;

            return first + second;
        }

        static int Sum(int from = 100, int to = 300)
        {
            int result = default;
            for (int i = from; i <= to; i++)
            {
                result += i;
            }

            return result;
        }

        static void MultiplicationTable()
        {
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                }

                Console.WriteLine();
            }
        }

        static float RowSum(int n)
        {
            float sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1f / i;
            }

            return sum;
        }

        static float SquareRowSum(int n)
        {
            float sum = 0;
            for (int i = n; i >= 1; i--)
            {
                sum = (float)Math.Sqrt(i + sum);
            }

            return sum;
        }

        static int FindBiggestNForA(float a)
        {
            float sum = 0;
            int n = 1;

            while ((sum + 1f / n) < a)
            {
                sum += 1f / n++;
            }

            return --n;
        }

        //static async Task Main(string[] args)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine((char)7);
        //        await Task.Delay(100);
        //    }

        static void Main()
        {
            Console.WriteLine('Z' - 'A');
            for (int i = 0; i < 128; i++)
            {
                Console.WriteLine(
                    i + "\t" +
                    (char)i + "\t" +
                    char.IsLetter((char)i) + "\t" +
                    char.IsDigit((char)i));
            }

            uint a = 10;

            int x = int.MaxValue;
            bool test = char.IsLetter('4');
            //Console.WriteLine(Sum());//by default
            //Console.WriteLine(Sum(to: 500));//show only right
            //Console.WriteLine(Sum(from: 10));//only left
            //Console.WriteLine(Sum(10));
            //Console.WriteLine(Sum(from: 50, to: 500));//show both
            //Console.WriteLine(Sum(to: 590, from: 500));//show both

            //Console.WriteLine(i);
            //int userChoice;
            //do
            //{
            //    Console.WriteLine("Enter 1 to task 1");
            //    Console.WriteLine("Enter 2 to task 2");
            //    Console.WriteLine("Enter 0 to exit");
            //    userChoice = Convert.ToInt32(Console.ReadLine());
            //    switch (userChoice)
            //    {
            //        case 1:
            //            Console.WriteLine("call task 1");
            //            break;
            //        case 2:
            //            Console.WriteLine("Call task 2");
            //            break;
            //    }
            //} while (userChoice != 0);
            //int a = 240;
            //for (int ia = 0; false; i++)
            //{

            //}
            //while (false)
            //{
            //    Console.WriteLine(a);
            //    a /= 2;
            //}

            //do
            //{
            //    Console.WriteLine(a);
            //    a /= 2;
            //} while (false);
            //for (int i = 100; i >= 0; i -= 10)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 10;)
            //{
            //    Console.WriteLine(++i);
            //}

            //for (int i = 0;; i++)
            //{
            //    //if(i < 0)
            //    //{
            //    //    Console.WriteLine("We are cycled!");
            //    //}
            //    //Console.WriteLine(i);
            //    //if(i % 100_000 == 0)
            //    //{
            //    //    Console.WriteLine(i);
            //    //}
            //}

            //for (; ; )
            //{
            //    Console.WriteLine("Hello world!");
            //}

            //for (int i = 10; i <= 99; ++i)
            //{
            //    Console.WriteLine(GetCapitalizationOfNumber(i));
            //}

            Console.WriteLine("End of this cycle!");
        }
    }
}
