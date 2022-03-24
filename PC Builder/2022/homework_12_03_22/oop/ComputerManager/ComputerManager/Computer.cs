using ComputerManager.Parts.GraphicalCards;
using ComputerManager.Parts.Motherboards;
using ComputerManager.Parts.Processors;
using ComputerManager.Parts.Rams;
using System;

namespace ComputerManager
{

    public class Computer
    {
        public Motherboard Motherboard { get; private set; } // init
        public Processor Processor { get; private set; }
        public GraphicalCard GraphicalCard { get; private set; }
        public RandomAccessMemory RandomAccessMemory { get; private set; } //Можем получить свойства и тд этого класса из любого места, но pirvate set  

        public Computer
        (
            Motherboard motherboard,
            Processor processor,
            GraphicalCard graphicalCard,
            RandomAccessMemory randomAccessMemory
        )
        {
            Motherboard = motherboard ?? throw new ArgumentNullException(nameof(motherboard));
            Processor = processor ?? throw new ArgumentNullException(nameof(processor));
            GraphicalCard = graphicalCard ?? throw new ArgumentNullException(nameof(graphicalCard));
            RandomAccessMemory = randomAccessMemory ?? throw new ArgumentNullException(nameof(randomAccessMemory));
        }

        public string GetInfo()
        {
            string randomAccessMemory = RandomAccessMemory.GetInfo();
            string processor = Processor.GetInfo();
            string motherboard = Motherboard.GetInfo();
            string graphicalCard = GraphicalCard.GetInfo();
            return (motherboard + processor + graphicalCard + randomAccessMemory);
 
        }
    }
}
