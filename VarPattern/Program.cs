using System.Diagnostics.Metrics;

namespace VarPattern
{
    public class Program
    {
        static bool IsAcceptable(int id, int absLimit) =>
        SimulateDataFetch(id) is var results
        && results.Min() >= -absLimit
        && results.Max() <= absLimit;

        static int[] SimulateDataFetch(int id)
        {
            var rand = new Random();
            return Enumerable
                       .Range(start: 0, count: 5)
                       .Select(s => rand.Next(minValue: -10, maxValue: 11))
                       .ToArray();
        }


        public record Point(int X, int Y);

        static Point Transform(Point point) => point switch
        {
            var (x, y) when x < y => new Point(-x, y),
            var (x, y) when x > y => new Point(x, -y),
            var (x, y) => new Point(x, y),
        };


        public record YAxisMeasurement(int x, int y); 

        public static YAxisMeasurement Measurement(YAxisMeasurement yaxis)
        {
            return yaxis switch
            {
                var (X, Y) when X < Y => new YAxisMeasurement(-X, Y),
                var (X, Y) when X > Y => new YAxisMeasurement(X, -Y),
                var (X, Y) => new YAxisMeasurement(X, Y),
            }; 
        }
/*
        public static string Measures(YAxisMeasurement yaxis)
        {
            return yaxis switch
            {
                var (X, Y) when X < Y => new YAxisMeasurement(-X, Y),
                var (X, Y) when X > Y => new YAxisMeasurement(X, -Y),
                var (X, Y) => new YAxisMeasurement(X, Y),
            };
        }*/


        static void Main(string[] args)
        {
            Console.WriteLine(Measurement(new YAxisMeasurement(1, 2)));  // output: Point { X = -1, Y = 2 }
            Console.WriteLine(Measurement(new YAxisMeasurement(5, 2)));  // output: Point { X = 5, Y = -2 }


        }
    }
}
