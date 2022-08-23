//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
int num1 ;
int num2 ;

Console.Write ("Введите число 1: ");
num1 = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("Введите число 2: ");
num2 = Convert.ToInt32 (Console.ReadLine ());

if (num1 > num2) {
    Console.WriteLine ("Число большее: "+ num1);
}
else {
    Console.WriteLine ("Число большее: "+ num2);
}

*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
int num1 ;
int num2 ;
int num3 ;


Console.WriteLine ("Введите число 1: ");
Console.WriteLine ("Введите число 2: ");
Console.WriteLine ("Введите число 3: ");

num1 = Convert.ToInt32 (Console.ReadLine ());
num2 = Convert.ToInt32 (Console.ReadLine ());
num3 = Convert.ToInt32 (Console.ReadLine ());
int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;    

    Console.Write ( "Максимальное число:  " + max);

    */

    //Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
int num ;
int curr;
curr = 2;

Console.Write("Введите число num: ");
num = Convert.ToInt32(Console.ReadLine());


while (curr <= num)
{
    Console.Write(curr + " ");
    curr = curr + 2;
}

*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
int num ;

Console.Write("Введите число num: ");
num = Convert.ToInt32(Console.ReadLine());

// Проверяем отсутствие остатка от деления
if(num % 2 == 0)
{
    Console.Write(num + " Четное");
}
else
{
    Console.Write(num + " Не Четное");
}

*/