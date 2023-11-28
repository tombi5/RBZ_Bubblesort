namespace RBZ_Bubblesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 8, 1, 3, 17, 122, 12, 13, 18, 29, 5, 9, 73, 832, 72, 91, 46, 71 };
            BubbleSort(array);
            Console.WriteLine("Sortiertes array:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}