using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SolutionExamples { 
  
    public class MyBenchmarkSorting
    {

        [Benchmark]
        public void RunBubbleSortHundredElements()
        {
            int[] num = RandomArray(100);
            SortingAlgorithms.BubbleSort(num);
        }

        [Benchmark]
        public void RunBubbleSortTenThousandElements()
        {
            int[] num = RandomArray(10000);
            SortingAlgorithms.BubbleSort(num);
        }

        [Benchmark]
        public void RunShakerSortHundredElements()
        {
            int[] numbers = RandomArray(100);
            SortingAlgorithms.ShakerSort(numbers);
        }
        [Benchmark]
        public void RunShakerSortTenThousandElements()
        {
            int[] numbers = RandomArray(10000);
            SortingAlgorithms.ShakerSort(numbers);
        }

        //[Benchmark]
        //public void RunInsertionSortHundredElements()
        //{
        //    int[] numbers = RandomArray(100);
        //    SortingAlgorithms.InsertionSort(numbers);

        //}

        //[Benchmark]
        //public void RunInsertionSortTenThousandElements()
        //{
        //    int[] numbers = RandomArray(10000);
        //    SortingAlgorithms.InsertionSort(numbers);

        //}

        //[Benchmark]
        //public void RunShellSortHundredElements()
        //{
        //    int[] numbers = RandomArray(100);
        //    SortingAlgorithms.ShellSort(numbers);

        //}
        //[Benchmark]
        //public void RunShellSortTenThousandElements()
        //{
        //    int[] numbers = RandomArray(10000);
        //    SortingAlgorithms.ShellSort(numbers);

        //}

        //[Benchmark]
        //public void RunCombSortHundredElements()
        //{
        //    int[] numbers = RandomArray(100);
        //    SortingAlgorithms.CombSort(numbers);

        //}


        //[Benchmark]
        //public void RunCombSortTenThousandElements()
        //{
        //    int[] numbers = RandomArray(10000);
        //    SortingAlgorithms.CombSort(numbers);

        //}

        //[Benchmark]
        //public void RunSelectionSortHundredElements()
        //{
        //    int[] numbers = RandomArray(100);
        //    SortingAlgorithms.SelectionSort(numbers);

        //}
        //[Benchmark]
        //public void RunSelectionSortTenThousandElements()
        //{
        //    int[] numbers = RandomArray(10000);
        //    SortingAlgorithms.SelectionSort(numbers);

        //}

        //[Benchmark]
        //public void RunStoogeSortHundredElements()
        //{
        //    int[] numbers = RandomArray(100);
        //    SortingAlgorithms.StoogeSort(numbers,0,numbers.Length-1);

        //}
        //[Benchmark]
        //public void RunStoogeSortTenThousandElements()
        //{
        //    int[] numbers = RandomArray(10000);
        //    SortingAlgorithms.StoogeSort(numbers, 0, numbers.Length - 1);

        //}

        //[Benchmark]
        //public void RunQuickSortHundredElements()
        //{
        //    int[] numbers = RandomArray(100);
        //    SortingAlgorithms.QuickSort(numbers, 0, numbers.Length - 1);

        //}


        //[Benchmark]
        //public void RunQuickSortTenThousandElements()
        //{
        //    int[] numbers = RandomArray(10000);
        //    SortingAlgorithms.QuickSort(numbers, 0, numbers.Length - 1);

        //}

        //[Benchmark]
        //public void RunGnomeSortHundredElements()
        //{
        //    int[] numbers = RandomArray(100);
        //    SortingAlgorithms.GnomeSort(numbers);

        //}
        //[Benchmark]
        //public void RunGnomeSortTenThousandElements()
        //{
        //    int[] numbers = RandomArray(10000);
        //    SortingAlgorithms.GnomeSort(numbers);

        //}

        //[Benchmark]
        //public void RunMergeSortHundredElements()
        //{
        //    int[] numbers = RandomArray(100);
        //    SortingAlgorithms.MergeSort(numbers,0,numbers.Length-1);

        //}

        //[Benchmark]
        //public void RunMergeSortTenthousandElements()
        //{
        //    int[] numbers = RandomArray(10000);
        //    SortingAlgorithms.MergeSort(numbers, 0, numbers.Length - 1);

        //}

        public int[] RandomArray(int len)
        {
            Random random = new Random();
            int[] arr = new int[len];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = random.Next(-100,100);
            return arr;

        }


    }
}
