namespace IDFOperation;

internal class Program
{
    static void Main(string[] args)
    {
        DefinitionsIDF definitionsIDF = new DefinitionsIDF("zmir");
        definitionsIDF.WeaponsReport();


        Console.WriteLine("Hello, World!");
    }
}
