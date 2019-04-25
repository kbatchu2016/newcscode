using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    abstract class demoabs
    {


        /// <summary>
        /// field value 
        /// </summary>
        int k = 9;

        /// <summary>
        /// constructor
        /// </summary>
        public demoabs()
        {

            Console.WriteLine("This is the constructor of the class");
        }

        /// <summary>
        /// abstract class method declaration only
        /// </summary>

        public abstract void person();

    }


    class Employe : demoabs
    {

        int k = 10;
        public override void person()
        {

            Console.WriteLine("this is employee");
        }
    }



}
