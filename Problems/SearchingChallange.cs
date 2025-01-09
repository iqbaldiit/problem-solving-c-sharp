using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.Topic
{
    public static class SearchingChallange
    {
        public static string SearchingChallenge(string str)
        {

            var varOcg = 0;
            foreach (char c in str)
            {
                if (c == '(')
                {
                    varOcg++;
                }
                else if (c == ')')
                {
                    varOcg--;
                }

                if (varOcg < 0)
                {
                    varOcg= 1;
                }
            }

            var abc=varOcg == 0 ? 1 : 0;
            return str=abc.ToString();

        }

        public static void Execute()
        {
            Console.WriteLine(SearchingChallange.SearchingChallenge(Console.ReadLine()));
        }
    }
}
