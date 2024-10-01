using BenchmarkDotNet.Attributes;
using SolutionExamples.ArraysFiles;

namespace SolutionExamples
{

    [MemoryDiagnoser]
    public class MyBenchmarkSorting
    {
        SortingAlgorithms sortingAlgorithms = new SortingAlgorithms();

        int[] arrayHundredElements = ArrayFileReader.ReadingArrayHundredElements();
        int[] arrayTenThousandElements = ArrayFileReader.ReadingArrayTenThousandElements();

        [Benchmark]
        public void RunBubbleSortHundredElements()
        {
            sortingAlgorithms.BubbleSort(arrayHundredElements);
        }

        [Benchmark]
        public void RunBubbleSortTenThousandElements()
        {
            sortingAlgorithms.BubbleSort(arrayTenThousandElements);
        }

        [Benchmark]
        public void RunShakerSortHundredElements()
        {
            sortingAlgorithms.ShakerSort(arrayHundredElements);
        }
        [Benchmark]
        public void RunShakerSortTenThousandElements()
        {
            sortingAlgorithms.ShakerSort(arrayTenThousandElements);
        }

        [Benchmark]
        public void RunInsertionSortHundredElements()
        {
            sortingAlgorithms.InsertionSort(arrayHundredElements);

        }

        [Benchmark]
        public void RunInsertionSortTenThousandElements()
        {
            sortingAlgorithms.InsertionSort(arrayTenThousandElements);

        }

        [Benchmark]
        public void RunShellSortHundredElements()
        {
            sortingAlgorithms.ShellSort(arrayHundredElements);

        }
        [Benchmark]
        public void RunShellSortTenThousandElements()
        {
           sortingAlgorithms.ShellSort(arrayTenThousandElements);

        }

        [Benchmark]
        public void RunCombSortHundredElements()
        {
            sortingAlgorithms.CombSort(arrayHundredElements);

        }


        [Benchmark]
        public void RunCombSortTenThousandElements()
        {
            sortingAlgorithms.CombSort(arrayTenThousandElements);

        }

        [Benchmark]
        public void RunSelectionSortHundredElements()
        {
            sortingAlgorithms.SelectionSort(arrayHundredElements);

        }
        [Benchmark]
        public void RunSelectionSortTenThousandElements()
        {
            sortingAlgorithms.SelectionSort(arrayTenThousandElements);

        }


        [Benchmark]
        public void RunTreeSortHundredElements()
        {
            sortingAlgorithms.TreeSort(arrayHundredElements);
        }

        [Benchmark]
        public void RunTreeSortTenThousandElements()
        {
            sortingAlgorithms.TreeSort(arrayTenThousandElements);
        }

        [Benchmark]
        public void RunStoogeSortHundredElements()
        {
            sortingAlgorithms.StoogeSort(arrayHundredElements, 0,arrayHundredElements.Length - 1);

        }
        [Benchmark]
        public void RunStoogeSortTenThousandElements()
        {
            sortingAlgorithms.StoogeSort(arrayTenThousandElements, 0, arrayTenThousandElements.Length - 1);

        }

        [Benchmark]
        public void RunQuickSortHundredElements()
        {
           sortingAlgorithms.QuickSort(arrayHundredElements, 0, arrayHundredElements.Length - 1);

        }


        [Benchmark]
        public void RunQuickSortTenThousandElements()
        {
           sortingAlgorithms.QuickSort(arrayTenThousandElements, 0, arrayTenThousandElements.Length - 1);

        }

        [Benchmark]
        public void RunGnomeSortHundredElements()
        {
            sortingAlgorithms.GnomeSort(arrayHundredElements);

        }
        [Benchmark]
        public void RunGnomeSortTenThousandElements()
        {
            sortingAlgorithms.GnomeSort(arrayTenThousandElements);

        }

        [Benchmark]
        public void RunMergeSortHundredElements()
        {
            sortingAlgorithms.MergeSort(arrayHundredElements, 0, arrayHundredElements.Length - 1);

        }

        [Benchmark]
        public void RunMergeSortTenThousandElements()
        {
          sortingAlgorithms.MergeSort(arrayTenThousandElements, 0, arrayTenThousandElements.Length - 1);

        }


    }
}
