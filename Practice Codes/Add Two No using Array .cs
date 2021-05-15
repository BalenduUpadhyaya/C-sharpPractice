using System;
namespace Hello
{
    class Array
    {
         static void Main (string[] Args )
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] c = new int[5];

            for(int i = 0; i < 5; i++)
            {
             a[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < 5; i++)
            {
            b[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < 5; i++)
            {
                c[i] = a[i] + b[i];
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(c[i]+" ");
            }
            
        }
    }
}