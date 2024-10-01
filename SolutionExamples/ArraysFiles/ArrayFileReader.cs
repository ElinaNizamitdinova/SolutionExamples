namespace SolutionExamples.ArraysFiles
{
    public class ArrayFileReader
    {
        public static int[] ReadingArrayHundredElements()
        {
            string filePath = @"E:\elina\SolutionExamples\SolutionExamples\ArraysFiles\ArrayHundredElements.txt";
            int[] arrayOneHundred = new int[100];
            ReadingArray(filePath, arrayOneHundred);
            return arrayOneHundred;
        }
        public static int[] ReadingSortedArrayHundredElements()
        {
            string filePath = @"E:\elina\SolutionExamples\SolutionExamples\ArraysFiles\SortedArrayOneHundredElements.txt";
            int[] arrayOneHundred = new int[100];
            ReadingArray(filePath, arrayOneHundred);
            return arrayOneHundred;
        }
        public static int[] ReadingArrayTenThousandElements()
        {
            string filePath = @"E:\elina\SolutionExamples\SolutionExamples\ArraysFiles\ArrayTenThousandElements.txt";
            int[] arrayTenThousand = new int[10000];
            ReadingArray(filePath, arrayTenThousand);
            return arrayTenThousand;
        }
        public static int[] ReadingSortedArrayTenThousandElements()
        {
            string filePath = @"E:\elina\SolutionExamples\SolutionExamples\ArraysFiles\SortedArrayTenThousandElements.txt";
            int[] arrayTenThousand = new int[10000];
            ReadingArray(filePath, arrayTenThousand);
            return arrayTenThousand;
        }
        public static int[] ReadingArray(string filePath, int[] numbers)
        {
            using (StreamReader reader = File.OpenText(filePath))
            {

                int index = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    string[] parts = line.Split(',');


                    for (int i = 0; i < parts.Length; i++)
                    {
                        int num;
                        if (int.TryParse(parts[i], out num))
                        {
                            numbers[i] = num;
                            Console.WriteLine(num);
                        }
                    }
                }
            }
            return numbers;

        }

    }
}
