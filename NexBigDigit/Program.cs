using System;

namespace NexBigDigit
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static long NextBiggerNumber(long n)
        {
            if (n / 10 < 1) return -1;
            int count_digit = 0; ;
            int[] n_as_array = long_as_array_digit(n, out count_digit);
            int r = cant_be_rearranged(n_as_array);
            if (r == -1) return -1;

            for(int i = count_digit - 1; i > 0; i--)
            {
                if(n_as_array[i - 1] < n_as_array[i])
                {
                    swap(ref n_as_array, i - 1, i);
                    break;
                }
            }

            long result = 0;
            for (int i = 0; i < n_as_array.Length; i++)
            {
                result += n_as_array[i] * (int)Math.Pow(10, count_digit - 1);
                count_digit -= 1;
            }
            return result;
        }
        static void swap(ref int [] arr, int a, int b)
        {
            int buff = arr[a];
            arr[a] = arr[b];
            arr[b] = buff;
        }
        static int cant_be_rearranged(int[] arr)
        {
            int arr_length = arr.Length;
            int position = -1;
            if (arr_length == 0 || arr_length == 1) return -1;
            int counter = 1;
            int bufer = arr[1];
            while (counter < arr_length)
            {
                if (arr[counter] >= bufer) { bufer = arr[counter]; position = counter; counter++; continue; }
                counter++;
            }
            return position == -1 ? -1 : position;
        }
        static int[] long_as_array_digit(long number, out int count_dig)
        {
            int arr_length = count_digit(number);
            count_dig = arr_length;
            int[] arr_res = new int[arr_length];
            int index = 0;
            int buff = 0;
            double buf = (double)number;
            while (arr_length > 0)
            {
                double ten_pow = Math.Pow(10, arr_length - 1);
                buff = (int)(buf / ten_pow);
                arr_length--;
                arr_res[index] = buff;
                buf %= ten_pow;
                index++;
            }
            return arr_res;
        }
        static int count_digit(long number)
        {
            int res = 1;
            int counter = 0;
            int long_int = (int)number;
            while (res > 0)
            {
                res = long_int /= 10;
                counter++;
            }
            return counter;
        }
    }
}
