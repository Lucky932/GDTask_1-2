﻿object[] arr = { 1, 4, 5, 6, "2", "-6", "1", "3" }; // создаем объект с разными типами данных

int sumint = 0; // создаем сумму целочисленных данных
int sumstr = 0; // создаем сумму строковых данных

foreach (object i in arr) // создаем цикл перебора коллекций
{
    if (i is int) // проверка, если созданный объект "i" будет соответствовать целочисленному типу, то можно суммировать элементы.
    {
        sumint += (int)i; // сама сумма целочисленных данных
    }
    if (i is string)
    {
        sumstr += Convert.ToInt32(i); // сумма строковых данных
    }
}

Console.WriteLine($"Разница суммы цел. и строковых чисел: {Convert.ToString(sumint - sumstr)}"); // вывод