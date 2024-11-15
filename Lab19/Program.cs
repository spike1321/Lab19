using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Computer> computers = new List<Computer>
        {
            new Computer { Code = "1", Brand = "Brand MSI", ProcessorType = "Intel", ProcessorFrequency = 3.1, RAM = 8, HardDisk = 512, VideoMemory = 4, Price = 700, Quantity = 25 },
            new Computer { Code = "2", Brand = "Brand Acer", ProcessorType = "AMD", ProcessorFrequency = 3.5, RAM = 16, HardDisk = 1000, VideoMemory = 6, Price = 1000, Quantity = 5 },
            new Computer { Code = "3", Brand = "Brand ASUS", ProcessorType = "Intel", ProcessorFrequency = 3.0, RAM = 4, HardDisk = 256, VideoMemory = 2, Price = 450, Quantity = 50 },
            new Computer { Code = "4", Brand = "Brand HP", ProcessorType = "Intel", ProcessorFrequency = 3.6, RAM = 32, HardDisk = 2000, VideoMemory = 8, Price = 1500, Quantity = 10 },
            new Computer { Code = "5", Brand = "Brand ASUS", ProcessorType = "AMD", ProcessorFrequency = 3.7, RAM = 16, HardDisk = 1000, VideoMemory = 6, Price = 1200, Quantity = 15 },
            new Computer { Code = "6", Brand = "Brand HP", ProcessorType = "Intel", ProcessorFrequency = 2.8, RAM = 8, HardDisk = 512, VideoMemory = 4, Price = 600, Quantity = 40 },
        };


                Console.Write("Введите тип процессора для поиска: ");
                string processor = Console.ReadLine();
                var filteredProcessor = computers.Where(c => c.ProcessorType.Equals(processor, StringComparison.OrdinalIgnoreCase)).ToList();
                Console.WriteLine($"Компьютеры с процессором {processor}:");
                foreach (var computer in filteredProcessor)
                {
                    Console.WriteLine(computer);
                }


                Console.Write("Введите минимальный объем ОЗУ (ГБ) для поиска: ");
                int ramSearch = int.Parse(Console.ReadLine());
                var filteredRAM = computers.Where(c => c.RAM >= ramSearch).ToList();
                Console.WriteLine($"Компьютеры с объемом ОЗУ не ниже {ramSearch} ГБ:");
                foreach (var computer in filteredRAM)
                {
                    Console.WriteLine(computer);
                }


                var sortedPrice = computers.OrderBy(c => c.Price).ToList();
                Console.WriteLine("Список компьютеров, отсортированный по стоимости:");
                foreach (var computer in sortedPrice)
                {
                    Console.WriteLine(computer);
                }


                var groupedProcessor = computers.GroupBy(c => c.ProcessorType);
                Console.WriteLine("Группировка по типу процессора:");
                foreach (var group in groupedProcessor)
                {
                    Console.WriteLine($"Процессор: {group.Key}");
                    foreach (var computer in group)
                    {
                        Console.WriteLine(computer);
                    }
                }


                var mostExpensive = computers.OrderByDescending(c => c.Price).First();
                var cheapest = computers.OrderBy(c => c.Price).First();
                Console.WriteLine($"Самый дорогой компьютер: {mostExpensive}");
                Console.WriteLine($"Самый бюджетный компьютер: {cheapest}");


                bool Quantity = computers.Any(c => c.Quantity >= 30);
                Console.WriteLine($"Есть ли компьютер в количестве не менее 30 штук? {(Quantity ? "Да" : "Нет")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    
    
    }
}
