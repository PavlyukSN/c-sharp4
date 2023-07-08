/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
void InputArr(int[] Arr){
for (int i=0; i < Arr.Length; i++) 
{
    Arr[i] = new Random().Next(0, 10);
    Console.Write(Arr[i]);
    if(i < Arr.Length-1) Console.Write(", ");
}
Console.Write(" -> ");
Console.Write("[");
for (int i=0; i < Arr.Length; i++)
{
    Console.Write(Arr[i]);
    if(i < Arr.Length-1) Console.Write(", ");
}
Console.Write("]");
}
//-----------------

int[] N = new int[8];
InputArr(N);
