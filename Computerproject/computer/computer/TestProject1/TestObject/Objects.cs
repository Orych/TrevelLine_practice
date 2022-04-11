using computer.Parts.Rams;
using сomputer.Parts.Processors;
using computer.Parts.Motherboards;
using computer.Parts.GraphicalCards;

namespace TestObject
{
    public class RandomAccessMemoryImpl : RandomAccessMemory
    {
        public RandomAccessMemoryImpl(int memorySize)
            : base(memorySize)
        {
        }
    }
    public class ProcessorImpl : Processor
    {
        public ProcessorImpl(int memorySize)
            : base(memorySize)
        {
        }
    }
    public class MotherBoardImpl : Motherboard
    {
        public MotherBoardImpl(int memorySize)
            : base(memorySize)
        {
        }
    }
    public class GraphicCardImpl : GraphicalCard
    {
        public GraphicCardImpl(int memorySize)
            : base(memorySize)
        {
        }
    }
}