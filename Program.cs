using System;

namespace runtime_info_mono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Process Architecture: " + System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture);
        }
    }
}
