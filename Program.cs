using System;

namespace FrogJmp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FrogJmp fi = new FrogJmp();


            var value1 = fi.solution(10, 85, 30);
            var value2 = fi.solution(1, 5, 6);
            var value3 = fi.solution(5, 500, 45);
            var value4 = fi.solution(12, 36, 2);
            var value5 = fi.solution(12, 36, 12);
            var value6 = fi.solution(3, 999111321, 7);

            //3, 999111321, 7

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);
            Console.WriteLine(value5);
            Console.WriteLine(value6); //142730192 expected 142730189
        }


    }
}
