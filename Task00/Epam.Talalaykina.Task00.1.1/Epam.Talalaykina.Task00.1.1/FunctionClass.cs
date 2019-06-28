namespace Epam.Talalaykina.Task00._1._1
{
    public class FunctionClass
    {
        public string StringCreation(int n)
        {
            string resultString = "";
            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    resultString += i;
                }
                else
                {
                    resultString += i + ", ";
                }
                
            }

            return resultString;
        }
    }
}