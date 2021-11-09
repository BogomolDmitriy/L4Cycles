using System;

namespace LibraryLesson4
{
    public class Les4
    {
        public static void Task1(double A, double B)
        {
            for (int i = 1; i <= 7; i++)
            {
                A = Math.Pow(A, B);
                Console.WriteLine(A);
            }
        }
        public static void Task2(double A)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if ((i % A) == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static double Task3(double A)
        {
            double Conclusion = 0;

            for (double i = 1; i <= A; i++)
            {
                if (Math.Pow(i, 2) < A)
                {
                    Conclusion = Conclusion + 1;
                }
            }
            return (Conclusion);

        }
        public static double Task4(double A)
        {
            double divider = 0;

            for (double i = 1; i < (A - 1); i++)
            {
                if ((A % i) == 0)
                {
                    divider = i;
                }
            }
            return (divider);
        }
        public static double Task5(double A, double B)
        {
            double amount = 0;
            double i = 0;

            if (A > B)
            {
                Console.WriteLine($"{A}>{B} Error");
            }
            else
            {
                for (i = A; i <= B; i++)
                {
                    if ((i % 7) == 0)
                    {
                        amount = amount + i;
                    }
                }
            }
            return (amount);
        }
        public static double Task6(double N)
        {
            double n1 = 1;
            double n2 = 1;
            double n3 = 0;

            for (int i = 1; i <= (N - 2); i++)
            {
                n3 = n2 + n1;
                n1 = n2;
                n2 = n3;
            }
            return (n3);

        }
        public static double Task7(double A, double B)
        {
            while (A != 0 && B != 0)
            {
                if (A > B)
                {
                    A = A % B;
                }
                else
                {
                    B = B % A;
                }
            }
            return (A + B);
        }
        public static double Task9(double N)
        {
            double amount = 0;

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    amount = amount + 1;
                }
            }
            return (amount);
        }
        public static string Task10(int A)
        {
            string amount = "";

            while (A != 0)
            {
                int temp = A % 10;
                string tempS = Convert.ToString(temp);
                A = A / 10;
                amount = amount + tempS;
            }
            return (amount);
        }
        public static void Task11(double N)
        {
            double Even = 0;
            double odd = 0;

            for (double i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Even = Even + i;
                }
                else
                {
                    odd = odd + i;
                }
            }
            if (Even >= odd)
            {
                Console.WriteLine("The output condition is not met.");
            }
            else
            {
                Console.WriteLine(odd);
            }
        }
            public static string Task12(int A, int B)
            {
                int Control = 0;

                while (A != 0)
                {
                    int tempA = A % 10;
                    while (B != 0)
                    {
                        int tempB = B % 10;
                        if (tempB == tempA)
                        {
                            Control = Control + 1;
                        }
                        B = B / 10;
                    }
                    A = A / 10;
                }
                if (Control > 0)
                {
                    return ("Yes");
                }
                else
                {
                    return ("No");
                }

            }

        }
    }
