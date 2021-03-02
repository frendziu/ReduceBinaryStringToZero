using System;
using System.Text;

namespace ReduceBinaryStringToZero
{
    class Program
    {
        static int solution(string S)
        {

            int count = -1;
            int firstOneAt = S.IndexOf("1");
            
            
            //Check if string is correct
            int l = S.Length;
            for(int i = 0; i<l; i++)
            {
                if(S[i]!='0' && S[i]!='1')
                {
                    Console.WriteLine("Incorrect Binary String");
                   return count;
                    
                }
            }

            /*Calculation conditions:
             * if V is even divide by 2
             * if V is odd subtract by 1
             */
            if(S.StartsWith('0'))
            {
                S = S.Substring(firstOneAt);
            }

            var stringBuilder = new StringBuilder(S);

            while (!String.IsNullOrEmpty(S))
            {
                
                if (S.EndsWith('1'))
                {
                    stringBuilder.Remove(S.Length -1 , 1);
                    stringBuilder.Insert(S.Length - 1, '0');
                    S = stringBuilder.ToString();
                    count++;
                }
                else
                {
                    stringBuilder.Remove(S.Length - 1, 1);
                    S = stringBuilder.ToString();
                    count++;
                }
            }
            

             return count;

        }
        static void Main(string[] args)
        {
            string s1 = "00011100";
            string s2 = "111";
            string s3 = "1111010101111";
            string s4 = "";


            Console.WriteLine("String "+s1+" Number of operations: " + solution(s1));
            Console.WriteLine("String " + s2 + " Number of operations: " + solution(s2));
            Console.WriteLine("String " + s3 + " Number of operations: " + solution(s3));
            Console.WriteLine("String " + s4 + " Number of operations: " + solution(s4));
            
        }
    }
}
