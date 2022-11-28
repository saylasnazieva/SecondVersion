// 
/*
void  ShowNumbers(int n) 
{ 
    if(n > 1) ShowNumbers(n-1); 
    Console.Write(n + " "); 
} 
 
ShowNumbers(5); 
*/ 
/* 
int SumOfDigits (int num) 
{ 
    if(num ! = 0) return SumOfDigits(num / 10) + num % 10; 
    return 0;  
} 
 
Console.WriteLine(SumOfDigits(1234)); 
*/ 
 
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии. 
 
// N = 5 -> "5, 4, 3, 2, 1" 
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 
/* 
void  ShowNumbers(int n) 
{ 
    Console.Write(n + " "); 
    if(n > 1) ShowNumbers(n-1); 
     
} 
 
ShowNumbers(8); 
*/ 
 
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// M = 1; N = 15 -> 120 
// M = 4; N = 8. -> 30 
/* 
Console.Write("Enter a number of M : "); 
int numM = Convert.ToInt32(Console.ReadLine()); 
 
Console.Write("Enter a number of N : "); 
int numN = Convert.ToInt32(Console.ReadLine()); 
 
void ShowNumbers(int M, int N) 
{ 
    Console.Write(SumMN(M-1,N)); 
} 
 
int SumMN(int M, int N) 
{ 
    int res = M; 
    if (M == N) 
        return 0; 
    else 
    { 
        M++; 
        res = M + SumMN(M, N); 
        return res; 
    } 
} 
Console.WriteLine(); 
Console.Write($"Sum of all numbers from {numM} to {numN} = {(numM, numN)}"); 
Console.WriteLine(); 
*/ 
 
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9 
// m = 3, n = 2 -> A(m,n) = 29 
/* 
int[,] Create2DRandomArray() 
 
int Ack(int m, int n) 
 { 
    if (n == 0) 
        return m + 1; 
    else 
      if ((n != 0) && (m == 0)) 
        return Ack(n - 1, 1); 
    else 
        return Ack(n - 1, Ack(n, m - 1)); 
} 
  
Console.WriteLine(); 
 
Console.ReadLine(); 
*/
