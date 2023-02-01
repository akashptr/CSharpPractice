namespace Practice_Mosh.Intermediate.Extensibility
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Info: " + message);
        }
    }
}
