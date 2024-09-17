using SolutionExamples;

namespace SolutionsExamplesTests
{
    [TestClass]
    public class SortingAlgorithmsTest
    {
        [TestMethod]
        public void TestBubbleSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            SortingAlgorithms.BubbleSort(num);
        }

        [TestMethod]
        public void TestNullBubbleSort()
        {
            SortingAlgorithms.BubbleSort(null);
        }

        [TestMethod]
        public void TestEmptyBubbleSort()
        {
            int[] num = { };
            SortingAlgorithms.BubbleSort(num);
        }


        [TestMethod]
        public void TestInsertionSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            SortingAlgorithms.InsertionSort(num);
        }
        [TestMethod]
        public void TestNullInsertionSort()
        { 
            SortingAlgorithms.InsertionSort(null);
        }
        [TestMethod]
        public void TestEmptyInsertionSort()
        {
            int[] num = {};
            SortingAlgorithms.InsertionSort(num);
        }

        [TestMethod]
        public void TestShakerSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            SortingAlgorithms.ShakerSort(num);
        }
        [TestMethod]
        public void TestNullShakerSort()
        {
            SortingAlgorithms.ShakerSort(null); ;
        }

        [TestMethod]
        public void TestEmptyShakerSort()
        {
            int[] num = {};
            SortingAlgorithms.ShakerSort(num);
        }


        [TestMethod]
        public void TestStoogeSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            SortingAlgorithms.StoogeSort(num,0,num.Length-1);
        }

        [TestMethod]
        public void TestEmptyStoogeSort()
        {
            int[] num = { };
            SortingAlgorithms.StoogeSort(num, 0, num.Length - 1);
        }

        [TestMethod]
        public void TestNullStoogeSort()
        {
           
            SortingAlgorithms.StoogeSort(null, 0, 0);
        }

        [TestMethod]
        public void TestQuickSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            SortingAlgorithms.QuickSort(num,0,num.Length-1);
        }

        [TestMethod]
        public void TestEmptyQuickSort()
        {
            int[] num = {};
            SortingAlgorithms.QuickSort(num, 0, num.Length - 1);
        }

        [TestMethod]
        public void TestNullQuickSort()
        {
           
            SortingAlgorithms.QuickSort(null, 0, 0);
        }

        [TestMethod]
        public void TestSelectionSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            SortingAlgorithms.SelectionSort(num);
        }
        [TestMethod]
        public void TestNullSelectionSort()
        {
            
            SortingAlgorithms.SelectionSort(null);
        }
        [TestMethod]
        public void TestEmptySelectionSort()
        {
            int[] num = { };
            SortingAlgorithms.SelectionSort(num);
        }


        [TestMethod]
        public void TestShellSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            SortingAlgorithms.ShellSort(num);
        }


        [TestMethod]
        public void TestNullShellSort()
        {
           
            SortingAlgorithms.ShellSort(null);
        }


        [TestMethod]
        public void TestEmptyShellSort()
        {
            int[] num = { };
            SortingAlgorithms.ShellSort(num);
        }


        [TestMethod]
        public void TestCombSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            SortingAlgorithms.CombSort(num);
        }
        [TestMethod]
        public void TestEmptyCombSort()
        {
            int[] num = { };
            SortingAlgorithms.CombSort(num);
        }
        [TestMethod]
        public void TestNullCombSort()
        { 
            SortingAlgorithms.CombSort(null);
        }

        [TestMethod]
        public void TestGnomeSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            SortingAlgorithms.GnomeSort(num);
        }
        [TestMethod]
        public void TestEmptyGnomeSort()
        {
            int[] num = {};
            SortingAlgorithms.GnomeSort(num);
        }
        [TestMethod]
        public void TestNullGnomeSort()
        {
           
            SortingAlgorithms.GnomeSort(null);
        }


        [TestMethod]
        public void TestMergeSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            SortingAlgorithms.MergeSort(num,0,num.Length-1);
        }

        [TestMethod]
        public void TestEmptyMergeSort()
        {
            int[] num = {};
            SortingAlgorithms.MergeSort(num, 0, num.Length - 1);
        }

        [TestMethod]
        public void TestNullMergeSort()
        {
           
            SortingAlgorithms.MergeSort(null, 0, 0);
        }


        [TestMethod]
        [Ignore]
        public void TestBogoSort()
        {
            int[] num = { 1, 6, 4, 8, 10, 45, 2, 67, 6, 3, 0, -5 };
            SortingAlgorithms.BogoSort(num);
        }
    }
}