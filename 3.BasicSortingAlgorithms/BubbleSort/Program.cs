namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  Повтарящо се преминаване през списъка, сравняване на съседни елементи и
            //  размяна, ако е в грешен ред
            Console.WriteLine(string.Join(" ", BubbleSort(new int[] { 5,3,2,4,7,1,2})));
        }
        static int[] BubbleSort(int[]arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1]=temp;
                    }
                }
            }
            return arr;
        }
    }
}
