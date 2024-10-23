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
        }
}