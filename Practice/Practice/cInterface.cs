using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{


    interface Isample1
    {
        int myproperty { get;set; }

        void mSample1();
    }

     interface Isample2 : Isample1 {



                int msample2();
    }

      class cInterface : Isample2
    {

       public int myproperty
        {

            get {

                return 0; }


            set { Console.WriteLine("set"); }
        }


        public int msample2() {
            Console.WriteLine(" this is the defining the interface calss Isample2");
            return 1;
        }

        public void  mSample1() {

            Console.WriteLine(" this is the defining the interface calss Isample1");
        }


    }
}
