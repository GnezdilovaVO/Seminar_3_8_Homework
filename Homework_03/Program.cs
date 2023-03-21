using static Library;
int[,] arrayA = new int[3, 3];
int[,] arrayB = new int[3, 3];
FillArray(arrayA);
FillArray(arrayB);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
int[,] arrayResult = GetMultiplication(arrayA, arrayB);
Console.WriteLine();
PrintArray(arrayResult);

