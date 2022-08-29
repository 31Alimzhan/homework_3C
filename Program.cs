// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Razvorot(string dannye)                                      // метод сравнения чисел сначала думал разворачивать число, но передумал так как возникли нестыковки с типами данных и излишние конвертации
{
    int count = 0;
    int len = dannye.Length;                                      // находим длину
    for (int i = 1, j = len - 1; i < j; i++, j--)                 // запускаем цикл при котором есть 2 переменные i и j  для сравнения слов одно сначала другое с конца
    {
        if (dannye[i] != dannye[j])                               // если не соответствует 
        { 
            count ++;                                             // то увеличиваем count на 1 это означает что есть асимметрия (счетчик асимметрии)
        }
    }
    if (count>0)                                                  // теперь задаем условие если была хоть одна асимметрия то 
    {
        return false;                                             // возвращаем false значит не полиндром
    }
    else                                                          // иначе 
    {
        return true;                                              // полиндром асимметрии нет count = 0
    }
}

Console.WriteLine("Введите число");                               // собственно начало программы предлагаем ввести число
string word = Convert.ToString(Console.ReadLine());               // переводим данные в строку для удобства дальнейших иттераций (i=0 и т.д.....) в рамках метода     
if (Razvorot(word))                                              // вызываем метод обернув в условие iF  
{
    Console.WriteLine("не полиндром");                            // если False то не полиндром
}
else                                                              // иначе
{ 
    Console.WriteLine("Полиндром");                               // если True то полиндром
}
*/


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.WriteLine("Введите координаты точки А ");                 // собираем коорлдинаты точки А
Console.WriteLine("Введите x1(А) - ");                            // 
int x1 = Convert.ToInt32(Console.ReadLine());                     // 
Console.WriteLine("Введите y1(А) - ");                            // 
int y1 = Convert.ToInt32(Console.ReadLine());                     // 
Console.WriteLine("Введите z1(А) - ");                            // 
int z1 = Convert.ToInt32(Console.ReadLine());                     // 


Console.WriteLine("Введите координаты точки B ");                 // собираем координаты точки B
Console.WriteLine("Введите x2(B) - ");                            // 
int x2 = Convert.ToInt32(Console.ReadLine());                     // 
Console.WriteLine("Введите y2(B) - ");                            // 
int y2 = Convert.ToInt32(Console.ReadLine());                     // 
Console.WriteLine("Введите z2(B) - ");                            // 
int z2 = Convert.ToInt32(Console.ReadLine());                     // 


Console.WriteLine($"A ({x1},{y1},{z1})");                         // показываем координаты А
Console.WriteLine($"B ({x2},{y2},{z2})");                         // показываем координаты B

double rezult = Convert.ToDouble(Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1))); // здесь основное решение с конвертацией в doudle странно сработало с первого раза без ошибок :)
Console.WriteLine("Расстоние равно - " + rezult);                         // показываем результат  
*/
// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N ");                           // собираем координаты точки А
int n = Convert.ToInt32(Console.ReadLine());                     // 

for (int i=1; i<(n+1); i++)                                      // организовываем цикл
{
    Console.Write(Math.Pow(i,3));                                // вывод на эуран куб числа i через метод Math.Pow (arg1,arg2) где agr1 это возволимое число и arg2 это степень

    if (i==(n))                                                  // далее все сделано чтобы не было запятой в конце строки после последнего выводимого числа Если i=n то остановить программу
    {
        break;
    }
    else 
    {
    Console.Write(", ");                                         // иначе писать запятую
    }
    
}

