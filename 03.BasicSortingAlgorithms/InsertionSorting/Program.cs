namespace InsertionSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Стъпки:
          Започваш от втория елемент (index 1).

          Сравняваш го с предишните елементи.

          Докато предишният елемент е по-голям, го избутваш надясно.

          Когато намериш правилното място — вмъкваш текущия елемент там.*/


            Console.WriteLine(string.Join(" ", InsertionSorting(new int[] {5,3,7,1,8,9,2,})));
        }

        static int[] InsertionSorting(int[] arr)
        {

            for (int i = 1; i < arr.Length; i++)
            {
                int temp=arr[i];
                int j = i-1;
                while (j>=0&&arr[j]>temp)
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j+1]=temp;
            }
            return arr;
        }
    }
}
