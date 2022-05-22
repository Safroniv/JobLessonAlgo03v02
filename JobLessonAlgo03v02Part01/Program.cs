namespace JobLessonAlgo03v02Part01
{
    class Program
    {
        /// <summary>
        /// Класс ссылочного типа обозначения координат точки типа float
        /// </summary>
        public class PointClassFloat
        {
            public float X;
            public float Y;
        }

        /// <summary>
        /// Значимый тип обозначения координат точки типа float
        /// </summary>
        public struct PointStructFloat
        {
            public float X;
            public float Y;
        }

        /// <summary>
        /// Значимый тип обозначения координат точки типа Double
        /// </summary>
        public struct PointStructDouble
        {
            public double X;
            public double Y;
        }

        /// <summary>
        /// Значимый тип обозначения координат точки типа float 
        /// без расчёта квадратного корня
        /// </summary>
        public struct PointStructWithoutSQRT
        {
            public float X;
            public float Y;
        }

        static void Main(string[] args)
        {

            Console.WriteLine($"\n Вывод строк Class");
            var pointClass = new PointClassFloat() { X = 42, Y = 42 };
            var arrayClass = new PointClassFloat[1];
            arrayClass[0] = pointClass;
            PrintPointClass(pointClass, "1. point local variable");
            PrintPointClass(arrayClass[0], "2. point in array");
            ChangePointClass(pointClass);
            PrintPointClass(pointClass, "3. point local variable");
            PrintPointClass(arrayClass[0], "4. point in array");
            pointClass = new PointClassFloat() { X = 7, Y = 7 };
            PrintPointClass(pointClass, "5. point local variable");
            PrintPointClass(arrayClass[0], "6. point in array");

            Console.WriteLine($"\n Вывод строк Struct");
            var point = new PointStructFloat { X = 42, Y = 42 };
            var array = new PointStructFloat[1];
            array[0] = point;
            array[0].Y = 33;
            PrintPointStruct(point, "1. point local variable");
            PrintPointStruct(array[0], "2. point in array");
            ChangePointStruct(point);
            PrintPointStruct(point, "3. point local variable");
            PrintPointStruct(array[0], "4. point in array");
            point = new PointStructFloat() { X = 7, Y = 7 };
            PrintPointStruct(point, "5. point local variable");
            PrintPointStruct(array[0], "6. point in array");

            //BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
        /// <summary>
        /// Вывод на печать коордират точки ссылочного типа
        /// </summary>
        /// <param name="pointClass">Значения координат</param>
        /// <param name="tag">Комментарий</param>
        public static void PrintPointClass(PointClassFloat pointClass, string tag)
        {
            Console.WriteLine($"{tag}\t X:{pointClass.X}, Y:{pointClass.Y}");
        }
        /// <summary>
        /// Метод изменения координат для значений ссылочного типа
        /// </summary>
        /// <param name="pointClass">Значения координат</param>
        public static void ChangePointClass(PointClassFloat pointClass)
        {
            pointClass.X = 13;
            pointClass.Y = 13;
        }
        /// <summary>
        /// Вывод на печать коордират точки значимого типа
        /// </summary>
        /// <param name="pointClass">Значения координат</param>
        /// <param name="tag">Комментарий</param>
        public static void PrintPointStruct (PointStructFloat pointClass, string tag)
        {
            Console.WriteLine($"{tag}\t X:{pointClass.X}, Y:{pointClass.Y}");
        }
        /// <summary>
        /// Метод изменения координат для значений значимого типа
        /// </summary>
        /// <param name="pointClass">Значения координат</param>
        public static void ChangePointStruct (PointStructFloat pointClass)
        {
            pointClass.X = 13;
            pointClass.Y = 13;
        }
    }
    //public class BechmarkClass
    //{
    //    public int SumValueType(int value)
    //    {
    //        return 9 + value;
    //    }
    //    public int SumRefType(object value)
    //    {
    //        return 9 + (int)value;
    //    }
    //    [Benchmark]
    //    public void TestSum()
    //    {
    //        SumValueType(99);
    //    }
    //    [Benchmark]
    //    public void TestSumBoxing()
    //    {
    //        object x = 99;
    //        SumRefType(x);
    //    }
    //}
}