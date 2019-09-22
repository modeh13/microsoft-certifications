using System;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odds numbers:");
            var oddGenerator = new OddGenerator();

            foreach(var odd in oddGenerator)
            {
                if(odd > 50)
                    break;

                Console.WriteLine(odd);
            }
        }
    }
}