using System.Collections.Generic;

namespace Epam.Talalaykina.Task01._1._3
{
    public class CreateTriangleClass
    {
        public List<string> TriangleCreating(int n)
        {
            List<string> resultList = new List<string>();
            
            for (int i = 0; i < n; i++)
            {
                string resultString = "";
                for (int j = 0; j < n - i - 1; j++)
                {
                    resultString += " ";
                }
                for (int k = 0; k <= i * 2; k++)
                {
                    resultString += "*";
                }
                resultString += "\n";
                resultList.Add(resultString);
            }

            return resultList;

        }
    }
}