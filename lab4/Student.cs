namespace Lab4
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public StudyForm Form { get; set; }

        public static void SelectionSort(Student[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (string.Compare(arr[j].Surname, arr[minIndex].Surname) < 0)
                    {
                        minIndex = j;
                    }
                }
                Student temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
        public static void Print(Student[] arr)
        {
            foreach (var item in arr)
            {
                System.Console.WriteLine($"{item.Surname} {item.Name} - {item.Form}");
            }
        }
        public static void QuickSort(Student[] arr, int left, int right)
        {
            if (left >= right) return;

            int mid = (left + right) / 2;
            string pivot = arr[mid].Surname;

            int i = left;
            int j = right;

            while (i <= j)
            {
                while (string.Compare(arr[i].Surname, pivot) < 0) i++;
                while (string.Compare(arr[j].Surname, pivot) > 0) j--;

                if (i <= j)
                {
                    Student temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j) QuickSort(arr, left, j);
            if (i < right) QuickSort(arr, i, right);
        }
    }
}