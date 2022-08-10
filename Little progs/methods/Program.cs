public class CustomFuctions
{
    private static void Main(string[] args) 
    {

    void FillArray(int[] col)
    {
        int length = col.Length;
        int index = 0;
        while (index < length)
        {
            col[index] = new Random().Next(1, 10);
            index++;
        }
    }

    void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
        {
            Console.WriteLine(col[position]);
            count++;
        }
    }

    Console.WriteLine("методы FillArray PrintArray");
    }
}
