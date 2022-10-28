using System;
namespace myApp
{
    abstract class Animal {
        public abstract void animalSound();// Abstract method (does not have a body)
        public void sleep()
        {
            Console.WriteLine("zzzzzzzz");
        }
    }
    class Pig : Animal
    {
         public override void animalSound ()
        {
            Console.WriteLine("the pig says We Weee");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Pig mypig = new Pig();
            mypig.animalSound();
            mypig.sleep();
        }
    }
}

