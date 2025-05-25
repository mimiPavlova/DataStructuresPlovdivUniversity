namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Двоичното търсене (binary search) е алгоритъм за търсене в
             * сортиран масив, при който се използва разделяй 
             * и владей подход. На всяка стъпка се избира средният 
             * елемент и се решава дали да се търси наляво или надясно.*/
            Console.WriteLine(BinarySearch(new int[] {1,2,3,4,5}, 5));
        }
        static int BinarySearch(int[] arr, int key)
        {
            int left = 0;
            int right= arr.Length - 1;
            while (left<=right)
            {
                int mid = left+(right-left)/2;
                if (arr[mid]==key) return mid;
                else if (arr[mid]<key) left=mid+1;
                else right=mid-1;
            }
            return -1;
        }
    }
}
