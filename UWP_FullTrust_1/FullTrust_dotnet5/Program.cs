using System;

namespace FullTrust_dotnet5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello Modified World";
            Console.WriteLine("This process runs at the full privileges of the user and has access to the entire public desktop API surface");
            Console.WriteLine("\r\nPress any key to exit ...");
            Console.ReadLine();
        }
    }
}
