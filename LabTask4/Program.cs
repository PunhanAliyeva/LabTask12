using System.Threading.Channels;

namespace LabTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci(100);

            int a = 100;
            int totalDigitSum = 0;
            int[]fibNums=new int[a];
            for (int i = 0; i <= a; i++)
            {
                fibNums[i] = Fibonacci(i);
                totalDigitSum+= DigitSum(fibNums[i]);
                Console.WriteLine($"Reqemlerinin cemi:{totalDigitSum}");
            }
            int lastFibNum = fibNums[a];
            int lastDigitSum=DigitSum(lastFibNum);
            bool IsPrimeLast=IsPrime(lastDigitSum);
            Console.WriteLine($"Sonuncu eded sadedirmi?:{IsPrimeLast}");
        }


        static int Fibonacci(int num)
        {
            int[]nums=new int[num];
            if (num <=1) return num;
            nums[0] = 0;
            nums[1] = 1;
            for (int i = 2; i < nums.Length; i++)
            {
                nums[i] = nums[i - 2] + nums[i - 1];
            }
            int c = 0;
            int m = 0;
            foreach (var n in nums)
            {
                m = n;
                if (n > num)
                {
                    break;
                }
                c = n;
                Console.WriteLine(n);
            }
            return m;
        }



        static int DigitSum(int number)       
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static bool IsPrime(int num)
        {
            int count = 0;
            if (num == 1) return false;
            for (int i = 1; i < num; i++)
            {
                if(num%i== 0)
                {
                    count++;
                }
                if (count > 2)
                {
                    return false;
                }
            }
            return true;
        }






        //static void Fibonacci(int num)
        //{
        //    int[] nums = new int[num];
        //    nums[0] = 0;
        //    nums[1] = 1;
        //    for (int i = 2; i < nums.Length; i++)
        //    {
        //        nums[i] = nums[i - 2] + nums[i - 1];
        //    }
        //    int c = 0;
        //    foreach (var a in nums)
        //    {
        //        if (a >= num)
        //        {
        //            break;
        //        }
        //        c = a;
        //        Console.WriteLine(a);
        //    }
        //    Console.WriteLine($"Sonuncu eded:{c}");
        //    int count = 0;
        //    bool IsPrime = true;
        //    for (int i = 1; i <= c; i++)
        //    {
        //        if(c%i== 0)
        //        {
        //            count++;
        //        }
        //        if (count > 2)
        //        {
        //            IsPrime = false;
        //            break;
        //        }
        //        else
        //        {
        //            IsPrime=true;
        //        }
        //    }
        //    Console.WriteLine(IsPrime);
        //}

    }
}