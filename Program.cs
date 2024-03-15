using System.Threading.Channels;

namespace GBHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateArgs(args); //Метод работающий с аргументами
            Calculate(); //Метод работающий с введеными данными из консоли
        }

        static void CalculateArgs(string[] args)
        {
            try
            {
                if (args.Length == 3)
                {
                    if (args[1] == "+")
                        Console.WriteLine(int.Parse(args[0]) + int.Parse(args[^1]));
                    else if (args[1] == "-")
                        Console.WriteLine(int.Parse(args[0]) - int.Parse(args[^1]));
                    else if (args[1] == "/")
                        Console.WriteLine(int.Parse(args[0]) / int.Parse(args[^1]));
                    else if (args[1] == "*")
                        Console.WriteLine(int.Parse(args[0]) * int.Parse(args[^1]));
                    else
                        Console.WriteLine("Некорректный оператор");
                }
            }
            catch
            {
                Console.WriteLine("Введеные данные некорректны");
            }

        }

        static void Calculate()
        {
            Console.WriteLine("Введите выражение, каждое число/оператор на новой строке:");
            string[] args = { Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };
            CalculateArgs(args);
        }
    }
}
