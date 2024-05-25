 internal class Program
 {
        static void Main(string[] args)
        {
            int[] array = { 7, 10, 4, 3, 9, 8, 6, 5, 2, 1 };
            int[] array2 = { 7, 10, 4, 3, 9, 8, 6, 5, 2, 1 };
            BubbleSort(array);
            SelectionSort(array2);
        }
        static void BubbleSort(int[] array)
        {
            int a = 0;
            int b = 0;
            int length = array.Length;
            for (int i = 1; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    b++;
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        a++;
                    }
                }
            }
            Console.WriteLine($"Бульбашкове сортування робить {b} порiвнянь та {a} обмiнiв");
        }
        static void SelectionSort(int[] array)
        { //Сортування простим вибором
            int a = 0;
            int b = 0;
            int length = array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int nmin = i;
                for (int j = i + 1; j < length; j++)
                {
                    b++;
                    if (array[j] < array[nmin])
                    {
                        nmin = j;
                        a++;
                    }
                }
                int temp = array[i];
                array[i] = array[nmin];
                array[nmin] = temp;
            }
            Console.WriteLine($"Сортування простим вибором робить {b} порiвнянь та {a} обмiнiв");
        }
 } 