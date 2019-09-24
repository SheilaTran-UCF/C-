using System;
using System.Collections.Generic;

// ReSharper disable once InvalidXmlDocComment
/// <summary>
/// Generic cho phép bạn viết một lớp hoặc phương thức mà có thể làm việc với bất kỳ kiểu dữ liệu nào
/// </summary>
namespace Generics
{
    class Program
    {
        static void Main()
        {
            var oneTest = new Test<string>
            {
                Value = "Value input is string"
            };
            oneTest.Detail();

            var twoTest = new Test<int>
            {
                Value = 2
            };
            twoTest.Detail();

        }
    }

    public class Test<T>
    {
        public T Value { get; set; }

        public void Detail()=> Console.WriteLine($"Parameter type:{typeof(T)},Value={Value}");

    }
}
