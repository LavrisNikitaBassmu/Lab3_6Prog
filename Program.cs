using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 2, 9, 1, 5, 6 };

        int sumIterativeResult = sumIterative(array);
        int sumRecursiveResult = sumRecursive(array, array.Length);
        int minIterativeResult = minIterative(array);
        int minRecursiveResult = minRecursive(array, array.Length);

        Console.WriteLine("Сумма (итеративно): " + sumIterativeResult);
        Console.WriteLine("Сумма (рекурсивно): " + sumRecursiveResult);
        Console.WriteLine("Минимум (итеративно): " + minIterativeResult);
        Console.WriteLine("Минимум (рекурсивно): " + minRecursiveResult);
    }

    static int sumIterative(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static int sumRecursive(int[] array, int n)
    {
        if (n <= 0)
            return 0;
        return sumRecursive(array, n - 1) + array[n - 1];
    }

    static int minIterative(int[] array)
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static int minRecursive(int[] array, int n)
    {
        if (n == 1)
            return array[0];
        return Math.Min(array[n - 1], minRecursive(array, n - 1));
    }
}