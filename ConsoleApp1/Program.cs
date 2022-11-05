// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 Вывести на экран число e (основание натурального логарифма) с точностью до десятых
            /*Console.WriteLine(Math.E);*/

            //Задание 2 Вывести на экран числа 50 и 10 одно под другим
            /*Console.WriteLine("50\n 10");
            Console.WriteLine(10);

            //Задание 3 Составить программу вывода на экран «столбиком» четырех любых чисел.
            /*double a, b, c, d;  
            Console.WriteLine("Введите число a=");
            Console.WriteLine("Введите число b=");
            Console.WriteLine("Введите число c=");
            Console.WriteLine("Введите число d=");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            
            //Решение правильное
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();*/

            //Задание 4 Пользователь вводит число. Выведите на экран число, которое больше введенного на 10.
            /*double a;
            Console.WriteLine("Введите число, мы прибавим к нему 10, не спрашивайте почему.... ПОТОМУ ЧТО МЫ МОЖЕМ");
            a = Convert.ToDouble(Console.ReadLine());
            double result = a + 10;
            Console.WriteLine(result);*/

            //Задание 5 Дана сторона квадрата. Найти его периметр.
            /*double a;
            Console.WriteLine("Введите сторону квадрата, чтобы найти его периметр");
            a = Convert.ToDouble(Console.ReadLine());
            double result = a * 4; // умножаем на 4 ,т.к. стороны равны
            double result = a + a + a + a; // фактически тоже самое только прибавляем.
            Console.WriteLine(result);*/

            //Задание 6 Дан радиус окружности. Найти длину окружности и площадь круга
            /*double a;
            Console.WriteLine("Введите радиус окружности, чтобы найти длину и площадь окржности");
            a = Convert.ToDouble(Console.ReadLine());
            double result = 2 * 3.14 * a;
            double result1 =  Math.PI* (a * a);
            Console.WriteLine($"длина окржуности {result}");
            Console.WriteLine($"площадь окржуности {result1}");*/

            //Задание 7 Найти значение y=cos(x)
            /*double x;
            Console.WriteLine("Введите значение x, чтобы найти значение y");
            x = Convert.ToDouble(Console.ReadLine());
            double result =  Math.Cos (x) ;
            Console.WriteLine(result);*/

            //Задание 8 Даны основания и высота равнобедренной трапеции. Найти ее периметр. ДОДЕЛАТЬ знаем как вычислить боковую сторону, но вопрос значения основания

            /*double a, b;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());   
            double c = (double) Math.Sqrt (a*a + b*b);
            double result = (double)a + b + c * 2;
            Console.WriteLine(result);*/

            //Задание 9
            /*double a, b, c;
            Console.WriteLine("сколько киллограм конфет вы берете, учтите что один киллограмм стоит 183 рубля");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("сколько киллограм печенья вы берете, учтите что один киллограмм стоит 123 рубля");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("сколько киллограм печенья вы берете, учтите что один килограмм стоит 100 рублей");
            c = Convert.ToDouble(Console.ReadLine());
            double result = (double)a * 183 + b * 123 + c * 100;
            Console.WriteLine($"Cтоимость: {result} рублей");*/

            //Задание10 Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май" (кавычки не нужны). 
            /*Console.WriteLine("Мир Труд Май");
            Console.ReadLine();
            Console.Clear();
            string name = "Мир";
            string name1 = "Труд";
            string name2 = "Май";
            Console.WriteLine("{0,0}", name);
            Console.WriteLine("{0,8}", name1);
            Console.WriteLine("{0,13}", name2);*/

            //Задание 11^?


            double a, b, c, d, e, f, g, h;
            Console.WriteLine("Перимет и площадь какой фигуры вам необходимо вычеслить? Треугольник - 1, Четырехугольник - 2, Круг - 3");
            a = Convert.ToDouble(Console.ReadLine());
            double D = a;//определяющая часть для выбора фигуры
            if (D < 0) 
            {
                Console.WriteLine("Вы выбрали трелугольник");
                Console.WriteLine("Укажите первую сторону");
                c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Укажите вторую сторону");
                d = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Укажите третью сторону");
                e = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберите, что вам нужно узнать площадь или периметр. Площадь - 1, периметр - 2");
                b = Convert.ToDouble(Console.ReadLine());
                double E = b;//выбираем что нужно периметр или площадь
                if (E == 1)
                {
                    g = ((c + d + e) / 2);
                    Console.WriteLine("Площадь равна", Math.Sqrt(g * (g - c) * (g - d) * (g - e)));
                }
                if (E == 2)//Исппавиит Ошибка
                {
                    Console.WriteLine ("Периметр равен", c + d + e);
                }
            }if (D == 0)
            {
                Console.WriteLine("Вы выбрали Четырхугольник");
                Console.WriteLine("Укажите первую сторону");
                c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Укажите вторую сторону");
                d = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Укажите третью сторону");
                e = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Укажите четвертую сторону");
                f = Convert.ToDouble(Console.ReadLine());
            }











        }
    }
}