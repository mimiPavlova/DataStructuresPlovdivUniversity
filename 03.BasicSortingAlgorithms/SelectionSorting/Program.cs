namespace SelectionSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Намери най-малкия елемент и го сложи на първо място.

           После намери следващия най-малък и го сложи на второ място.

           И така до края.*/
            Console.WriteLine(string.Join(" ", SelectionSort(new int[] { 4, 2, 4, 1, 3, })));

        }
        static int[] SelectionSort(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex=i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex]) minIndex=j;
                }
                int temp=arr[i];
                arr[i]=arr[minIndex];
                arr[minIndex]=temp;
            }
            return arr;
        }
    }
}
