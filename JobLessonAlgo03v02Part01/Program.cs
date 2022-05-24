﻿using BenchmarkDotNet.Running;

namespace JobLessonAlgo03v02Part01
{
    class Program
    {
        //Напишите тесты производительности для расчёта
        //дистанции между точками с помощью BenchmarkDotNet.

        //Рекомендуем сгенерировать заранее массив данных,
        //чтобы расчёт шёл с различными значениями,
        //но сам код генерации должен происходить вне участка кода,
        //время которого будет тестироваться.  

        //Для каких методов потребуется написать тест:
        //1. Обычный метод расчёта дистанции со ссылочным типом
        //(PointClass — координаты типа float).

        //2. Обычный метод расчёта дистанции со значимым типом
        //(PointStruct — координаты типа float).

        //3. Обычный метод расчёта дистанции со значимым типом
        //(PointStruct — координаты типа double).

        //4. Метод расчёта дистанции без квадратного корня со значимым типом
        //(PointStruct — координаты типа float).
        
        //!!!Результаты можно оформить в виде списка или таблицы,
        //в которой наглядно можно будет увидеть
        //время выполнения того или иного метода.


        static void Main(string[] args)
        {
            BechmarkClass bechmarkClass = new();
            bechmarkClass.TestDistanceClassFloat();
            bechmarkClass.TestDistanceStructFloat();
            bechmarkClass.TestDistanceStructDouble();
            bechmarkClass.TestDistanceStructFloatWithoutSQRT();

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}