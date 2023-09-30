Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Последняя цифра числа: " + num % 10); // %10 - остаток для трехзначного числа