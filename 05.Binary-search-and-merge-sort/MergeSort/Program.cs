namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, 4, 1, 6, 8, 9, 0, 7 };
            MergeSort(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
        static void MergeSort(int[] arr)
        {
            if (arr.Length<=1) return;
            int mid = arr.Length/2;
            int[] left = arr.Take(mid).ToArray();
            int[] right=arr.Skip(mid).ToArray();

            MergeSort(left);
            MergeSort(right);

            Merge(arr, left, right);

        }
        static void Merge(int[]result, int[]left, int[]right)
        {
            int i=0, j=0, k = 0;

            // Сливане на ляв и десен масив
            while (i<left.Length||j<right.Length)
            {
                if (left[i]<=right[j])
                {
                    result[k++] = left[i++];
                }
                else
                {
                    result[k++]=right[j++];
                }
            }

            //Добавяне на останалите елементи
            while (i<left.Length)
            {
                result[k++]=left[i++];

            }
            while (j<right.Length)
            {
                result[k++]=right[j++];
            }

        }
    }
}
