using SolutionExamples;

namespace SolutionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0 ,-5};
            //int[] num = { 4, 3, 2, 1 }; 
            Console.WriteLine(String.Join(", ",num));
            Console.WriteLine(String.Join(", ", SortingAlgorithms.GnomeSort(num)));
          


        }
    }
}
