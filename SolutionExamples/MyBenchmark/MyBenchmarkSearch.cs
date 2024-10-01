using BenchmarkDotNet.Attributes;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SolutionExamples.ArraysFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionExamples
{
    [MemoryDiagnoser]
    public class MyBenchmarkSearch
    {
        SearchAlgorithms searchAlgorithms = new SearchAlgorithms();
        int searchedValueOne = 389;
        int searchedValueTwo = 803;
        int[] arrayHundredElements = ArrayFileReader.ReadingSortedArrayHundredElements();
        int[] arrayTenThausandElements = ArrayFileReader.ReadingSortedArrayTenThousandElements();

        

        [Benchmark]
        public void RunLinearSearchHundredElements()
        {
            searchAlgorithms.LinearSearch(arrayHundredElements, searchedValueOne);
        }

        [Benchmark]
        public void RunLinearSearchTenThousandElements()
        {
            searchAlgorithms.LinearSearch(arrayTenThausandElements, searchedValueTwo);
        }

        [Benchmark]
        public void RunBinarySearchHundredElements()
        {
            searchAlgorithms.LinearSearch(arrayHundredElements, searchedValueOne);
        }

        [Benchmark]
        public void RunBinarySearchTenThousandElements()
        {

            searchAlgorithms.LinearSearch(arrayTenThausandElements, searchedValueTwo);
        }
       
    }
}
