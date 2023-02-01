namespace Practice_Mosh.Intermediate
{
    internal class SQLConnection : DbConnection
    {
        public SQLConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Closing SQL Connection");
        }

        public override void Open()
        {
            Console.WriteLine("Opening SQL Connection");
        }
    }
}
