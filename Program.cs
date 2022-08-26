// Задача номер 2.

Console.WriteLine (" Введите число и мы покажем какое больше ");
int a,b;
Console.WriteLine("Введи свое первое число - ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи свое второе число - ");
b = Convert.ToInt32(Console.ReadLine());

bool One0 = a > b;
bool One1 = a == b;
bool One2 = a < b;

if (One0)
{
    Console.WriteLine($"Число {a} больше чем {b}");
}
 else if (One1)
 {
     Console.WriteLine($"Числа {a} и {b} равны");
 }
 else
 {
     Console.WriteLine($"Число {b} больше чем {a}");
 } 

 // Задача номер 4.

/* System.Console.WriteLine("Максимальное число" );
int a,b,c;
Console.WriteLine("Введи свое первое число - ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи свое второе число - ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи свое третье число - ");
c = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(Math.Max(a, Math.Max(b, c))); */

//Задача номер 6.

/* Console.WriteLine ( "Введите число" );
int number = Convert.ToInt32(Console.ReadLine());
if ( number %2==0 )
{
    Console.WriteLine("Чётное число");
}
else Console.WriteLine("Нечётное число"); */

// Задача номер 8.

/* int startValue = 2;
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
while (startValue  <= 9)

{
    Console.WriteLine(startValue);
    startValue += 2;
}  */
