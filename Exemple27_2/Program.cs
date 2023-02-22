// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Пробовал через массив

string Number(string text){
    System.Console.Write(text);
    return Console.ReadLine();
}
string? arr = Number("Введите число: ");


    int [] b = new int[arr!.Length];
    // int[] b = new int[arr!.Length];
    for( int i=0; i< arr.Length; i++)
    {
         b[i] = Convert.ToInt32(arr[i].ToString());
    }
    Console.WriteLine("[" + string.Join(", ", b) +"]");

int sum = 0;
for(int i = 0; i < arr.Length; i++){
     sum = sum + b[i];
 }

// string? arr = Number("Введите число: ");
System.Console.WriteLine(sum);
