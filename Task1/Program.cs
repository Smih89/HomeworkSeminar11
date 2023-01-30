//Задача 37: 

//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

/* 1. Ввод данных 
   Считать int число
   int <- string */
int Getval(string text)
{
  return Convert.ToInt32(text);
}

/* 2. Саздание массива
   int-чисел
   int[] <- int */
int[] CreatArray(int size)
{
  int[] array = new int[size];
  return array;
}

/* 3. Заполнение массива
   с клавиатуры
   int[] <- (void)  */

void FillArray(int[] array)
{
  for (int index = 0; index < array.Length; index++)
  {
    array[index] = Getval(Console.ReadLine());
  }
}

/*4. Поиск произведения
   int[] <- int[] */
int[] IndexOf(int[] array)
{
  // int[] bin = new int[array.Length/2];  
  int[] bin = new int[array.Length / 2 + array.Length % 2];
  if (array.Length % 2 > 0) { bin[bin.Length - 1] = array[bin.Length - 1]; };

  for (int i = 0; i < array.Length / 2; i++)
  {
    bin[i] = array[i] * array[array.Length - 1 - i];
  }
  return bin;
}

/* 5. Печать
   string <- int[] */
string PrintArray(int[] array)
{
  string output = String.Empty;
  for (int newIndex = 0; newIndex < array.Length; newIndex++)
  {
    output = output + " " + array[newIndex];
  }
  return output;
}

Console.WriteLine("Введите длину массива: ");
int[] array = CreatArray(Getval(Console.ReadLine()));
Console.WriteLine("Введите числа массива: ");
FillArray(array);
Console.WriteLine("первый массив " + PrintArray(array));
int[] newArray;
newArray = IndexOf(array);
Console.WriteLine("Второй массив " + PrintArray(newArray));