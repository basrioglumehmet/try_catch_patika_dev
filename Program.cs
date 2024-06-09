using System;

namespace try_catch_patika_dev
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int userIo = int.Parse(Console.ReadLine());
                int userIo2 = int.Parse(Console.ReadLine());
                int result = userIo / userIo2;
                Console.WriteLine("Result:" + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}