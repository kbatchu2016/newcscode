using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class generics
    {

        public void validate1<T>(string vble1, T vble2)
        {
            Console.WriteLine(vble1.Equals(vble2));

        }


        public void mDictionary() {

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "one");
            dic.Add(2, "one2");
            dic.Add(3, "one3");
            dic.Add(4, "one4");



            foreach (int k in dic.Keys) {
    
                Console.WriteLine(k + " key value"  + dic[k]);
            }

            if (dic.ContainsKey(3)) dic.Remove(3);


            List<int> keylist = new List<int>( dic.Keys);

            keylist.ForEach(k => Console.WriteLine("in list "+k));

            keylist.Insert(2,3);

            foreach ( int k in keylist ) {
                Console.WriteLine(k);
                if(dic.ContainsKey(k))
                Console.WriteLine(dic[k]);
            }


            



        }
    }
}
