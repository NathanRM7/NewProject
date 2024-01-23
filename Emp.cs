//using Microsoft.IdentityModel.Tokens;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata.Ecma335;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAPp
//{
//   public class Emp
//    {
//        public int id { get; set; }
//        public string MyProperty { get; set; }

//        public bool IsAnagram(string s, string t)
//        {
//            if (s.Length != t.Length)
//            {
//                return false;
//            }
//            List<char> obj = new List<char>();
//            List<char> obj1 = new List<char>();
//            char[] ch = new char[s.Length];
//            char[] c = new char[s.Length];
//            for (int i = s.Length - 1; i >= 0; i--)
//            {

//                ch[i] = s[i];
//                c[i] = t[i];

//            }
//            Array.Sort(c);
//            Array.Sort(ch);
//            string si = "";
//            string li = "";
            
//            for (int i = 0; i < ch.Length; i++)
//            {
//                si += ch[i];
//                li += c[i];
               
//            }
//            if (si.Equals(li))
//            {

//                return true;
//            }
//            return false;
           
//        }
//        public int AddDigits(int num)
//        {
//            IList<int> obj =new List<int>(); 
//            int sum = 0, rem = 0;
//            while (num != 0) {
//                sum += num % 10;//8
//                num = num / 10;
               
//                    sum = sum + num % 10;



//                }
//                Console.WriteLine(sum);
//                num = sum;
              
               
//            }
            
//            return 1;

//        }

//    }
//}
