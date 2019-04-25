using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
   public  class  DemoStatic
    {

        public static int x=5;
        public static int Verify() {
            Console.WriteLine(" this is calling from static method x=." +x);
            return x;

        }

        public void Verify2() {

            Console.WriteLine(" this is calling from non-static method.");
        }

    }



    class Student
    {
        private int ID;
        private string name;
        public Student(int u)
        {
            ID = u;
            name = "Kelly";
            Console.WriteLine("constructer1  " +  ID + name);
        }
        public Student(int u, string v) : this(u)
        {
            name = v;
            Console.WriteLine("constructer2  " +ID + name);
        }


        public   void Log(ref int x, out int y) {

            y = x;

            Console.WriteLine(" from the log method   "  +ID + name );

            Console.WriteLine(" from the log method  y=  " + y);
        }


        public float getaverage(int p, int q = 10,int r=30)
        {
            float avg;

            Console.WriteLine(" from the getaverage method  y=  " + "p=" +p  + "q= "+q +"r="+  r  );
            avg = (float)(p + q + r) / 3;
            return avg;

        }


        }

    }
