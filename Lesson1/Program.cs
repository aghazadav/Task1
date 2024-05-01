using System.Threading.Channels;

namespace Lesson1
{   
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            //İstifadəçidən 3 ədəd alıb onların cəmini tapmalısınız.
            //Düzgün ədəd daxil edilməsə yenidən istifadəçidən ədəd daxil etməsini istəyin.

            Console.WriteLine("Welcome to Task1");
            
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine($"Please input first number");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                   Console.WriteLine($"Please only use numbers");
                }
            } while (true)
            {
                try
                {
                    Console.WriteLine($"Please input second number");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine($"Please only use numbers");
                }
            } while (true)
            {
                try
                {
                    Console.WriteLine($"Please input third number");
                    number3 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine($"Please only use numbers");
                }
            }

            int res = Sum(number1, number2, number3);
            Console.WriteLine($"Sum = {res}");

        }
        private static int Sum(int number1, int number2, int number3)
        {
            int sum = number1 + number2 + number3;
            return sum;
        }
    }
}
