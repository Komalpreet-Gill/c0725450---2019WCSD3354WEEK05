using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0725450
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestQuestion2();
            a.PlayingWithForLoops();
        }
    }

    class TestQuestion2
    {
        public int myFavouriteVariable = 0;
        public void PlayingWithForLoops()
        {
            // write a for loop to add 10 numbers
            //Need to know the four types of variables in OO programming:
            //Scoping: Visibility: What we can see??
            // 
           
            for (; MyMethod(); )
            {
                if (myFavouriteVariable > 10)
                {
                    Console.WriteLine("I am so out of here!");
                    break;
                }
                Console.WriteLine("Oh no I have to go through this stupid loop again...");
            }

        }
        public bool MyMethod()
        {
            myFavouriteVariable++;
            return true;
        }
    }
}
