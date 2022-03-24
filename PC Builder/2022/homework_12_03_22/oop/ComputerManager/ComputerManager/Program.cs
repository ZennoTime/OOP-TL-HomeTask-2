using ComputerManager;
using ComputerManager.Parts.GraphicalCards;
using ComputerManager.Parts.Motherboards;
using ComputerManager.Parts.Processors;
using ComputerManager.Parts.Rams;
using System;

namespace PC
{
    public class Program
    {
        public static void Main() 
        {
            var cpu = new AMDRyzen9();
            var ram = new KingstonRx8();
            var mbd = new GIGABYTEA5();
            var gpu = new NVIDIAGTX1060ti();
            Computer computer = new(mbd, cpu, gpu, ram);
            Console.WriteLine(computer.GetInfo());
        }
    }
}

