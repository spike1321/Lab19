using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Computer
    {
        public string Code { get; set; }
        public string Brand { get; set; }
        public string ProcessorType { get; set; }
        public double ProcessorFrequency { get; set; }
        public int RAM { get; set; } 
        public int HardDisk { get; set; }
        public int VideoMemory { get; set; } 
        public double Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Code} | {Brand} | {ProcessorType} | {ProcessorFrequency}ГГц | ОЗУ {RAM}GB | {HardDisk}ГБ | Объём видеокарты {VideoMemory}ГБ | {Price}цена | {Quantity} экземпляров";
        }
    }
}
