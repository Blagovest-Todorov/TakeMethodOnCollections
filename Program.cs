using System;
using System.Linq;
using System.Collections.Generic;


namespace _06.TakeMethodOnColelctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> products = new Dictionary<int, string>() 
            {
                {1, "Product 1" },
                {2, "Product 2" },
                {3, "Product 3" },
                {-1, "Product 3" }

            };

            Dictionary<int, string> orderedProducts = products.OrderBy(pair => pair.Value)
                                                               .ThenBy(pair => pair.Key)  //here first we order by Value then secondly by Key
                                                               .ToDictionary(pair => pair.Key, pair => pair.Value);

            Console.WriteLine(string.Join("\n", products.Take(2))); // We take only the first  2 elements -> Key-Value -pairs
            Console.WriteLine();            // using the method take( we take only the fiorst two elements from the list , from the Dictionary..)
            Console.WriteLine(string.Join("\n", orderedProducts));
        }
    }
}
