int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
    }

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 100);
    }
}

void PrintArray(int[] arr)
{
    // for (int i = 0; i < arr.Length; i++)
    // {
    // System.Console.Write(arr[i] + " ");
    // }    
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
}
int N = ReadInt("Введите число: ");
int[] array = new int[N];
FillArray(array);
PrintArray(array);