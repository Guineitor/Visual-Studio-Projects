using System;
using System.Text;
using System.Linq;

namespace Siblings
{
    class AppSiblings
    {
        static void Main(string[] args)
        {

            Console.Write("Number: ");

            var console  = Console.ReadLine();
            int n;
            Int32.TryParse(console, out n);
            

            Console.WriteLine(solution(n));
            closing();
        }

        static int solution(int n)
        {
            
            int cnt = 0;
            char[] list = new char[8] ;
            string strN = Convert.ToString(n);
            int ret = -1;
            
            if(strN.Length <= 8)
            {
                foreach (char c in strN)
                {
                    list[cnt] = c;
                    cnt += 1;
                }
                list = list.OrderByDescending(l => l).ToArray();
                ret = Convert.ToInt32(buildNumber(list));
            }
            return ret;
        }

        static string buildNumber(char[] str)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char n in str)
            {
                builder.Append(n);
            }
            string number = builder.ToString();

            return number;
        }

        static void closing()
        {
            Console.WriteLine("press any key to quit ... ");
            Console.ReadKey();
        }
    }
}
