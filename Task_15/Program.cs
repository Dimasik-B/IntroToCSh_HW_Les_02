Console.WriteLine("Введите цифру от 1 до 7: ");
int numOfDay = int.Parse(Console.ReadLine());
if (numOfDay >= 1 && numOfDay <= 7){
    if (numOfDay == 6 || numOfDay == 7) Console.WriteLine("Ура, выходной!");
    else Console.WriteLine("Опять будни...");
}
else Console.WriteLine("Некорректный ввод");