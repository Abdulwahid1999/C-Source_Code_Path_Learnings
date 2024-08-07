using System.Security.Cryptography.X509Certificates;

namespace Positional_Pattern
{
    public class Program
    {

        //positional pattern with class and properties 
        public int IdPassenger {  get; set; }   
        public string Name { get; set; }
        public string Country { get; set; } 
        public string State { get; set; }
        public string City { get; set; }

        public Program(int idPassenger, string name, string country, string state)
            => (IdPassenger, Name, Country, State) = (idPassenger, name, country, state);
        public void Deconstruct(out int idPassenger, out string name, out string country, out string state, out string city)
            => (idPassenger, name, country, state, city) = (IdPassenger, Name, Country, State, City); 
       
        //positional pattern with record type
        public record HighSchoolRecordGrades(string name, int grade);
        public record SeniorHighSchoolRecordGrades(string name, int age);
        public static string EvaluationForm(HighSchoolRecordGrades student) => student switch
        {
            ("Dayet", 75) => $" future sofware engineer graduate", 
            ("Echo", 76) => $" future Nurse of the lamion", 
            ("Kusung", 78) => " future tehh latto", 
            ("Moymoy", 80) => " future tehh bahay ni Nur",
            _ => throw new ArgumentException("does not meet the condition"),
        }; 

        public static string EvaluationGrades(Object obj)
        {
            return obj switch
            {
                HighSchoolRecordGrades("Dayet", 75) status => $"name is {obj} and from:Sibutu",
                SeniorHighSchoolRecordGrades("Brayan", 76) => $"name is {obj} and from:Sibutu",
                _ => throw new ArgumentException("does not meet the conditions")
            };  
        }

        static void Main(string[] args)
        {
            //poisitional pattern with record type
            var studentGrades = new HighSchoolRecordGrades("Brayan", 76);
            var evaluation = EvaluationForm(studentGrades);
            var evaluationGrades = EvaluationGrades(studentGrades); 

            Console.WriteLine(evaluation);
            Console.WriteLine(evaluationGrades);


            //Positional Pattern 
            var dayweek = new DateTime(2022, 4, 15);

            Console.WriteLine(GetGroupTicketPriceDiscount(1, dayweek));


            //passengerAuthentication usign postional pattern
            var passenger = new Program(0101, "Dayet1", "Norway", "Lubrika");
            var passenger2 = new Program(1111, "Brayan", "London", "Chanel");
            var passenger3 = new Program(2222, "Chris", "Brazil", "Utchuna"); 
            var passenger4 = new Program(3333, "Chan", "Russia", "Katsan"); 

            var authenticatedPassenger = PassengerAuthentication(passenger); 

            Console.WriteLine(authenticatedPassenger);

 
        }

        public static string PassengerAuthentication(Program passenger) => passenger switch
        {
            (0101, "Dayet", "Norway", _,_) pass => $"passenger from {pass.Country} name of passenger:{pass.Name}",
            (_, "Brayan", "London", "Chanel", _) pass => $"passenger from {pass.Country} state:{pass.State} name of passenger:{pass.Name}", 
            (_, _, "Brazil", _, _) pass => $"passenger from {pass.Country} name of passenger:{pass.Name}",
            (3333, "Chan", "Russia", _, _) pass => $"passenger from {pass.Country} name of passenger:{pass.Name}",
            _=> throw new ArgumentNullException(nameof(passenger))
        }; 
        //you can also extend a positional pattern in any of the following ways. 
        public record Point2D(int X, int Y);
        public record Point3D(int X, int Y, int Z);

        static string PrintIfAllCoordinatesArePositive(object point) => point switch
        {
            Point2D(> 0, > 0) p => p.ToString(),
            Point3D(> 0, > 0, > 0) p => p.ToString(),
            _ => string.Empty,
        };
/*
        static string Authorize(Code code) => code switch
        {
            (0, 0) => throw new ArgumentOutOfRangeException("invalid code"),
            (11111, 22222) c => $"valid code you can use now for XCODE:{c.xcode} and YCODE:{c.ycode}",
            (_, 44444) c => $"valid code you can use now for XCODE:{c.xcode} and YCODE:{c.ycode}",
            _ => throw new ArgumentNullException("cannot be null"),
        };
*/
        //Tuple Pattern
        static decimal GetGroupTicketPriceDiscount(int groupSize, DateTime visitDate)
         => (groupSize, visitDate.DayOfWeek) switch
         {
             ( <= 0, _) => throw new ArgumentException("Group size must be positive."),
             (_, DayOfWeek.Saturday or DayOfWeek.Sunday) => 0.0m,
             ( >= 5 and < 10, DayOfWeek.Monday) => 20.0m,
             ( >= 10, DayOfWeek.Monday) => 30.0m,
             ( >= 5 and < 10, _) => 12.0m,
             ( >= 10, _) => 15.0m,
             _ => 0.0m,
         };
    }
}
