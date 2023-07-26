//Математическое решение
int number = new Random().Next(100, 1000);
int result = (number / 10) % 10;
Console.WriteLine($"Вторая цифра числа {number} это {result}");

// Решение со строкой
/*Console.Write("Введите трёхзначное число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
if (numberInt >= 100 && numberInt < 1000){
    Console.WriteLine($"Вторая цифра числа {number} это {number[1]}");
}
else Console.WriteLine($"Число {number} не яляется трёхзначным");*/
