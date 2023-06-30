// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

Clear();
int[,] arrr = new int[6,6];
FilArray(arrr);
PrintArray(arrr);
WriteLine();
WriteLine("Введите номер строки:");
int str = Convert.ToInt32(Console.ReadLine());
WriteLine("Введите номер столбца:");
int col = Convert.ToInt32(Console.ReadLine());
int result = CompareArray(str, col, arrr);
if(result==0) WriteLine("Нет такого элемента");
else WriteLine($"Элемент с указанными позициями: {result}");



void FilArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++) 
    {
         for (int j = 0; j < ar.GetLength(1); j++) ar[i,j] = new Random().Next(1, 99);
    }
}

int CompareArray(int s, int c, int[,] ar)
{
    int res = 0;
    for (int i = 0; i < ar.GetLength(0); i++) 
    {
         for (int j = 0; j < ar.GetLength(1); j++) 
         {
         if((i==s-1 && j==c-1)) res = ar[i,j];
         
         }
    }
return res;
}


void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++) 
    {
         for (int j = 0; j < ar.GetLength(1); j++) Write(ar[i,j]+" ");
    WriteLine();
    }
WriteLine();
}
