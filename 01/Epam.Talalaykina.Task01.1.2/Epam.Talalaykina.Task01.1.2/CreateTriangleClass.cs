using System.Collections.Generic;

namespace Epam.Talalaykina.Task01._1._2
{
    public class CreateTriangleClass
    {
        public List<string> TriangleCreating(int n)
        {
            List<string> resultList = new List<string>();
            
            for (int i = 0; i < n; i++)
            {
                string resultString = "";
                for (int j = 0; j <= i; j++)
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