using System;

public class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        Console.WriteLine("Enter a number");
        int n = int.Parse(Console.ReadLine());
        Write1ThroughN_While(n);
        Write1ThroughN_For(n);
        WriteNThrough1_While(n);
        WriteNThrough1_For(n);
        WriteEvensThrough100();
        FindSum(n);
        FindSumOfEvenNumbers(n);
        FindSumOfOddNumbers(n);
        Console.WriteLine("Enter a number for a triangle base");
        int _base = int.Parse(Console.ReadLine());
        OutputRightTriangle(_base);
    }
    public static void Write1ThroughN_While(int n)
        {
            if(n <= 0)
            {
                Console.WriteLine(n + " is out of range");
            }

            else
            {
             int start = 1;
             string list = "";
             while(start <= n)
                {
                list += start + " ";
                start++;
                }
                Console.WriteLine(list);
            }
        }
        public static void Write1ThroughN_For(int n)
        {
            if(n <= 0)
            {
                Console.WriteLine(n + " is out of range");
            }

            else
            {
                string list = "";
             for(int i = 1; i < n + 1; i++)
             {
                list += i + " ";
             }
             Console.WriteLine(list);
            }
        }
        public static void WriteNThrough1_While(int n)
        {
            if(n <= 0)
            {
                Console.WriteLine(n + " is out of range");
            }

            else
            {
             int start = 1;
             string list = "";
             while(n >= start)
                {
                list += n + " "; 
                n--;
                }
                Console.WriteLine(list);
            }
        }
        public static void WriteNThrough1_For(int n)
        {
            if(n <= 0)
            {
                Console.WriteLine(n + " is out of range");
            }

            else
            {
                string list = "";
             for(int i = n; i >= 1; i--)
             {
                list += i + " ";
             }
             Console.WriteLine(list);
            }
        }
        public static void WriteEvensThrough100()
        {
            int n = 0;
            string list = "";
            while(n <= 100)
            {
                n++;
                if(n % 2 == 0)
                {
                    list += n + " ";
                }
            }
            Console.WriteLine(list);
        }
        public static void FindSum(int n)
        {
             if(n <= 0)
            {
                Console.WriteLine(n + " is out of range");
            }
            else
            {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            }
        }
        public static void FindSumOfEvenNumbers(int n)
        {
            if(n <= 0)
            {
                Console.WriteLine(n + " is out of range");
            }
            else
            {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                sum += i;
                }
            }
            Console.WriteLine(sum);
            }
        }
        public static void FindSumOfOddNumbers(int n)
        {
             if(n <= 0)
            {
                Console.WriteLine(n + " is out of range");
            }
            else
            {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                if(i % 2 != 0)
                {
                sum += i;
                }
            }
            Console.WriteLine(sum);
            }
        }
        public static void OutputRightTriangle(int n)
        {
            if(n == 0)
            {
              Console.WriteLine(n + " is out of range");
            }
            else if(n < 0)
            {
                for(int i = n; i < 0; i++)
                {
                    string list = "";
                    for(int j = -1; j >= i; j--)
                    {
                        list += "*";
                    }
                    Console.WriteLine(list);
                }
            }
            else if(n > 0)
            {
                for(int i = 1; i <= n; i++)
                {
                    string list = "";
                    for(int j = 1; j <= i; j++)
                    {
                        list += "*";
                    }
                    Console.WriteLine(list);
                }
            }
        }
        
}