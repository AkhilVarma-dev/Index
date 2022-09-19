using System;

public class Index
{
    public static void Main()
    {
        int[] arr = new int[5] { 10, 20, 30, 50, 40 };

        Array.Sort(arr);
        foreach (int i in arr)
        {
            Console.Write(i + ",");
        }
        
        Console.WriteLine();
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        for ( int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < num)
            {
                i++;
                if (arr[i] > num)
                {
                    Console.WriteLine("index value of given number is :{0}", i);
                }                
                
            }
            
        }

    }

}