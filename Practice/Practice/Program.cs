using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----- this is calss generic---");
            var gne = new generics();
            gne.validate1<int>("3", 3);


            gne.mDictionary();

            Console.WriteLine("---- this is calss interfave---");


            cInterface cint = new cInterface();
            cint.mSample1();
            cint.msample2();


            Isample1 cn = new cInterface();
            cn.mSample1();

            Console.WriteLine("---- this is calss abstract class---");
            demoabs abs = new Employe();
            abs.person();



            Console.WriteLine("---- this is calss inherits class---");

            Demosub ds = new Demosub(3);

            ds.message();
            ds.vmprint();
            ds.Vmprint2();
            ds.logmessage();


            Console.WriteLine("---- this is calss STATIC class---");
            DemoStatic dst = new DemoStatic();
            dst.Verify2();
            DemoStatic.x = 9;
            DemoStatic.Verify();


            Student stud1 = new Student(101);
            int x = 5,y;
            stud1.Log(ref x,out y);
            Student stud2 = new Student(102, "David");
           x = 10;
            stud1.Log(ref x,out y);


            Console.WriteLine(stud1.getaverage(20,r:40));


            Console.ReadKey();
        }
    }

}
