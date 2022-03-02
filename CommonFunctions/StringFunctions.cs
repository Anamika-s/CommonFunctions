using System;
using System.Collections.Generic;
using System.Text;

namespace CommonFunctions
{
    public class StringFunctions
    {
        public string CombineNames(string s1 ,string s2)
        {
            return string.Concat(s1, " ", s2);
        }
        public string[] SplitSentence(string sentence)
        {
            string[] str = sentence.Split();
            return str;

        }
        public string Table(int num, int start , int last)
        {
            StringBuilder sb = new StringBuilder(); 

            for(int i= start; i<= last; i++)
            {
                string str =num + " * " + i + " = " + num * i + "\n";
                sb.Append(str);
            }
            return sb.ToString(); 
        }
    }
}
