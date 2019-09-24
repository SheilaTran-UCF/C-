using System;
// ReSharper disable once InvalidXmlDocComment
/// <summary>
/// Multiple developers can work simultaneously with a single class in separate files
/// </summary>
namespace PartialClass
{
    class Program
    {
        static void Main()
        {
            var helloCSharp=new HelloCSharp();
            helloCSharp.HelloAmerica();
            helloCSharp.HelloVietNam();
        }
    }

    public partial class HelloCSharp
    {
        public void HelloVietNam() => Console.WriteLine("Hello VietNam!");
    }
    public partial class HelloCSharp
    {
        public void HelloAmerica() => Console.WriteLine("Hello America!");
    }
}
