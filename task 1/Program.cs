/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

void PrintTruaTable(int One, int Two){
    int res = 1; // любое число в 0 степени
    for(int i=0; i<Two; i++)
    {
        res = res*One;
    }
Console.WriteLine($" -> {res}");
}
//-------------

 Console.Write("Введите число : ");
 int A = int.Parse(Console.ReadLine());
Console.Write("В какую степень возводим? : ");
 int B = int.Parse(Console.ReadLine());
 Console.Write($"{A}, {B}");
 Console.WriteLine();
 PrintTruaTable(A, B);