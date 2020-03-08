using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void print_menu()
        {
            Console.WriteLine("Привет! Это симуляци работы Барбершопа");
            Console.WriteLine("Есть такие функции:");
            Console.WriteLine("Добавить клиента - введите add_customer name last_name");
            Console.WriteLine("Добавить услугу - введите add_service name price");
            Console.WriteLine("Вывести информацию о Барбершопе - введите print_all");
            Console.WriteLine("Выйти - введите q");
        }
    }
}
