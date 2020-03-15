using System;

namespace HowTo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example how to use it");
        }

        public bool countToTen()
        {
            HowToUseIt useIt = new HowToUseIt();

            for (int i = 0; i < 10; i++)
            {
                useIt.addOne();
            }

            if (useIt.getNumber().Equals(10)) { return true; } else { return false; };
        }
    }

    public class HowToUseIt
    {
        public int number = 0;

        public void addOne()
        {
            Console.Write("Changed number from " + number);
            number++;
            Console.WriteLine(" to " + number);
        }

        public int getNumber()
        {
            return number;
        }
    }
}
