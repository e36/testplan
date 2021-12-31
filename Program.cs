using System;

namespace testplan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting testplan");

            // test for arguments, we'll modify this later to parse them
            // Not sure yet what kind or args we'll use, but I'd like to have one for auto-generating
            // the files needed to run a test
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments");
            } else {
                Console.WriteLine($"{args.Length} arguments found!");
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }


        }
    }
}
