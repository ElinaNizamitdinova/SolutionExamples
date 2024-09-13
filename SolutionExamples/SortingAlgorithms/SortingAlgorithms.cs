namespace SolutionExamples
{

    public static class SortingAlgorithms
    {

        /// <summary>
        /// The method implements the bubble sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int[] BubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }

                }

            }
            return numbers;

        }

        /// <summary>
        /// The method implements the shaker sort(cocktail sort)) algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int[] ShakerSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                for (int j = i; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }

                }
                for (int j = numbers.Length - 2 - i; j > i; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        var temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }

                }


            }
            return numbers;


        }

        /// <summary>
        /// The method implements the insertion sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int[] InsertionSort(int[] numbers)
        {
            int x;
            int j;
            for (int i = 1; i < numbers.Length; i++)
            {
                x = numbers[i];
                j = i;
                while (j > 0 && numbers[j - 1] > x)
                {
                    var temp = numbers[j];
                    numbers[j] = numbers[j - 1];
                    numbers[j - 1] = temp;
                    j -= 1;
                }
                numbers[j] = x;
            }
            return numbers;


        }


        /// <summary>
        /// The method implements the Shell sort algorithm (Shell sort is a better version of insertion sort).
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        static int[] ShellSort(int[] numbers)
        {
            //расстояние между элементами, которые сравниваются
            var d = numbers.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < numbers.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (numbers[j - d] > numbers[j]))
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j - d];
                        numbers[j - d] = temp;
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            return numbers;
        }


        /// <summary>
        /// The method implements the stooge sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        static int[] StoogeSort(int[] numbers, int startIndex, int endIndex)
        {
            if (numbers[startIndex] > numbers[endIndex])
            {
                var temp = numbers[startIndex];
                numbers[startIndex] = numbers[endIndex];
                numbers[endIndex] = temp;
            }

            if (endIndex - startIndex > 1)
            {
                var len = (endIndex - startIndex + 1) / 3;
                StoogeSort(numbers, startIndex, endIndex - len);
                StoogeSort(numbers, startIndex + len, endIndex);
                StoogeSort(numbers, startIndex, endIndex - len);
            }

            return numbers;
        }



        /// <summary>
        /// The method implements the merge sort algorithm.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="lowIndex"></param>
        /// <param name="highIndex"></param>
        /// <returns></returns>
        public static int[] MergeSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        static void Merge(int[] numbers, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (numbers[left] < numbers[right])
                {
                    tempArray[index] = numbers[left];
                    left++;
                }
                else
                {
                    tempArray[index] = numbers[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = numbers[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = numbers[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                numbers[lowIndex + i] = tempArray[i];
            }
        }

        /// <summary>
        /// The method implements the selection sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="currentIndex"></param>
        /// <returns></returns>
        static int[] SelectionSort(int[] numbers, int currentIndex = 0)
        {
            if (currentIndex == numbers.Length)
                return numbers;

            var index = IndexOfMin(numbers, currentIndex);
            if (index != currentIndex)
            {
                var temp = numbers[index];
                numbers[index] = numbers[currentIndex];
                numbers[currentIndex] = temp;
            }

            return SelectionSort(numbers, currentIndex + 1);
        }
        static int IndexOfMin(int[] numbers, int n)
        {
            int indexOfmin = n;
            for (int i = n; i < numbers.Length; i++)
            {
                if (numbers[1] < numbers[indexOfmin])
                {
                    indexOfmin = i;
                }
            }

            return indexOfmin;
        }

        /// <summary>
        /// The method implements the quick sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="minIndex"></param>
        /// <param name="maxIndex"></param>
        /// <returns></returns>
        public static int[] QuickSort(int[] numbers, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return numbers;
            }

            var pivotIndex = Partition(numbers, minIndex, maxIndex);
            QuickSort(numbers, minIndex, pivotIndex - 1);
            QuickSort(numbers, pivotIndex + 1, maxIndex);

            return numbers;
        }

        static int Partition(int[] numbers, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (numbers[i] < numbers[maxIndex])
                {
                    pivot++;
                    var tmp = numbers[pivot];
                    numbers[pivot] = numbers[i];
                    numbers[i] = tmp;
                }
            }

            pivot++;
            var temp = numbers[pivot];
            numbers[pivot] = numbers[maxIndex];
            numbers[maxIndex] = temp;
            return pivot;
        }


        /// <summary>
        /// The method implements the gnome sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int[] GnomeSort(int[] numbers)
        {
            var index = 1;
            var nextIndex = index + 1;

            while (index < numbers.Length)
            {
                if (numbers[index - 1] < numbers[index])
                {
                    index = nextIndex;
                    nextIndex++;
                }
                else
                {
                    var temp = numbers[index - 1];
                    numbers[index - 1] = numbers[index];
                    numbers[index] = temp;
                    index--;
                    if (index == 0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }
            }
            return numbers;
        }



        /// <summary>
        /// The method implements the random sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int[] Bogosort(int[] numbers)
        {
            while (!IsSorted(numbers))
            {
                Shuffle(numbers);
            }

            return numbers;
        }


        private static bool IsSorted(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                    return false;
            }

            return true;
        }

        private static void Shuffle(int[] numbers)
        {
            Random random = new Random();
            var n = numbers.Length;
            while (n > 1)
            {
                n--;
                var i = random.Next(n + 1);
                var temp = numbers[i];
                numbers[i] = numbers[n];
                numbers[n] = temp;
            }
        }


    }
}
