// Задача 64:Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//  {
//         int n = 4;
    //     PrintNumbers(n);
    //     Console.WriteLine();
        
    //     n = 9;
    //     PrintNumbers(n);
    //     Console.WriteLine();
    // }
    
    // static void PrintNumbers(int n)
    // {
    //     if (n < 1)
    //         return;
    //     Console.Write(n + " ");
    //     PrintNumbers(n - 1);
    // }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдет сумму натуральных
// элементов в промежутке от М до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


//  {
//         int m = 2;
//         int n = 6;
//         int sum = CalculateSum(m, n);
//         Console.WriteLine("Сумма натуральных элементов от {0} до {1} = {2}", m, n, sum);
        
//         m = 10;
//         n = 20;
//         sum = CalculateSum(m, n);
//         Console.WriteLine("Сумма натуральных элементов от {0} до {1} = {2}", m, n, sum);
//     }
    
//     static int CalculateSum(int m, int n)
//     {
//         if (m > n)
//             return 0;
        
//         return m + CalculateSum(m + 1, n);
//     }


// Задача 68:Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


//   {
//         int m = 2;
//         int n = 3;
//         int result = AckermannFunction(m, n);
//         Console.WriteLine("A({0}, {1}) = {2}", m, n, result);
        
//         m = 3;
//         n = 2;
//         result = AckermannFunction(m, n);
//         Console.WriteLine("A({0}, {1}) = {2}", m, n, result);
//     }
    
//     static int AckermannFunction(int m, int n)
//     {
//         if (m == 0)
//             return n + 1;
//         else if (m > 0 && n == 0)
//             return AckermannFunction(m - 1, 1);
//         else if (m > 0 && n > 0)
//             return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        
//         return 0;
//     }


