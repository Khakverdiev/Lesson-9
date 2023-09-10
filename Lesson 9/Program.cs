//Array arr = new Array();

//arr.Show();
//arr.Show("HI");

//Console.WriteLine($"Max Element - {arr.Max()}");
//Console.WriteLine($"Min Element - {arr.Min()}");
//Console.WriteLine($"Avg - {arr.Avg()}");
//Console.WriteLine($"Search - {arr.Search(12)}");

//arr.SortAsc();
//arr.SortDesc();
//arr.SortByParam(true);

//interface IOutput
//{
//    void Show();
//    void Show(string info);
//}

//interface IMath
//{
//    int Max();
//    int Min();
//    float Avg();
//    bool Search(int valueToSearch);
//}

//interface ISort
//{
//    void SortAsc();
//    void SortDesc();
//    void SortByParam(bool isAsc);
//}

//class Array : IOutput, IMath, ISort
//{
//    private int[] arr = new int[5] { 12, 24, 3, 4, 5 };

//    public float Avg()
//    {
//        float sum = 0.0f;

//        for (int i = 0; i < arr.Length; ++i)
//        {
//            sum += arr[i];
//        }

//        return sum / arr.Length;
//    }

//    public int Max()
//    {
//        int max = arr[0];

//        for (int i = 0; i < arr.Length; ++i)
//        {
//            if (arr[i] > max)
//            {
//                max = arr[i];
//            }
//        }

//        return max;
//    }

//    public int Min()
//    {
//        int min = arr[0];

//        for (int i = 0; i < arr.Length; ++i)
//        {
//            if (arr[i] < min)
//            {
//                min = arr[i];
//            }
//        }

//        return min;
//    }

//    public bool Search(int valueToSearch)
//    {
//        for (int i = 0; i < arr.Length; ++i)
//        {
//            if (arr[i] == valueToSearch)
//            {
//                return true;
//            }
//        }
//        return false;
//    }

//    public void Show()
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.Write(arr[i]);
//        }
//        Console.WriteLine();
//    }

//    public void Show(string info)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.Write($"{arr[i]} ");
//        }
//        Console.Write(info);
//        Console.WriteLine();
//    }

//    private void info(int[] arr)
//    {
//        for (int i = 0; i < arr.Length; ++i)
//        {
//            Console.Write($"{arr[i]} ");
//        }
//        Console.WriteLine();
//    }

//    private void MySort(int[] arr)
//    {
//        for (int i = 0; i < arr.Length - 1; i++)
//        {
//            for (int j = 0; j < arr.Length - i - 1; j++)
//            {
//                if (arr[j] > arr[j + 1])
//                {
//                    int tmp = arr[j];
//                    arr[j] = arr[j + 1];
//                    arr[j + 1] = tmp;
//                }
//            }
//        }

//    }

//    private void MyReverse(int[] arr)
//    {
//        int i = 0;
//        int j = arr.Length - 1;

//        for (; i < j;)
//        {
//            int tmp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = tmp;

//            i++;
//            j--;
//        }
//    }

//    public void SortAsc()
//    {
//        MySort(arr);
//        info(arr);
//    }

//    public void SortDesc()
//    {
//        MySort(arr);
//        MyReverse(arr);
//        info(arr);
//    }

//    public void SortByParam(bool isAsc)
//    {
//        if (isAsc == true)
//        {
//            SortAsc();
//        }
//        else
//        {
//            SortDesc();
//        }
//    }
//}