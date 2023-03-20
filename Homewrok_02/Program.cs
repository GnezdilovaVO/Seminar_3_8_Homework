using static Library;
int m = GetNumber("Введите кол-во строк: ");
int n = GetNumber("Введите кол-во столбцов: ");
int[,] array = new int [m, n];
FillArray(array);
PrintArray(array);
int[] newArray = GetSumLine(array);
Console.WriteLine(PrintSumLine(newArray));
//GetMinLine(newArray);

