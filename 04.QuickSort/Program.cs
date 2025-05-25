namespace _4.QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr =  { 3, 5, 8, 4, 3, 2, 5, 6 }; 
            QuickSort(arr, 0, arr.Length-1);
            Console.WriteLine(string.Join(" ",arr));
        }
        static void QuickSort(int[]arr, int low, int high)
        {
            if (low<high)
            {
                int pivotIndex = Partition(arr, low, high);
                QuickSort(arr, low, pivotIndex-1);
                QuickSort(arr, pivotIndex+1, high);
            }
        }
        static int Partition(int[]arr, int low, int high)
        {
          int pivot = arr[high];
            int j=low-1;
            for (int i = low; i < high; i++)
            {
                if (arr[i] < pivot)
                {
                    j++;
                    Swap(arr, i, j);
                }

             
            }   Swap(arr, j+1, high);
            
            return j+1;
        }
        static void Swap(int [] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j]=temp;
        }

    }
}
