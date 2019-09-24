using System;

// The Indexers are knows is smart arrays
namespace Indexers
{
    public class SampleCollection
    {
        private readonly int[] _array = new int[60];

        public int this[int i]
        {
            get => _array[i];
            set => _array[i] = value;
        }
    }
    class Program
    {
        static void Main()
        {
            SampleCollection sampleCollection = new SampleCollection();
            sampleCollection[0] = 1225;
            sampleCollection[1] = 1226;
            var userName = "Thai";
            Console.WriteLine($"The value ={sampleCollection[1]}, va username={userName}");
        }
    }
}
