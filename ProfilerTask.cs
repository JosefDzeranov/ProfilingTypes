using System.Collections.Generic;
using System.Diagnostics;

namespace Profiling
{
    public class ProfilerTask : IProfiler
    {
        public List<ExperimentResult> Measure(IRunner runner, int repetitionsCount)
        {
            var result = new List<ExperimentResult>();
            foreach (var fieldCount in Constants.FieldCounts)
            {
                // прогрев
                var structTime = StructResult(runner, repetitionsCount, fieldCount);
                var classTime = ClassResult(runner, repetitionsCount, fieldCount);
                result.Add(new ExperimentResult(fieldCount, classTime, structTime));
            }

            return result;
        }

        private static double StructResult(IRunner runner, int repetitionsCount, int fieldCount)
        {
            var stopwatch = Stopwatch.StartNew();
            // прогрев
            runner.Call(false, fieldCount, 1);

            stopwatch.Restart();
            runner.Call(false, fieldCount, repetitionsCount);
            var time = stopwatch.Elapsed.TotalMilliseconds;
            return time / repetitionsCount;
        }

        private static double ClassResult(IRunner runner, int repetitionsCount, int fieldCount)
        {
            var stopwatch = Stopwatch.StartNew();
            // прогрев
            runner.Call(true, fieldCount, 1);

            stopwatch.Restart();
            runner.Call(true, fieldCount, repetitionsCount);
            var time = stopwatch.Elapsed.TotalMilliseconds;
            return time / repetitionsCount;
        }
    }
}