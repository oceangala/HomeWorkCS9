// // Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.

// string ConvertDeciToBinary (int n)
// {
//     string nBin = string.Empty;
//        if(n!=0)
//         {nBin = ConvertDeciToBinary(n/2) + n%2;
//            n=n/2; 
//            return nBin;}
//         else return nBin;
// }


// Console.Write("Enter your number in decimal system: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if(a>0) Console.WriteLine("Your number in binary system is: " 
//     +ConvertDeciToBinary(a));
// else if(a<0) Console.WriteLine("Your number in binary system is: -" 
//     +ConvertDeciToBinary((a*-1)));
// else if(a==0) Console.WriteLine("Your number in binary system is: 0");




//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumBetweenMN(int m, int n)
{
    int sum = Math.Min(m,n);
    if(Math.Min(m,n)!=Math.Max(m,n))
    {
        sum = sum+ SumBetweenMN(Math.Min(m,n)+1, Math.Max(m,n));
        return sum;
    }
    else return sum;
}

Console.Write("Enter your 1st number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your 2nd number: ");
int n = Convert.ToInt32(Console.ReadLine());
if(m<0 || n<0 || m==n) Console.WriteLine("Numbers must be greater than 0 and not equal");
else{
Console.WriteLine("Sum of numbers in between is "+ SumBetweenMN(m, n));
}