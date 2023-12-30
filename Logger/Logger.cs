namespace project_2.Logger;

public class Logger(string outputPath = "log.csv")
{
    private readonly List<string> _log = [];

    public void AddEntry(string algorithm, string arrayValueType, int length, long ms)
    {
        _log.Add(
            algorithm + ";" + 
            arrayValueType + ";" + 
            length + ";" + 
            ms + ";"
        );
        Console.WriteLine("New log entry:");
        Console.WriteLine(_log.Last());
    }

    public void OutputToConsole()
    {
        Console.WriteLine(GetHeaderContent());
        
        foreach (var logEntry in _log)
        {
            Console.WriteLine(logEntry);
        }

        Console.ReadKey();
    }

    public void OutputToFile()
    {
        var contents = GetHeaderContent() + Environment.NewLine;
        foreach (var logEntry in _log)
        {
            contents += logEntry + Environment.NewLine;
        }

        try
        {
            File.WriteAllText(outputPath, contents);
        }
        catch (Exception e)
        {
            Console.WriteLine("Unable to write into file!");
            OutputToConsole();
        }
    }

    private static string GetHeaderContent()
    {
        return "Algorithm;Array value type;Array length;Elapsed time (ms);";
    }
}