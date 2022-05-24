using BenchmarkDotNet.Attributes;

namespace JobLessonAlgo03v02Part01
{
    public partial class BechmarkClass
    { 
        /// <summary>
        /// Метод генерации случайных значений координат
        /// и расчёт дистанции для класса со значениями типа Float
        /// </summary>
        static void DistanceClassFloat()
        {
            var x1 = new Random();
            var y1 = new Random();

            var x2 = new Random();
            var y2 = new Random();

            PointClassFloat pointClassFloat1 = new()
            { X = x1.NextSingle(), Y = y1.NextSingle() };

            PointClassFloat pointClassFloat2 = new()
            { X = x2.NextSingle(), Y = y2.NextSingle() };

            PointDistanceClassFloat(pointClassFloat1, pointClassFloat2);
        }

        /// <summary>
        /// Метод генерации случайных значений координат
        /// и расчёт дистанции для структуры со значениями типа Float
        /// </summary>
        static void DistanceStructFloat()
        {
            var x3 = new Random();
            var y3 = new Random();

            var x4 = new Random();
            var y4 = new Random();

            PointStructFloat pointStructFloat1 = new()
            { X = x3.NextSingle(), Y = y3.NextSingle() };

            PointStructFloat pointStructFloat2 = new()
            { X = x4.NextSingle(), Y = y4.NextSingle() };

            PointDistanceStructFloat(pointStructFloat1, pointStructFloat2);

        }

        /// <summary>
        /// Метод генерации случайных значений координат
        /// и расчёт дистанции для структуры со значениями типа Double
        /// </summary>
        static void DistanceStructDouble()
        {
            var x5 = new Random();
            var y5 = new Random();

            var x6 = new Random();
            var y6 = new Random();

            PointStructDouble pointStructDouble1 = new()
            { X = x5.NextDouble(), Y = y5.NextDouble() };

            PointStructDouble pointStructDouble2 = new()
            { X = x6.NextDouble(), Y = y6.NextDouble() };

            PointDistanceStructDouble(pointStructDouble1, pointStructDouble2);

        }

        /// <summary>
        /// Метод генерации случайных значений координат
        /// и расчёт дистанции для структуры со значениями типа Float
        /// без расчёта квадратного корня
        /// </summary>
        static void DistanceStructFloatWothoutSQRT()
        {
            var x7 = new Random();
            var y7 = new Random();

            var x8 = new Random();
            var y8 = new Random();

            PointStructWithoutSQRT pointStructWithoutSQRT1 = new()
            { X = x7.NextSingle(), Y = y7.NextSingle() };

            PointStructWithoutSQRT pointStructWithoutSQRT2 = new()
            { X = x8.NextSingle(), Y = y8.NextSingle() };

            PointDistanceStructWithoutSQRT(pointStructWithoutSQRT1, pointStructWithoutSQRT2);
        }

        /// <summary>
        /// Метод расчёта расстояния между точкама для ссылочных типов Float
        /// </summary>
        /// <param name="pointClassFloatOne">Первая точка</param>
        /// <param name="pointClassFloatTwo">Вторая точка</param>
        /// <returns>Возвращает расстояние</returns>
        public static float PointDistanceClassFloat(PointClassFloat pointClassFloatOne, PointClassFloat pointClassFloatTwo)
        {

            float x = pointClassFloatOne.X - pointClassFloatTwo.X;
            float y = pointClassFloatOne.Y - pointClassFloatTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        /// <summary>
        /// Метод расчёта расстояния между точкама для значимых типов Float
        /// </summary>
        /// <param name="pointStructFloatOne">Первая точка</param>
        /// <param name="pointStructFloatTwo">Вторая точка</param>
        /// <returns>Возвращает расстояние</returns>
        public static float PointDistanceStructFloat(PointStructFloat pointStructFloatOne, PointStructFloat pointStructFloatTwo)
        {
            float x = pointStructFloatOne.X - pointStructFloatTwo.X;
            float y = pointStructFloatOne.Y - pointStructFloatTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        /// <summary>
        /// Метод расчёта расстояния между точкама для значимых типов Double
        /// </summary>
        /// <param name="pointStructDoubleOne">Первая точка</param>
        /// <param name="pointStructDoubleTwo">Вторая точка</param>
        /// <returns>Возвращает расстояние</returns>
        public static double PointDistanceStructDouble(PointStructDouble pointStructDoubleOne, PointStructDouble pointStructDoubleTwo)
        {
            double x = pointStructDoubleOne.X - pointStructDoubleTwo.X;
            double y = pointStructDoubleOne.Y - pointStructDoubleTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        /// <summary>
        /// Метод расчёта расстояния между точкама для значимых типов Float 
        /// без вычисления квадратного корня
        /// </summary>
        /// <param name="pointStructFloatWithoutSQRTOne">Первая точка</param>
        /// <param name="pointStructFloatWithoutSQRTTwo">Вторая точка</param>
        /// <returns>Возвращает расстояние без вычисления квадратного корня</returns>
        public static float PointDistanceStructWithoutSQRT(PointStructWithoutSQRT pointStructFloatWithoutSQRTOne, PointStructWithoutSQRT pointStructFloatWithoutSQRTTwo)
        {
            float x = pointStructFloatWithoutSQRTOne.X - pointStructFloatWithoutSQRTTwo.X;
            float y = pointStructFloatWithoutSQRTOne.Y - pointStructFloatWithoutSQRTTwo.Y;
            return (x * x) + (y * y);
        }

        /// <summary>
        /// Тестовый метод вычисления дистанции для ссылочных типов данных Float
        /// </summary>
        [Benchmark]
        public void TestDistanceClassFloat()
        {
            DistanceClassFloat();
        }

        /// <summary>
        /// Тестовый метод вычисления дистанции для значимых типов данных Float
        /// </summary>
        [Benchmark]
        public void TestDistanceStructFloat()
        {
            DistanceStructFloat();
        }

        /// <summary>
        /// Тестовый метод вычисления дистанции для значимых типов данных Double
        /// </summary>
        [Benchmark]
        public void TestDistanceStructDouble()
        {
            DistanceStructDouble();
        }

        /// <summary>
        /// Тестовый метод вычисления дистанции для значимых типов данных Float,
        /// без вычисления квадратного корня
        /// </summary>
        [Benchmark]
        public void TestDistanceStructFloatWithoutSQRT()
        {
            DistanceStructFloatWothoutSQRT();
        }
    }
}
