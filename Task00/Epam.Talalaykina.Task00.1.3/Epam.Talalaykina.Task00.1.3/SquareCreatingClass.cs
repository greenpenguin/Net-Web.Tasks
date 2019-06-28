using System.Collections.Generic;

namespace Epam.Talalaykina.Task00._1._3
{
    public class SquareCreatingClass
    {
        public List<string> SquareCreating(int n)
        {
            List<string> resultList = new List<string>();
            
            for (int i = 0; i < n; i++)
            {
                string resultString = "";
                for (int j = 0; j < n; j++)
                {
                    if ((i == n/2) && (j == n/2))
                    {
                        resultString += "  ";
                    }
                    else
                    {
                        resultString += "* ";
                    }
                }
                resultString += "\n";
                resultList.Add(resultString);
            }

            return resultList;
        }
    }
}