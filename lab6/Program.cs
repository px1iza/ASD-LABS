using System;
using System.Diagnostics;

class Program
{
    static Random rand = new Random();

    static void Main()
    {
        int N = 100;

        int[] sizes = { N, N * N, N * N * N };

        Console.WriteLine("=== РІВЕНЬ 2: ЗАЛЕЖНІСТЬ ВІД РОЗМІРУ ===\n");

        foreach (int size in sizes)
        {
            Console.WriteLine($"\n--- Розмір: {size} ---");

            double quick = AvgTime(size, QuickSortWrapper);
            double merge = AvgTime(size, MergeSortWrapper);

            Console.WriteLine($"Швидке сортування (QuickSort): {quick:F4} мс");
            Console.WriteLine($"Сортування злиттям (MergeSort): {merge:F4} мс");
        }

        Console.WriteLine("\n\n=== РІВЕНЬ 3: ЗАЛЕЖНІСТЬ ВІД СТРУКТУРИ ДАНИХ ===\n");

        int size3 = 10000;

        int[] best = GenerateSorted(size3);
        int[] worst = GenerateReversed(size3);
        int[] average = GenerateRandom(size3);

        TestCase("НАЙКРАЩИЙ ВИПАДОК (відсортований масив)", best);
        TestCase("НАЙГІРШИЙ ВИПАДОК (зворотній порядок)", worst);
        TestCase("СЕРЕДНІЙ ВИПАДОК (випадковий масив)", average);
    }

    static void TestCase(string name, int[] baseArr)
    {
        Console.WriteLine($"\n--- {name} ---");

        Console.WriteLine($"QuickSort: {Measure(baseArr, QuickSortWrapper):F4} мс");
        Console.WriteLine($"MergeSort: {Measure(baseArr, MergeSortWrapper):F4} мс");
    }

    static double Measure(int[] baseArr, Action<int[]> sortMethod)
    {
        int[] arr = (int[])baseArr.Clone();

        Stopwatch sw = Stopwatch.StartNew();
        sortMethod(arr);
        sw.Stop();

        return sw.Elapsed.TotalMilliseconds;
    }

    static double AvgTime(int size, Action<int[]> sortMethod)
    {
        int tests = 5;
        double sum = 0;

        for (int i = 0; i < tests; i++)
        {
            int[] arr = GenerateRandom(size);

            Stopwatch sw = Stopwatch.StartNew();
            sortMethod(arr);
            sw.Stop();

            sum += sw.Elapsed.TotalMilliseconds;
        }

        return sum / tests;
    }

    static int[] GenerateRandom(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = rand.Next(0, 100000);
        return arr;
    }

    static int[] GenerateSorted(int size)
    {
        int[] arr = GenerateRandom(size);
        Array.Sort(arr);
        return arr;
    }

    static int[] GenerateReversed(int size)
    {
        int[] arr = GenerateSorted(size);
        Array.Reverse(arr);
        return arr;
    }

    static void QuickSortWrapper(int[] arr)
    {
        QuickSort(arr, 0, arr.Length - 1);
    }

    static void QuickSort(int[] arr, int left, int right)
    {
        if (left >= right) return;

        int pivot = arr[(left + right) / 2];
        int index = Partition(arr, left, right, pivot);

        QuickSort(arr, left, index - 1);
        QuickSort(arr, index, right);
    }

    static int Partition(int[] arr, int left, int right, int pivot)
    {
        while (left <= right)
        {
            while (arr[left] < pivot) left++;
            while (arr[right] > pivot) right--;

            if (left <= right)
            {
                (arr[left], arr[right]) = (arr[right], arr[left]);
                left++;
                right--;
            }
        }
        return left;
    }

    static void MergeSortWrapper(int[] arr)
    {
        MergeSort(arr, 0, arr.Length - 1);
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right) return;

        int mid = (left + right) / 2;

        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];

        int i = left, j = mid + 1, k = 0;

        while (i <= mid && j <= right)
        {
            if (arr[i] <= arr[j])
                temp[k++] = arr[i++];
            else
                temp[k++] = arr[j++];
        }

        while (i <= mid) temp[k++] = arr[i++];
        while (j <= right) temp[k++] = arr[j++];

        for (i = 0; i < temp.Length; i++)
            arr[left + i] = temp[i];
    }
}