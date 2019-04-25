using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Demoinheritence1
    {


        public Demoinheritence1()
        {
            Console.WriteLine("this is demoinherits1  base class  without param constructor  : default Con   ");
        }

        public   Demoinheritence1(string str){
            Console.WriteLine("this is demoinherits1  base class param constructor  :   "  + str);
        }       

        protected void printmessage() {
            Console.WriteLine("this is demoinherits1 method in  base class");
        }


        public void logmessage()
        {
            Console.WriteLine("this is demoinherits1 method in  base class- logmessage");
        }

        public  virtual void vmprint()
        {
            Console.WriteLine("this is demoinherits1 method in  base class with virtual");
        }


        public virtual void Vmprint2()
        {
            Console.WriteLine("this is demoinherits1 method in  base class with virtual");
        }


        void printmessage2() {

            Console.WriteLine("this is demoinherits1  method 2 in  base class");
        }
    }


    class Demosub : Demoinheritence1  {

       //public Demosub() : base("new var")  { }


        public Demosub(int k) : base("new var")
        {
            Console.WriteLine("this is Demosub  derived class param constructor  :   " + k);

        }


        public new void logmessage()
        {
            Console.WriteLine("this is demoinherits1 method in  derived class with new keyword");
        }

        public override void vmprint()
        {
            Console.WriteLine("this is demoinherits1 method in  derived class- overrride method");
        }


        public new  void Vmprint2()
        {
            Console.WriteLine("this is demoinherits1 method in  derived  class- new  method");
        }


        public void message() {

            printmessage();


        }


    }
}
