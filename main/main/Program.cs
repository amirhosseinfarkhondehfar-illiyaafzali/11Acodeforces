using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = new int[2];
            string get;
            get = Console.ReadLine();
            int numbercount = 0;
            for (int i = 0; i < get.Length; i++)
            {
                if (i == 0)
                {
                    nm[0] = 0;
                }
                if (get[i] == ' ')
                {
                    numbercount++;
                    nm[numbercount] = 0;
                }
                else
                {
                    nm[numbercount] = nm[numbercount] * 10 + Convert.ToInt32(get[i] - '0');
                }
            }
            int ans = 0;
            string secondget = Console.ReadLine();
            int secondnumbercount = 0;
            int[] arr = new int[2001];
            for (int i = 0; i < secondget.Length; i++)
            {
                if (i == 0)
                {
                    arr[0] = 0;
                }
                if (secondget[i] == ' ')
                {
                    secondnumbercount++;
                    arr[secondnumbercount] = 0;
                }
                else
                {
                    arr[secondnumbercount] = arr[secondnumbercount] * 10 + Convert.ToInt32(secondget[i] - '0');
                }
            }
            for (int i = 0; i < nm[0]; i++)
            {
                if (i > 0)
                {
                    if (arr[i - 1] >= arr[i])
                    {
                        ans = ans + (arr[i - 1] - arr[i]) / nm[1] + 1;
                        arr[i] = arr[i] + ((arr[i - 1] - arr[i]) / nm[1] + 1) * nm[1];
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
