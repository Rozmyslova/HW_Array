class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of array = ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        FillArray(array);
        PrintArray(array);

        Console.WriteLine();
        Console.Write("Enter a number to find a sum = ");
        int num = int.Parse(Console.ReadLine());

        List<int> result = FindThreeNum(array, num);

        if (result.Count == 0)
        {
            Console.WriteLine("3 numbers aren`t finded ");
        }
    
        void FillArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-10, 10);
            }
        }

        void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
    public static List<int> FindThreeNum(int[] array, int num)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < array.Length - 2; i++)
        {
            int left = i + 1;
            int right = array.Length - 1;

            while (left < right)
            {
                int sum = array[i] + array[left] + array[right];
                if (sum == num)
                {
                    result.Add(array[i]);
                    result.Add(array[left]);
                    result.Add(array[right]);
                    Console.WriteLine("3 numbers are finded");
                    break;
                }
                else if (sum < num)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            if (result.Count > 0)
            {
                break;
            }
        }
        return result;
    }
}
