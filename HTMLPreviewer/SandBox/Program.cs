namespace SandBox
{
    using System;
    using System.IO;
    using System.Text;
    class Program
    {
        static void Main()
        {
            var str = File.ReadAllText("../../../../../test.txt");
            decimal megabyteSize = ((decimal)Encoding.Unicode.GetByteCount(str)/(1024*1024));
            Console.WriteLine(megabyteSize);
        }
    }
}
