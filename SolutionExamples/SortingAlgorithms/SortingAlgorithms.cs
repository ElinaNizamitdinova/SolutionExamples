namespace SolutionExamples
{

    public class SortingAlgorithms
    {

        static void Swap(ref int firstElement, ref int secondEelement)
        {
            var temp = firstElement;
            firstElement = secondEelement;
            secondEelement = temp;
        }

        /// <summary>
        /// The method implements the bubble sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int[] BubbleSort(int[] numbers)
        {
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < numbers.Length - 1; j++)
                    {
                        if (numbers[j] > numbers[j + 1])
                        {
                            Swap(ref numbers[j], ref numbers[j + 1]);
                        }
                    }
                }
            }
            return numbers;
        }

        /// <summary>
        /// The method implements the shaker sort(cocktail sort) algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>

        public int[] ShakerSort(int[] numbers)
        {
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length / 2; i++)
                {
                    for (int j = i; j < numbers.Length - 1 - i; j++)
                    {
                        if (numbers[j] > numbers[j + 1])
                        {
                            Swap(ref numbers[j], ref numbers[j + 1]);
                        }

                    }
                    for (int j = numbers.Length - 2 - i; j > i; j--)
                    {
                        if (numbers[j - 1] > numbers[j])
                        {
                            Swap(ref numbers[j - 1], ref numbers[j]);
                        }

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

        public int[] InsertionSort(int[] numbers)
        {
            if (numbers != null)
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    int x = numbers[i];
                    int j = i;
                    while (j > 0 && numbers[j - 1] > x)
                    {
                        Swap(ref numbers[j], ref numbers[j - 1]);
                        j--;
                    }
                    numbers[j] = x;
                }
            }
            return numbers;
        }


        /// <summary>
        /// The method implements the Shell sort algorithm (Shell sort is a better version of insertion sort).
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>

        public int[] ShellSort(int[] numbers)
        {
            if (numbers != null)
            {
                var d = numbers.Length / 2;
                while (d >= 1)
                {
                    for (var i = d; i < numbers.Length; i++)
                    {
                        var j = i;
                        while ((j >= d) && (numbers[j - d] > numbers[j]))
                        {
                            Swap(ref numbers[j], ref numbers[j - d]);
                            j -= d;
                        }
                    }

                    d /= 2;
                }
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

        public int[] MergeSort(int[] array, int lowIndex, int highIndex)
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


        public int[] SelectionSort(int[] numbers)
        {
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length - 1; ++i)
                {
                    int min = i;
                    for (int j = i + 1; j < numbers.Length; ++j)
                    {
                        if (numbers[j].CompareTo(numbers[min]) < 0)
                        {
                            min = j;
                        }
                    }

                    Swap(ref numbers[i], ref numbers[min]);
                }
            }

            return numbers;
        }


        /// <summary>
        /// The method implements the quick sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="minIndex"></param>
        /// <param name="maxIndex"></param>
        /// <returns></returns>

        public int[] QuickSort(int[] numbers, int minIndex, int maxIndex)
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
                    Swap(ref numbers[pivot], ref numbers[i]);
                }
            }

            pivot++;
            Swap(ref numbers[pivot], ref numbers[maxIndex]);
            return pivot;
        }


        /// <summary>
        /// The method implements the gnome sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>

        public int[] GnomeSort(int[] numbers)

        {
            if (numbers != null)
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
                        Swap(ref numbers[index - 1], ref numbers[index]);
                        index--;
                        if (index == 0)
                        {
                            index = nextIndex++;
                        }
                    }
                }
            }
            return numbers;
        }

        /// <summary>
        /// The method implements the comb sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>

        public int[] CombSort(int[] numbers)
        {
            if (numbers != null)
            {

                var arrayLength = numbers.Length;
                var currentStep = arrayLength - 1;

                while (currentStep > 1)
                {
                    for (int i = 0; i + currentStep < numbers.Length; i++)
                    {
                        if (numbers[i] > numbers[i + currentStep])
                        {
                            Swap(ref numbers[i], ref numbers[i + currentStep]);
                        }
                    }

                    currentStep = GetNextStep(currentStep);
                }


                for (var i = 1; i < numbers.Length; i++)
                {
                    var swapFlag = false;
                    for (var j = 0; j < numbers.Length - i; j++)
                    {
                        if (numbers[j] > numbers[j + 1])
                        {
                            Swap(ref numbers[j], ref numbers[j + 1]);
                            swapFlag = true;
                        }
                    }

                    if (!swapFlag)
                    {
                        break;
                    }
                }
            }

            return numbers;


        }
        static int GetNextStep(int s)
        {
            s = s * 1000 / 1247; // Оптимальное значение фактора уменьшения равно 1/(1-e-φ) ≈ 1.247, где е – основание натурального логарифма, а φ – золотое сечение.
            return s > 1 ? s : 1;
        }

        /// <summary>
        /// The method implements the binary tree sorting algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int[] TreeSort(int[] numbers)
        {
            if (numbers != null && numbers.Length > 0)
            {
                var treeNode = new TreeNode(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    treeNode.Insert(new TreeNode(numbers[i]));
                }

                return treeNode.Transform();
            }
            return null;
        }


        // Непрактичные виды сортировок

        /// <summary>
        /// The method implements the stooge sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>

        public int[] StoogeSort(int[] numbers, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                if (numbers[startIndex] > numbers[endIndex])
                {
                    Swap(ref numbers[startIndex], ref numbers[endIndex]);
                }

                if (endIndex - startIndex > 1)
                {
                    var len = (endIndex - startIndex + 1) / 3;
                    StoogeSort(numbers, startIndex, endIndex - len);
                    StoogeSort(numbers, startIndex + len, endIndex);
                    StoogeSort(numbers, startIndex, endIndex - len);
                }
            }
            return numbers;
        }
        public static int[] RandomArray(int len)
        {
            Random random = new Random();
            int[] arr = new int[len];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = random.Next(-100, 100);
            return arr;

        }

    }
}
