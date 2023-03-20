using static Library;
int m = GetNumber("Ведите кол-во строк: ");
int n = GetNumber("Ведите кол-во столбцов: ");
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
StreamLineArray(array);
Console.WriteLine();
PrintArray(array);