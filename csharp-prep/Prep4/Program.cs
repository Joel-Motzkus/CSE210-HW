using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int user_list = -1;
        while (user_list != 0);
        {
            Console.WriteLine("Enter a list of number. Enter 0 when finished.");

            string user_number = Console.ReadLine();
            user_list = int.Parse(user_number);

            if (user_list != 0)
            {
                User.add(user_list);
            }
            
        }