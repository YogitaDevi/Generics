using System;

namespace UC2_MaxFloat
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Find Max Float number : ");
            double output = MaxFloatNumber.MaximumFloatNumber(11.22, 22.0, 67.5);
            Console.WriteLine(output);
        }
    }
}
