string[] array = new string[6] { "486", "-55", "samara", "russia", "computer science", "2" };
string[] result = new string[array.Length];

void NewArray(string[] array, string[] result)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      result[count] = array[i];
      count++;
    }
  }
}

void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

NewArray(array, result);
PrintArray(result);
