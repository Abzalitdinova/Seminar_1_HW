// задача 2: программа, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine("введите число №1: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число №2: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());
if (firstnumber > secondnumber)
{
    Console.WriteLine(firstnumber);
}
else
{
    Console.WriteLine(secondnumber);
}

// задача 4: программа, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.WriteLine("введите число №1: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число №2: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число №3: ");
int thirdnumber = Convert.ToInt32(Console.ReadLine());
int max = firstnumber;
if (secondnumber > max) 
{
    max = secondnumber;
} 
if (thirdnumber > max)
{
    max = thirdnumber;
}  
Console.WriteLine(max);

// задача 6: программа, которая на вход принимает число и выдаёт, 
// является ли число чётным

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}

// задача 8: программа, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
Console.WriteLine("1");
while (count < number)
{
    Console.WriteLine(count);
    count +=1;
    if (count%2 ==0)
    {
        Console.WriteLine(count);
    }
    else
    {
        count +=1;
    }
} 
{
    
    Console.WriteLine(number);
} 