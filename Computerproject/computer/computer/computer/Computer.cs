using computer.Parts.GraphicalCards;
using computer.Parts.Motherboards;
using computer.Parts.Rams;
using сomputer.Parts.Processors;

namespace computer;

public class Computer
{
    public Motherboard Motherboard { get; private set; } // init
    public Processor Processor { get; private set; }
    public GraphicalCard GraphicalCard { get; private set; }
    public RandomAccessMemory RandomAccessMemory { get; private set; }

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
        throw new NotImplementedException();
    }
}