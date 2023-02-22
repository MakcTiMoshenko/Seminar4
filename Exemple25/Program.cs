// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Step(int A, int B){
int result = 1;
for (int i=1; i<=B; i++){
    result = result*A;
} 
return result;
}
int A = ReadInt("Введите А: ");
int B = ReadInt("Введите B: ");
Console.WriteLine($"Число {A} в степени {B} = {Step(A, B)} ");