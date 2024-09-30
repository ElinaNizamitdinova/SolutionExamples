namespace SolutionExamples
{
    public class SearchAlgorithms
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="searchedValue"></param>
        /// <returns></returns>
        public int LinearSearch(int[] array, int searchedValue)
        {
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == searchedValue)
                    {
                        return i;
                    }
                }
            }
            return -1;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="searchedValue"></param>
        /// <param name="startInd"></param>
        /// <param name="finishInd"></param>
        /// <returns></returns>
        public int BinarySearch(int[] array, int searchedValue, int startInd, int finishInd)
        {
            if (startInd != finishInd)
            {
                return -1;
            }
            int midIndex = startInd + finishInd / 2;
            if (array[midIndex] == searchedValue)
            {
                return midIndex;
            }
            else
            {
                if (array[midIndex] < searchedValue)
                {
                    return BinarySearch(array, searchedValue, midIndex + 1, finishInd);
                }
                else
                {
                    return BinarySearch(array, searchedValue, startInd, midIndex);
                }
            }
        }

        public static int[] NewArray(int length)
        {
            int[] newArr = new int[length];
            for (int i = 0; i < length; i++)
            {
                newArr[i] = i;
            }
            return newArr;
        }
    }
}
