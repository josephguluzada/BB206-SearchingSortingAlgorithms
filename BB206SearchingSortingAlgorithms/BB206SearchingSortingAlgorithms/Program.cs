using System.Diagnostics.Metrics;

namespace BB206SearchingSortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Lineary Search
            //int[] numbers = { 1, 2, 3, 42, 54, 65 , 77, 89, 110, 190, 213};

            //int counter = 0;
            //int wantedNumber = 777;
            //bool check = true;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    counter++;
            //    if (numbers[i] == wantedNumber)
            //    {
            //        Console.WriteLine($"Axtardiginiz eded {i}ci indexdedir. Dongu sayi {counter}");
            //        check = false;
            //        break;
            //    }
            //}
            //if( check)
            //{
            //    Console.WriteLine("Axtardiginiz eded siyahida yoxdur");
            //}

            //Binary Search
            //int[] numbers = { 1, 2, 3, 42, 54, 65, 77, 89, 110, 190, 213 };
            //int counter = 0;
            //int wantedNumber = 110;
            //int min = 0;
            //int max = numbers.Length -1;
            //int mid = 0;

            //while (min <= max)
            //{
            //    counter++;
            //    mid = (min + max) / 2;
            //    if (numbers[mid] == wantedNumber)
            //    {
            //        Console.WriteLine($"Axtardiginiz eded {mid}ci indexdedir. Dongu sayi: {counter}");
            //        break;
            //    }
            //    else if (wantedNumber > numbers[mid])
            //    {
            //        min = mid + 1;
            //    }
            //    else
            //    {
            //        max = mid - 1;
            //    }
            //}



            // Bubble Sort

            int[] arr = { 4, 6, 7, 3, 2, 1, 5 };
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}