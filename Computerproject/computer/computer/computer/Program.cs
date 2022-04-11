
using computer.Parts.GraphicalCards;
using computer.Parts.Rams;
using Parts.MotherBoards;
using сomputer.Parts.Processors;

KingstonRx8 rx8 = new();
Console.WriteLine(rx8.GetInfo());
PalitGeForceRTX3090 RTX3090 = new();
Console.WriteLine(RTX3090.GetInfo());
Supermicro supermicro = new();
Console.WriteLine(supermicro.GetInfo());
AMDRyzenThreadripperPRO3995 AMDRyzen = new();
Console.WriteLine(AMDRyzen.GetInfo());