namespace LabTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci(100);
        }
        static void Fibonacci(int num)
        {
            int[] nums = new int[num];
            nums[0] = 0;
            nums[1] = 1;
            for (int i = 2; i < nums.Length; i++)
            {
                nums[i] = nums[i - 2] + nums[i - 1];
            }
            int c = 0;
            foreach (var a in nums)
            {
                if (a >= num)
                {
                    break;
                }
                c = a;
                Console.WriteLine(a);
            }
            Console.WriteLine($"Sonuncu eded:{c}");
            int count = 0;
            bool IsPrime = true;
            for (int i = 1; i <= c; i++)
            {
                if(c%i== 0)
                {
                    count++;
                }
                if (count > 2)
                {
                    IsPrime = false;
                    break;
                }
                else
                {
                    IsPrime=true;
                }
            }
            Console.WriteLine(IsPrime);

        }
    }
}