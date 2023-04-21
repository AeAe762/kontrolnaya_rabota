// Написать программу, которая из имеющегося массива строк формирует новый массив из 
// строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["Hello", "2", "world", ":-)"] → [“2”, “:-)”]
// ["1234", "1567", "-2", "computer science"] → [“-2”]
// ["Russia", "Denmark", "Kazan"] → []

string[] Create_new_array (string[] array1)
{
  int count = 0;
  string[] arr = new string[array1.Length];
  for (int i = 0; i < array1.Length; i++)
  {
    if (array1[i].Length <=3)
    {
      arr[count] = array1[i];
      count ++;
    }
  }
  return arr;
}
void Print (string[] arr)
{
  string[] arr1 = new string[arr.Length];
  for (int i = 0; i < arr1.Length; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}

string[] array = {"1234", "1567", "-2", "computer science"}; //{"Hello", "2", "world", ":-)"};
string[] result = Create_new_array(array);
Print(result);
