using BenchmarkDotNet.Attributes;

namespace JobLessonAlgo03v02Part01
{
    public class BechmarkClass
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

        /// <summary>
        /// Метод расчёта расстояния между точкама для ссылочных типов Float
        /// </summary>
        /// <param name="pointOne">Первая точка</param>
        /// <param name="pointTwo">Вторая точка</param>
        /// <returns>Возвращает расстояние</returns>
        public static float PointDistanceFloat(PointClassFloat pointOne, PointClassFloat pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        /// <summary>
        /// Метод расчёта расстояния между точкама для значимых типов Float
        /// </summary>
        /// <param name="pointOne">Первая точка</param>
        /// <param name="pointTwo">Вторая точка</param>
        /// <returns>Возвращает расстояние</returns>
        public static float PointDistanceFloat(PointStructFloat pointOne, PointStructFloat pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        /// <summary>
        /// Метод расчёта расстояния между точкама для значимых типов Double
        /// </summary>
        /// <param name="pointOne">Первая точка</param>
        /// <param name="pointTwo">Вторая точка</param>
        /// <returns>Возвращает расстояние</returns>
        public static double PointDistanceDouble(PointStructDouble pointOne, PointStructDouble pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        /// <summary>
        /// Метод расчёта расстояния между точкама для значимых типов Float 
        /// без вычисления квадратного корня
        /// </summary>
        /// <param name="pointOne">Первая точка</param>
        /// <param name="pointTwo">Вторая точка</param>
        /// <returns>Возвращает расстояние без вычисления квадратного корня</returns>
        public static float PointDistanceShort(PointStructWithoutSQRT pointOne, PointStructWithoutSQRT pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }

        /// <summary>
        /// Тестовый метод вычисления дистанции для ссылочных типов данных Float
        /// </summary>
        [Benchmark]
        public void TestDistanceClassFloat()
        {
            
            //PointDistanceDouble();
        }

        /// <summary>
        /// Тестовый метод вычисления дистанции для значимых типов данных Float
        /// </summary>
        [Benchmark]
        public void TestDistanceStructFloat()
        {

        }

        /// <summary>
        /// Тестовый метод вычисления дистанции для значимых типов данных Double
        /// </summary>
        [Benchmark]
        public void TestDistanceStructDouble()
        {

        }

        /// <summary>
        /// Тестовый метод вычисления дистанции для значимых типов данных Float,
        /// без вычисления квадратного корня
        /// </summary>
        [Benchmark]
        public void TestDistanceStructFloatWithoutSQRT()
        {

        }
    }
}
