using System;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            // Arithmetic Operators
            bool result;
            int numberOne = 10, numberTwo = 20;
            result = (numberOne == numberTwo);
            Console.WriteLine("{0} == {1} returns {2}", numberOne, numberTwo, result);

            result = (numberOne > numberTwo);
            Console.WriteLine("{0} > {1} returns {2}", numberOne, numberTwo, result);

            result = (numberOne < numberTwo);
            Console.WriteLine("{0} < {1} returns {2}", numberOne, numberTwo, result);

            result = (numberOne != numberTwo);
            Console.WriteLine("{0} != {1} returns {2}", numberOne, numberTwo, result);

            //Logical
            // OR
            result = (numberOne == numberTwo) || (numberOne >5);
            Console.WriteLine(result);
            // AND
            result = (numberOne == numberTwo) && (numberOne > 5);
            Console.WriteLine(result);

            //Unary

            int number = 1;
            ++number;
            Console.WriteLine("+number "+ number);

            bool flag = true;
            Console.WriteLine("!flag= " + (!flag));

            // variable=condition? Expression1:Expression2
            string _result = number > 0 ? "Greater" : " No Greater";
            Console.WriteLine("{0} is {1}", number, _result);
            //Compound Assugnment
            number += 5;
            Console.WriteLine(number);
        }
    }
}
