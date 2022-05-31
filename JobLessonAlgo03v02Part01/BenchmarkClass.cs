using BenchmarkDotNet.Attributes;

namespace JobLessonAlgo03v02Part01
{
    public partial class BenchmarkClass
    {
        [Params(100, 1000)]
        public int N;

        private PointClassFloat[] pointClassFloats;
        private PointStructFloat[] pointStructFloats;
        private PointStructDouble[] pointStructDoubles;
        private PointStructWithoutSQRT[] pointStructWithoutSQRTs;

        [GlobalSetup]
        public void GlobalSetup()
        {
            pointClassFloats = new PointClassFloat[N];
            pointStructFloats = new PointStructFloat[N];
            pointStructDoubles = new PointStructDouble[N];
            pointStructWithoutSQRTs = new PointStructWithoutSQRT[N];

            for (int i = 0; i < N; i++)
            {
                pointClassFloats[i] = new PointClassFloat
                {
                    X = new Random(-10).NextSingle() ,
                    Y = new Random(10).NextSingle() ,
                };
                pointStructFloats[i] = new PointStructFloat
                {
                    X = new Random(-10).NextSingle() ,
                    Y = new Random(10).NextSingle() ,
                };
                pointStructDoubles[i] = new PointStructDouble
                {
                    X = new Random(-10).NextDouble() ,
                    Y = new Random(10).NextDouble() ,
                };
                pointStructWithoutSQRTs[i] = new PointStructWithoutSQRT
                {
                    X = new Random(-10).NextSingle(),
                    Y = new Random(10).NextSingle(),
                };
            }
        }

        [Benchmark]
        public float TestDistanceClassFloat()
        {

            float distance = 0;
            for (int i = 1; i < N; i++)
            {
                
                float x = pointClassFloats[i-1].X - pointClassFloats[i].X;
                float y = pointClassFloats[i-1].Y - pointClassFloats[i].Y;
                distance = MathF.Sqrt((x * x) + (y * y));
            }
            return distance;
        }

        [Benchmark]
        public float TestDistanceStructFloat()
        {
            float distance = 0;
            for (int i = 1; i < N; i++)
            {

                float x = pointStructFloats[i - 1].X - pointStructFloats[i].X;
                float y = pointStructFloats[i - 1].Y - pointStructFloats[i].Y;
                distance = MathF.Sqrt((x * x) + (y * y));
            }
            return distance;
        }

        [Benchmark]
        public double TestDistanceStructDouble()
        {
            double distance = 0;
            for (int i = 1; i < N; i++)
            {

                double x = pointStructDoubles[i - 1].X - pointStructDoubles[i].X;
                double y = pointStructDoubles[i - 1].Y - pointStructDoubles[i].Y;
                distance = Math.Sqrt((x * x) + (y * y));
            }
            return distance;
        }

        [Benchmark]
        public float TestDistanceStructFloatWithoutSQRT()
        {
            float distance = 0;
            for (int i = 1; i < N; i++)
            {
                float x = pointStructWithoutSQRTs[i - 1].X - pointStructWithoutSQRTs[i].X;
                float y = pointStructWithoutSQRTs[i - 1].Y - pointStructWithoutSQRTs[i].Y;
                distance = (x * x) + (y * y);
            }
            return distance;
        }
    }
}
