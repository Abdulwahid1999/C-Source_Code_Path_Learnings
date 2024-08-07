using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Pattern_Matching
{

    public abstract class Vehicle { }
    public class Car : Vehicle { }
    public class Truck : Vehicle { }

    public class PickUp : Vehicle { }

    public class Van : Vehicle { }

    public static class TollCalculator
    {
        public static decimal CalculateTollDiscardPattern(this Vehicle? vehicle) => vehicle switch
        {
            Car _ => 2.00m,
            Truck _ => 7.50m,
            null => throw new ArgumentNullException(nameof(vehicle)),
            _ => throw new ArgumentException("Unknown type of a vehicle", nameof(vehicle)),
        };
        public static decimal CalculateTollTypePattern(this Vehicle vehicle) => vehicle switch
        {
            Car => 2.00m,
            Truck => 7.50m,
            null => throw new ArgumentNullException(nameof(vehicle)),
            _ => throw new ArgumentException("Unknown type of a vehicle", nameof(vehicle)),
        };

        public static string DescribeType(object obj) => obj switch
        {
            int _ => $"Integer with value {obj}",
            string _ => $"String with value \"{obj}\"",
            bool _ => $"Boolean with value {obj}",
            Array _ => $"Array with value {obj}",
            null => "Null value",
            _ => "Unknown type"
        };

        public static string CarOwnerCheck(Object type) => type switch
        {
            Car Suzuki1999 => $"{ProcessInformation("Dayet")} car model:Suzuki1999",
            Truck ToyotaG200 => $"{ProcessInformation("Poyet")} car model:ToyotaG200",
            PickUp RaptorS100 => $"{ProcessInformation("Mayet")} car model:RaptorS100",
            _=> throw new ArgumentException("cannot found the model of vehicles"),

        }; 

        public static string ProcessInformation(string name)
        {
            return $"name is:{ListInformation(name)}" ?? throw new ArgumentException("information empty found"); 
        }

        public static string ListInformation(string ownerName)
        {
            switch (ownerName)
            {
                case "Dayet":
                    return "Dayet";
                case "Poyet":
                    return "Poyet";
                case "Payet":
                    return "Payet";
                case "Mayet":
                    return "Mayet";
                default:
                    throw new ArgumentException("Information cannot be found");  
            }
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {   

            //boxing and unboxing during run time checking using if else statement from chatGPT
            decimal? xNullable = 7;
            decimal y = 23;
            object yBoxed = y; 
            object xBoxed = xNullable; 
            if (xBoxed is decimal a && yBoxed is decimal b)
            {
                Console.WriteLine(a + b);  // output: 30
            }

            var hilux = new PickUp();
            var toyota = new Truck();

            Console.WriteLine(TollCalculator.CalculateTollDiscardPattern(new Truck()));
            Console.WriteLine(TollCalculator.CalculateTollDiscardPattern(new Car()));

            //Type Pattern matching using switch expression from chatGPT
            List<int> listofitem = [1, 2, 3, 4,];
            string[] userData = ["dayet", "poyet", "mayet", "anwar"];
            int[] contactNumber = [0923555, 09442223, 09343434, 09343434];
            
            Console.WriteLine(TollCalculator.DescribeType(listofitem));
            Console.WriteLine(TollCalculator.DescribeType(userData));
            Console.WriteLine(TollCalculator.DescribeType(contactNumber));


            //Declaration pattern matching using switch expression 
            var ToyotaG200 = new Truck();
            var RaptorS100 = new PickUp();
            var Suzuki1999 = new Car();
            var AvanzaS200 = new Van(); 
            Console.WriteLine(TollCalculator.CarOwnerCheck(Suzuki1999));
            
            //Declaration pattern matching using switch expression 
            object greeting = "Hello, World!";
            if (greeting is string message)
            {
                Console.WriteLine(message);  // output: hello, world!
            }
            else
            {
                throw new ArgumentException("its not a integer type");
            }

            Console.Write("enter your tracking#:");
            string trackingNumber = Console.ReadLine(); 


            //constant pattern using switch expression
            var checkTrackingNumber = trackingNumber switch
            {
                "NINJA100" => $"your package still in China", 
                "NINJA200" => $"your package still in Cebu City", 
                "NINJA300" => $"your package still in Davao City", 
                "NINJA400" => $"your package still in Laguna City", 
                _=> throw new ArgumentException("tracking number is invalid"), 

            };

            Console.WriteLine(checkTrackingNumber);


            //Type Pattern Matching using switch statement
            object undefinedTypes = 300;

            var typePattern = undefinedTypes;

            switch (typePattern)
            {
                case int i:
                    Console.WriteLine($"it is an {i.GetType()}:{i}");
                    break;
                case string s:
                    Console.WriteLine($"it is an {s.GetType()}:{s}");
                    break;
                case char c:
                    Console.WriteLine($"it is an {c.GetType()}:{c}");
                    break;
                case float f:
                    Console.WriteLine($"it is an {f.GetType()}:{f}");
                    break;
                case double d:
                    Console.WriteLine($"it is an {d.GetType()}:{d}");
                    break;
                case decimal m:
                    Console.WriteLine($"it is an {m.GetType()}:{m}");
                    break;
                default:
                    throw new ArgumentException("unknown types");

            }

            //declaration pattern in c#
            if (undefinedTypes is int integers)
            {
                Console.WriteLine($"its a integer:{integers}");
            }
            else if (undefinedTypes is float single)
            {
                Console.WriteLine($"its a float single point decimal:{single}");
            }
            else if (undefinedTypes is double doubles)
            {
                Console.WriteLine($"its a double point decimal:{doubles}");
            }
            else if(undefinedTypes is decimal decimals)
            {
                Console.WriteLine($"its a decimal:{decimals}");
            }
            else if(undefinedTypes is char characters)
            {
                Console.WriteLine($"its a char:{characters}");
            }
            else
            {
                Console.WriteLine("unknown types");
            }

            const int expression = 4; 
            Console.WriteLine(GetGroupTicketPrice(expression));

            Console.WriteLine(Classify(13));  // output: Too high
            Console.WriteLine(Classify(double.NaN));  // output: Unknown
            Console.WriteLine(Classify(2.4));  // output: Acceptable


        }

        //constant pattern matching using switch expression 
        public static decimal GetGroupTicketPrice(int visitorCount) => visitorCount switch
        {
            1 => 12.0m,
            2 => 20.0m,
            3 => 27.0m,
            4 => 32.0m,
            0 => 0.0m,
            _ => throw new ArgumentException($"Not supported number of visitors: {visitorCount}", nameof(visitorCount)),
        };

        //relation pattern matching using switch expression 
        static string Classify(double measurement) => measurement switch
        {
            < -4.0 => "Too low",
            > 10.0 => "Too high",
            double.NaN => "Unknown",
            _ => "Acceptable",
        };
    }
}
