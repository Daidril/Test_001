﻿int a = 1; //Присваивание переменной a число
int b = 8; //Присваивание переменной b число
int c = 3; //Присваивание переменной c число
int d = 2; //Присваивание переменной d число
int e = 6; //Присваивание переменной e число

int max = a; //кладем в переменную макс значение переменной a

if(a > max ) max = a; //Если значение a больше макс, то в макс кладем новое значение
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);