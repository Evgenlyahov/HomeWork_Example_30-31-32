// 31. Задать массив из 8 элементов и вывести их на экран 

int[] array = new int[8];
for(int i = 0; i <array.Length; i++)
{
    array[i] = new Random().Next(10, 100);
    System.Console.WriteLine($"Элемент массива {i} равен {array[i]}");
}