using System.Collections.Generic;

namespace Epam.Talalaykina.Task01._1._4
{
    public class CreateXmasTreeClass
    {
            List<string> TriangleCreating(int n, int padding)
            {
                List<string> resultList = new List<string>();
            
                for (int i = 0; i < n; i++)
                {
                    string resultString = "";
                    
                    for (int j = 0; j < padding - i - 1; j++)
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

            public List<string> XmasTreeCreating(int n)
            {
                List<string> resultList = new List<string>();

                for (int i = 1; i <= n; i++)
                {
                    resultList.AddRange(TriangleCreating(i, n));
                    
                }
                
                return resultList;
            }
        }
}