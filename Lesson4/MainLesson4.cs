using LibraryLesson4;
using System;

namespace Lesson4
{
    class MainLesson4
    {
        static void Main(string[] args)
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (userInput)
                {
                    case 1:
                        {
                            Console.WriteLine($"Task№1");

                            Console.Write("Enter A=");
                            double A = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter B=");
                            double B = Convert.ToDouble(Console.ReadLine());
                            Les4.Task1(A, B);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Task№2");
                            Console.Write("Enter A=");
                            double A = Convert.ToDouble(Console.ReadLine());

                            Les4.Task2(A);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Task№3");
                            Console.Write("Enter A=");
                            double A = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"{Les4.Task3(A)}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Task№4");
                            Console.Write("Enter A=");
                            double A = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"{Les4.Task4(A)}");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"Task№5");
                            Console.Write("Enter A=");
                            double A = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter B=");
                            double B = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"{Les4.Task5(A,B)}");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine($"Task№6");
                            Console.Write("Enter N=");
                            double N = Convert.ToDouble(Console.ReadLine());

                            Les4.Task6(N);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine($"Task№7");
                            Console.Write("Enter A=");
                            double A = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter B=");
                            double B = Convert.ToDouble(Console.ReadLine());

                            Les4.Task7(A, B);
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine($"");
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine($"Task№9");
                            Console.Write("Enter A=");
                            double A = Convert.ToDouble(Console.ReadLine());

                            Les4.Task9(A);
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine($"Task№10");
                            Console.Write("Enter A=");
                            int A = Convert.ToInt32(Console.ReadLine());

                            Les4.Task10(A);
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine($"Task№11");
                            Console.Write("Enter N=");
                            double N = Convert.ToDouble(Console.ReadLine());

                            Les4.Task11(N);
                            break;
                        }
                    case 12:
                        {
                            Console.WriteLine($"Task№12");
                            Console.Write("Enter A=");
                            int A = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter B=");
                            int B = Convert.ToInt32(Console.ReadLine());

                            Les4.Task12(A, B);
                            break;
                        }
                }
            } while (userInput != 0);

        }
    }
}
