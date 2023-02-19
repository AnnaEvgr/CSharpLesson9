/*Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все чётные натуральные числа
в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/

void ShowNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    for (m = m; m <= n; m++)
         if (m % 2 == 0)
            System.Console.Write($"{m} ");
            ShowNumbers(m+1,n);
    }

ShowNumbers(5, 10);







// void ShowNumbers(int start, int finish, int number)
// {
//     if (start > finish)
//     {
//         return;
//     {
//         int i=0;
//     for (i=start; i<=finish;i++);
//     }
//     if (number % 2 == 0)

//         System.Console.WriteLine($"{number}");
//     }
//     System.Console.Write(start + " ");
//     ShowNumbers(start + 1, finish);

// }

// ShowNumbers(1, 4);