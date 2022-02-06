using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор");
            
            try
            {
                Console.WriteLine("Введите целые числа");
                Console.Write("X = ");
                decimal X = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Y = ");
                decimal Y = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Введите код операции:\n 1 - сложение \n 2 - вычитание \n 3 - произведение \n 4 - частное");
                
                int code = Convert.ToInt32(Console.ReadLine());
                switch (code)
                {
                    case 1:
                        {
                            Console.WriteLine("Результат={0}", X + Y);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат={0}", X - Y);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат={0}", X * Y);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Результат={0:f2}", X / Y);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет операции с указанным номером");
                            break;
                        }
                }
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка, деление на ноль");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка, входная строка имеет неверный формат");
            }
            
            Console.ReadKey();

        }
    }
}
