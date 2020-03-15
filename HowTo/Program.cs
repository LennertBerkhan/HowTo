using System;

namespace HowTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example how to use it");
            HowToUseIt useIt = new HowToUseIt();

            for (int i = 0; i < 10; i++)
            {
                useIt.addOne();
            }
        }
    }

    class HowToUseIt
    {
        int number = 0;

        public void addOne()
        {
            Console.Write("Changed number from " + number);
            number++;
            Console.WriteLine(" to " + number);
        }
    }
}
