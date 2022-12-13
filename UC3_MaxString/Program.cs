using System;

namespace UC3_MaxString
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Find Max String : ");
            string stringOutput = MaxStringCheck.MaximumString("Apple","Peach","Banana");
            Console.WriteLine(stringOutput);
        }

    }
}
