namespace first;

public static class Program
{
    public static void Main()
    {
        string path = "C:/Users/gr622_orahe/Desktop/rkis/5 labs/numsTask2.txt";
        using StreamReader reader = new StreamReader(path);

        string str = reader.ReadToEnd();
        
        reader.Close();
        
        using StreamWriter writer = new StreamWriter(path);

        writer.Write(String.Empty);

        double[] nums = str.Split(';').Select(double.Parse).ToArray();

        double temp;

        for (int i = 0; i < nums.Length; i++)
        {
             for (int j = i; j < nums.Length - 1; j++)
            {
                if(nums[j] > nums[j + 1])
                {
                    temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            writer.Write(nums[i] + ';');
            Console.WriteLine(nums[i]);
        }
        writer.Close();
    }
}