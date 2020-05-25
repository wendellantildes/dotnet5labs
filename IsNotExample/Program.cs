using System;

namespace IsNotExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrase = new object[] { null, "This", "is", ".net", 5 , null};
            TheOldWay(phrase);
            Console.WriteLine();
            Console.WriteLine("######");
            Console.WriteLine();
            TheNewWay(phrase);
        }


        public static void TheOldWay(object[] phrase)
        {
            Console.WriteLine("The old way");
            foreach(var word in phrase)
            {
                if(!(word is null))
                {
                    Console.WriteLine($"The word \"{word}\" was found!");
                }
                else
                {
                    Console.WriteLine("A null word was found!");
                }
            }
        }

        public static void TheNewWay(object[] phrase)
        {
            Console.WriteLine("The new way");
            foreach (var word in phrase)
            {
                if (word is not null)
                {
                    Console.WriteLine($"The word \"{word}\" was found!");
                }
                else
                {
                    Console.WriteLine("A null word was found!");
                }
            }
        }
    }
}
