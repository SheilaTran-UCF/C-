using System;

namespace Delegates
{
    public delegate void StringDelegates(string test);
    class Program
    {
        static void Main()
        {
            StringDelegates stringDelegates = ToUpperCase;
            stringDelegates("value is Upper");
            stringDelegates.Invoke("this is another lowerCase string");
            WriteTest("This is value input", stringDelegates);

            //event
            var myString=new Strings();
            myString.StringEvent += ToChanged;

            string stringInput;
            do
            {
                stringInput = Console.ReadLine();
                if (stringInput != null && !stringInput.Equals("exit")) myString.Value = stringInput;

            } while (stringInput != null && !stringInput.Equals("exit"));
        }

        static void ToUpperCase(string test) => Console.WriteLine(test.ToUpper());

        static void ToChanged(string test) => Console.WriteLine($"You enter : {test}");

        static void WriteTest(string test, StringDelegates stringDelegates)
        {
            Console.WriteLine($"Before:{test}");
            stringDelegates(test);
        }
    }

    public class Strings
    {
        private string _stringValue;
        public event StringDelegates StringEvent;

        public string Value
        {
            set
            {
                _stringValue = value;
                StringEvent?.Invoke(_stringValue);
            }
        }
    }
}
