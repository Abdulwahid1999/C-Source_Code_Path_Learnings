using Microsoft.VisualBasic;

namespace Relational_Pattern
{
    public class Program
    {   

        static void Main(string[] args)
        {
            Console.WriteLine(Classify(13));  // output: Too high
            Console.WriteLine(Classify(double.NaN));  // output: Unknown
            Console.WriteLine(Classify(2.4));  // output: Acceptable
            Console.WriteLine(Classify(50));  // output: Acceptable

            Console.WriteLine(GetCalendarSeason(new DateTime(2021, 3, 14)));  // output: spring
            Console.WriteLine(GetCalendarSeason(new DateTime(2021, 7, 19)));  // output: summer
            Console.WriteLine(GetCalendarSeason(new DateTime(2021, 2, 17)));  // output: winter
            Console.WriteLine(GetCalendarSeason(new DateTime(2022, 9, 20)));  // output: winter

            var pickDate = new DateTime(2024, 3, 19);

            Console.WriteLine(GoalListStudyTopics(pickDate));

            Console.WriteLine(IsLetter('z'));

        }

        static bool IsLetter(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');
        static string Classify(double measurement) => measurement switch
        {
            >= 0 and < 5 => "Too low",
            >= 10.0 or > 20.0 => "Too high",
            double.NaN => "Unknown",
            _ => "Acceptable",  
        };

        static string GetCalendarSeason(DateTime date) => date.Month switch
        {
            >= 3 and < 6 => "spring",
            >= 6 and < 9 => "summer",
            >= 9 and < 12 => "autumn",
            12 or (>= 1 and < 3) => "winter",
            _ => throw new ArgumentOutOfRangeException(nameof(date), $"Date with unexpected month: {date.Month}."),
        };

        public static string GoalListStudyTopics(DateTime time) => time.Month switch
        {
             < 1 => $"Pre learning of C# language", 
             >= 1 and < 2 => $"studying the fundamentals of C#",
             >= 2 and < 3 => $"studying the object oriented programming", 
             >= 3 and < 4 => $"create a console project", 
             _=> throw new ArgumentNullException($"didn't include in the list of goal {nameof(time)}"),

        };


    }
}
