Console.Clear();
//Console.SetCursorPosition(10, 4); //Отступ от левого края 10 символов, отступ от правого 4, Строки нумеруются с 0
//Console.WriteLine("+"); //Вывод + на 4-ю строку

int xa = 28, ya = 1,
    xb = 1, yb = 20,
    xc = 56, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb;

int count = 0; //Счетчик

while(count < 10000) //Цикл
{
    int what = new Random().Next(0, 3); //выдаются числа 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2; //кладем середину отрезка
        y =(y + ya) / 2; 
    }
       if(what == 1) 
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count += 1;
}