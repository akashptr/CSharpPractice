namespace Practice_Mosh.Intermediate.Extensibility
{
    public class FileLogger : ILogger
    {
        private string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        private void Log(string message, string messageType)
        {
            using (StreamWriter sw = new StreamWriter(_path, true))
            {
                sw.WriteLine(messageType + ": " + message);
            }
        }
        public void LogError(string message)
        {
            Log(message, "Error");
        }

        public void LogInfo(string message)
        {
            Log(message, "Info");
        }
    }
}
