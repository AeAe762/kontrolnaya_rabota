/// Написать программу, которая из имеющегося массива строк формирует новый массив из 
// строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["Hello", "2", "world", ":-)"] → [“2”, “:-)”]
// ["1234", "1567", "-2", "computer science"] → [“-2”]
// ["Russia", "Denmark", "Kazan"] → []

string[] Create_array(int length)
{
  string[] array = new string[length];
  for (int i = 0; i < length; i++)
  {
    Console.Write($"Введите переменную {1 + i}: ");
    array[i] = Console.ReadLine()!;
  }
  return array;
}

string[] Create_new_array (string[] array1) 
{
  int count = 0;
  int length = array1.Length;
  string[] array2 = new string[length];
  for (int i = 0; i < length; i++)
  {
    if (array1[i].Length <=3)
    {
      array2[count] = array1[i];
      count ++;
    }
  }
  return array2;
}

void Print (string[] arr)
{
  string[] arr1 = new string[arr.Length];
  for (int i = 0; i < arr1.Length; i++)
    Console.Write($"{arr[i]} ");
  Console.WriteLine();
}


Console.Write("Введите длину массива: ");
int a = int.Parse(Console.ReadLine()!);
string[] res = Create_array(a);
Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символам");
string[] res2 = Create_new_array(res);
Print(res2);
