namespace Epam.Talalaykina.Task01._1._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WorkWithConsoleClass workWithConsoleClass = new WorkWithConsoleClass();
            CreateTriangleClass сreateTriangleClass = new CreateTriangleClass();
            
            workWithConsoleClass.Output(сreateTriangleClass.TriangleCreating(workWithConsoleClass.Input()));

        }
    }
}