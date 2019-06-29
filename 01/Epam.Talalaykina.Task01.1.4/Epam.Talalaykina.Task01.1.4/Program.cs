namespace Epam.Talalaykina.Task01._1._4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            CreateXmasTreeClass createXmasTreeClass = new CreateXmasTreeClass();
            
            workWithConsoleClass.Output(createXmasTreeClass.XmasTreeCreating(workWithConsoleClass.Input()));
        }
    }
}