//Математическое решение
int number = new Random().Next(0, 100000);
int result = 0;
if (number < 100) Console.WriteLine($"В числе {number} нет третьей цифры");
else if (number >= 100 && number < 1000) {
    result = number % 10;
    Console.WriteLine($"Третья цифра числа {number} это {result}");
}
else if (number >= 1000 && number < 10000) {
    result = ((number % 100) / 10);
    Console.WriteLine($"$Третья цифра числа {number} это {result}");
}
else {
    result = ((number % 1000) / 100);
    Console.WriteLine($"Третья цифра числа {number} это {result}");
}

// Решение со строкой
/*Console.Write("Введите число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
if (numberInt >= 100 ){
    Console.WriteLine($"Третья цифра числа {number} это {number[2]}");
}
else Console.WriteLine($"В числе {number} нет третьей цифры");*/