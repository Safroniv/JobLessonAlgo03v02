using BenchmarkDotNet.Running;

namespace JobLessonAlgo03v02Part01
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}