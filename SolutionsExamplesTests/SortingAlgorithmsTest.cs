using SolutionExamples;

namespace SolutionsExamplesTests
{
    [TestClass]
    public class SortingAlgorithmsTest
    {
        SortingAlgorithms sortingAlgorithms = new SortingAlgorithms();

        [TestMethod]
        public void TestBubbleSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            sortingAlgorithms.BubbleSort(num);
        }

        [TestMethod]
        public void TestNullBubbleSort()
        {
            sortingAlgorithms.BubbleSort(null);
        }

        [TestMethod]
        public void TestEmptyBubbleSort()
        {
            int[] num = { };
            sortingAlgorithms.BubbleSort(num);
        }


        [TestMethod]
        public void TestInsertionSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            sortingAlgorithms.InsertionSort(num);
        }
        [TestMethod]
        public void TestNullInsertionSort()
        { 
            sortingAlgorithms.InsertionSort(null);
        }
        [TestMethod]
        public void TestEmptyInsertionSort()
        {
            int[] num = {};
            sortingAlgorithms.InsertionSort(num);
        }

        [TestMethod]
        public void TestShakerSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            sortingAlgorithms.ShakerSort(num);
        }
        [TestMethod]
        public void TestNullShakerSort()
        {
            sortingAlgorithms.ShakerSort(null); ;
        }

        [TestMethod]
        public void TestEmptyShakerSort()
        {
            int[] num = {};
            sortingAlgorithms.ShakerSort(num);
        }


        [TestMethod]
        public void TestStoogeSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            sortingAlgorithms.StoogeSort(num,0,num.Length-1);
        }

        [TestMethod]
        public void TestEmptyStoogeSort()
        {
            int[] num = { };
            sortingAlgorithms.StoogeSort(num, 0, num.Length - 1);
        }

        [TestMethod]
        public void TestNullStoogeSort()
        {
           
            sortingAlgorithms.StoogeSort(null, 0, 0);
        }

        [TestMethod]
        public void TestQuickSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            sortingAlgorithms.QuickSort(num,0,num.Length-1);
        }

        [TestMethod]
        public void TestEmptyQuickSort()
        {
            int[] num = {};
            sortingAlgorithms.QuickSort(num, 0, num.Length - 1);
        }

        [TestMethod]
        public void TestNullQuickSort()
        {
           
            sortingAlgorithms.QuickSort(null, 0, 0);
        }

        [TestMethod]
        public void TestSelectionSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            sortingAlgorithms.SelectionSort(num);
        }
        [TestMethod]
        public void TestNullSelectionSort()
        {
            
            sortingAlgorithms.SelectionSort(null);
        }
        [TestMethod]
        public void TestEmptySelectionSort()
        {
            int[] num = { };
            sortingAlgorithms.SelectionSort(num);
        }


        [TestMethod]
        public void TestShellSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            sortingAlgorithms.ShellSort(num);
        }


        [TestMethod]
        public void TestNullShellSort()
        {
           
            sortingAlgorithms.ShellSort(null);
        }


        [TestMethod]
        public void TestEmptyShellSort()
        {
            int[] num = { };
            sortingAlgorithms.ShellSort(num);
        }


        [TestMethod]
        public void TestCombSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            sortingAlgorithms.CombSort(num);
        }
        [TestMethod]
        public void TestEmptyCombSort()
        {
            int[] num = { };
            sortingAlgorithms.CombSort(num);
        }
        [TestMethod]
        public void TestNullCombSort()
        { 
            sortingAlgorithms.CombSort(null);
        }

        [TestMethod]
        public void TestGnomeSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            sortingAlgorithms.GnomeSort(num);
        }
        [TestMethod]
        public void TestEmptyGnomeSort()
        {
            int[] num = {};
            sortingAlgorithms.GnomeSort(num);
        }
        [TestMethod]
        public void TestNullGnomeSort()
        {
           
            sortingAlgorithms.GnomeSort(null);
        }


        [TestMethod]
        public void TestMergeSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            sortingAlgorithms.MergeSort(num,0,num.Length-1);
        }

        [TestMethod]
        public void TestEmptyMergeSort()
        {
            int[] num = {};
            sortingAlgorithms.MergeSort(num, 0, num.Length - 1);
        }

        [TestMethod]
        public void TestNullMergeSort()
        {
           
            sortingAlgorithms.MergeSort(null, 0, 0);
        }

        [TestMethod]
        public void TestTreeSort()
        {
            int[] num = { 1, 45, 6, 7, 22, 345, 52, 1, 6, -9, 8};
            sortingAlgorithms.TreeSort(num);
        }

        [TestMethod]
        public void TestEmptyTreeSort()
        {
            int[] num = { };
            sortingAlgorithms.TreeSort(num);
        }

        [TestMethod]
        public void TestNullTreeSort()
        {
            sortingAlgorithms.TreeSort(null);
        }

    }
}