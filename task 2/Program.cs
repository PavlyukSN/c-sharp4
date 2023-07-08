/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

 Console.Write("Введите число : ");
 int Number = int.Parse(Console.ReadLine());
 int stm = 0;
 string Arr = Number.ToString();
for (int i=0; i < Arr.Length; i++)
{   
    stm = stm + Arr[i]-48;
}
Console.WriteLine($"{Number} -> {stm}");