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
    
    class Dog
    {
        public Dog(string name, string breed)
        {
            dogName = name;
            dogBreed = breed;
        }
        public string dogName;
        public string dogBreed;
        public Dog nextDog;
        public Dog previousDog;
    }
    class BirthdayParty
    {
        public Dog peanut;
        public Dog fifi;
        public Dog clarence;
        public Dog roy;

        public Dog head;
        public Dog tail;
        public Dog temporary;
        
        public void Pea()
        {
            peanut = new Dog("Peanut", "Bichon");
            fifi = new Dog("Fifi", "Poodle");
            clarence = new Dog("Clarence", "German Sheppard");
            roy = new Dog("Roy", "Beagle");

            peanut.previousDog = null;
            peanut.nextDog = fifi;
            fifi.previousDog = peanut;
            fifi.nextDog = clarence;
            clarence.previousDog = fifi;
            clarence.nextDog = roy;
            roy.previousDog = clarence;
            roy.nextDog = null;
            head = peanut;
            tail = roy;


        }
    }
}
