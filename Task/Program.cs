// Написать программу, которая из имеющегося массива целых чисел 
// формирует массив из четных чисел. Первоначальный массив можно ввести 
// с клавиатуры, либо сгенерировать случайным образом. При решении 
// не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int[] Array = new int[10];
int[] NewArray = new int[10];

void CreatPrintArray(int[] Array)
{
  for (int i = 0; i < Array.Length; i++)
  {
    Array[i] = new Random().Next(1, 15);
    Console.Write($"{Array[i]} ");
  }
}

void ChangeArray(int[] Array)
{
  for (int i = 0; i < Array.Length; i++)
  {
    NewArray[i] = Array[i];
    if (NewArray[i] >8)
      System.Console.Write($"{NewArray[i]} ");
  }
}


CreatPrintArray(Array);
System.Console.WriteLine();
ChangeArray(Array);
