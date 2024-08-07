using System;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace SwitchesExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number1 = 6;
            int number2 = 5;
            int number3 = 7;

            string username = "payet";
            string password = "12345";

            switch (username, password)
            {
                case ("user", "12345"):
                    Console.WriteLine($"user has been authenticated username:{username} and password:{password}");                
                    break;

                case ("admin", "admin") when username is not "Admin" or "Admins" && password is not "123":
                    Console.WriteLine($"admin has been authenticated username:{username} and password:{password}");
                    break;

                case var x when x.username.Length is 5 or 10 or 11 or 12 or 13 && x.password.Length is 5 or 6 or 7 or 8 or 9:
                    Console.WriteLine($"Dayet has been authenticated username:{username} and password:{password}");
                    break; 

                default:
                    throw new ArgumentException("invalid string characters"); 
            }   

            string checking = (number1, number2, number3) switch
            {
                ( >= 0 or <= 100, >= 0 or <= 100, >= 0 or <= 100) when
                number1 is not 50 || number2 is not 60 || number3 is not 10 
                => "this the blocks you may executed", 



            }; 

           int dayOfWeek = 3;
           string dayName = dayOfWeek switch
           {
               (>= 0 or <= 100) when dayOfWeek is not 50 or 60 or 70 || dayOfWeek is 20 or 30 or 40 => "Monday",
               2 => "Tuesday",
               3 => "Wednesday",
               4 => "Thursday",
               5 => "Friday",
               6 => "Saturday",
               7 => "Sunday",
               _ => "Invalid day" // Default case
           };

            Console.Write("Enter student grades:");

            int grade = Convert.ToInt32(Console.ReadLine());

            string checkgrades = grade switch
            {
                74 => $"retain failed with:{grade}",
                75 => $"passed but with:{grade}",
                76 => $"passed with:{grade}",
                80 => $"passed with:{grade}",
                86 => $"passed with:{grade}",
                90 => $"under honor with:{grade}",
                100 => $"CUM LAUDE Fake prof:{grade}",
                _ => $"invalid inputs"
            };

            //duplicated check grade switch expression statement
            string checkStudentGrades = grade switch
            {
                74 => $"retain failed with:{grade}",
                75 or <= 89 => $"passed with:{grade}",
                90 or <= 99 => $"under honor with:{grade}",
                100 => $"CUM LAUDE Fake prof:{grade}",
                _ => $"invalid inputs"
            }; 

            Console.WriteLine(checkStudentGrades);

            var switchValue = 4;


            var resultText = switchValue switch
            {
                var x when (x >= 1 && x <= 3) => "one to three",
                var e when
                   (e == 1 ||
                    e == 2 ||
                    e == 3 ) => "one, two, three",

                var y when(y >= 4 && y <= 6) => "four to six",
                _ => "unknown",
            };

            Console.WriteLine(resultText);


            /*    var switchValue1 = 3;
                var switch2 = switchValue1 switch
                {
                    >= 3 and <= 4 => "one, two, or three",
                    5 => "four",
                    6 => "five",
                    _ => "unknown",
                };

                Console.WriteLine(switch2);*/



            //example of switch statement 

            int score = 1000; 

            switch(score)
            {
                case var x when (x >= 200 && x <= 400): 
                    Console.WriteLine($"score is greater or equal /  less or equal to {score}");
                    break;
                case var x when (x >= 500 && x <= 1000):
                    Console.WriteLine($"you got highest score congrats! highest score:{score}");
                    break;
                case var x when (x >= 1000 && x <= 2000): 
                    Console.WriteLine($"you reach the master 1 score of:{score}");
                    break; 
                default:
                    throw new ArgumentOutOfRangeException("score did not match to the current condition"); 

            }

            var points = 200;

            var checkscore = points switch
            {
                <= 20 or <= 50 or not 200 => $"your score is less than or = to {score}",
                >= 50 or >= 100 or not 300 => $"your score is selected has of of the highest score:{score}",

            };

            Console.WriteLine(checkscore);

            var checkscores = Scores(points);
            var checkpoints = Points(points); 

            Console.WriteLine(checkscores);
            Console.WriteLine(checkpoints);
            Console.WriteLine(DescribeDay(10));

            var message = "current currencies from different countries";
            var amount = 100;
            var country = "USA";

            /*
                        Console.WriteLine(message);
                        Console.WriteLine(DifferentCountryCurrencies(amount, currency, country));
            */

            Console.WriteLine("The Top currency" + " using switch statement");
            Console.WriteLine(DifferentCountryCurrencies(100, "USA"));
            Console.WriteLine(DifferentCountryCurrencies(200, "Europe"));
            Console.WriteLine(DifferentCountryCurrencies(200, "London"));
            Console.WriteLine(DifferentCountryCurrencies(200, "Cotabato"));
            Console.WriteLine("==================================================");
            Console.WriteLine("The Top currency" + " using switch expression");
            Console.WriteLine(AccurateCurrency("dollars", 100));
            Console.WriteLine(AccurateCurrency("euros", 100));
            Console.WriteLine(AccurateCurrency("pounds", 100));
            Console.WriteLine(AccurateCurrency("Pesos", 100));


            Console.WriteLine(WeatherCondition("polopss", "Baguio", 23));


            Console.WriteLine(FindWeather(Countries.USA, statesofliberty.NewYork, 20));

            var switchs = 2;
            var result = switchs switch
            {   
                var x when x is ( 1 or 2 or 3) => "one to three",
                4 => "four",
                5 => "five",
                _ => "unknown",
            };

            Console.WriteLine(result);


            //switch statement

            var displayMeasurement = 8.53;
            
            switch (displayMeasurement)
            {
                case 2.05:
                case 4.95:
                case 3.09:
                    Console.WriteLine($"the measurement from 2.05, to 4.95, 3.09 and current condition is:{displayMeasurement}");  ;
                    break;
                case 6.54:
                    Console.WriteLine($"the measurement:{displayMeasurement}");
                    break;
                case 8.53:
                    Console.WriteLine($"highest measurement:{displayMeasurement}");
                    break;
                default:
                    throw new Exception("cannot find the measurement"); 
            }

            var value = 34.55;

            string measurement = value switch
            {
                var x when
                x is 1.32 ||
                x is 2.32 ||
                x is 3.32 ||
                x is 4.32 => $"the lowest measurement:{value}",
                10.00 => $"the highest measurement:{value}", 
                _ or 34.55 => $"Invalid number:{value}" // Default case
            };

            Console.WriteLine(measurement);

            var sonmoney = 300;
            var soncredits = 0;
            Console.WriteLine(CheckingCreditsAndBalance(sonmoney, soncredits));

            Console.WriteLine(BankAuthenticationLogin(UserIDs.user1, UserVerified.Anna));
            Console.WriteLine(BankAuthenticationLogin(UserIDs.user2, UserVerified.Kim));
            Console.WriteLine(BankAuthenticationLogin(UserIDs.user4, UserVerified.Oman));
            Console.WriteLine(BankAuthenticationLogin(UserIDs.user5, UserVerified.Omar));
            Console.WriteLine(BankAuthenticationLogin(UserIDs.user3, UserVerified.Omar));
        }


        public static string BankAuthenticationLogin(UserIDs userId, UserVerified verification)
            => (userId, verification) switch
            {
               (UserIDs.user1, UserVerified.Anna) => $"successfully login your accounts userId:{userId} and username:{verification}",
               (UserIDs.user2, UserVerified.Kim) => $"successfully login your accounts userId:{userId} and username:{verification}",
               (UserIDs.user4, UserVerified.Oman) => $"successfully login your accounts userId:{userId} and username:{verification}",
               (UserIDs.user5, UserVerified.Omar) => $"successfully login your accounts userId:{userId} and username:{verification}",
                _=> throw new ArgumentException($"cannot found information / you are not registered to our system")
            };

        public enum UserVerified
        { 
           Johns, 
           Chris, 
           Omar, 
           Kim, 
           Anna, 
           Oman, 
        }

        public enum UserIDs
        {
            user1 = 1111, 
            user2 = 2222, 
            user3 = 3333, 
            user4 = 4444,
            user5 = 5555
        }
  
    //example of switch expression using bodies expression and return expression =>
    public static string Scores(int score) => score switch
        { 
            var x when (x <= 20 || x == 40) => $"your score is less than or = to {score}",
            var x when (x == 100 || x == 200) => $"your score is selected has of of the highest score:{score}",
            _ => throw new ArgumentOutOfRangeException("is not in the ranges of score")
        };


        public static string Points(int score)
        {
            return score switch
            {
            var x when (x <= 20 || x == 40) => $"your score is less than or = to {score}",
            var x when (x == 100 || x == 200) => $"your score is selected has of of the highest score:{score}",
            _ => throw new ArgumentOutOfRangeException("is not in the ranges of score")
            };
        }

        public static string CheckingCreditsAndBalance(decimal balance, int credits)
        {
            switch (balance, credits)
            {
                case ( >= 0, < 1) when balance is >= 0 && credits is 0:
                    Console.WriteLine($"You are rich balance:{balance} and credits:{credits}");
                    break;

                default:
                    throw new ArgumentOutOfRangeException("idiots you're broke I'm gonna tell your mom for your credits");
            }

            return "well done men!!"; 
        }

        //quiz code switch statement from udemy course
        public static string DescribeDay(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return "Working day";
                case 6:
                case 7:
                    return "Weekend";
                default:
                    return "Invalid day number";

            }

        }

        //Last night homework 27/07/2024 8:12 PM
        public static string DifferentCountryCurrencies(int? amount, string? country)
        {
            switch (country)
            {
                case var currency when currency is "Dollar" or "dollar" || currency is "USA" || currency is "New York" || currency is "Washington" || currency is "Brooklyn":
                   
                    if (amount is null || amount is < -1)
                    {
                        throw new ArgumentOutOfRangeException("get out of range of number");
                    }
                    return $"${amount} dollars currency of {country}";

                case var currency when currency is "Pound" or "pound" || currency is "London" || currency is "Abbey Wood" || currency is "Acton" || currency is "Acton Greens":
                    
                    if (amount is null || amount is < -1)
                    {
                        throw new ArgumentOutOfRangeException("get out of range of number");
                    }
                    return $"£{amount} pounds currency of {country}";

                case var currency when currency is "Europe" or "europe" || currency is "Denmark" || currency is "Norway" || currency is "Slovenia" || currency is "North Macedonia":
                    
                    return $"€{amount} euros currency of {country}";

                case var currency when currency is "Peso" or "peso " || currency is "Manila" || currency is "Luzon" || currency is "Mindanao" || currency is "Cagayan" || currency is "Cotabato": 

                   if(amount is null || amount is < -1)
                    {
                        throw new ArgumentOutOfRangeException("out of any ranges"); 
                    }
                    return $"₱{amount} pesos currency of {country}";

                default:
                  
                    throw new ArgumentException("cannot be found the currency"); 
                    
            }    
            
        }

        //Last night homework 27/07/2024 8:12 PM
        public static string AccurateCurrency(string currency, int amount) 
            => currency switch
        {
            "dollar" or "dollars" or "Dollar" or "Dollars" => $"${amount} dollars",
            
            "euro" or "euros" or "Euro" or "Euros" => $"€{amount} euros", 

            "pound" or "pounds" or "Pound" or "Pounds" => $"£{amount} pounds",
            
            "peso" or "pesos" or "Peso" or "Pesos" => $"₱{amount} pesos",

            _=> throw new ArgumentException("invalid inputs or information cannot be found"),
        }; 

        public static string WeatherCondition(string countries, string states, double celciusdegree)
        {
            switch(countries)
            {
                case var country when country is "USA": 
                    return $"weather of {country} and states of {states} the current celcious degree is {celciusdegree}";
                case var country when country is "London":
                    return $"weather of {country} and states of {states} the current celcious degree is {celciusdegree}";
                case var country when country is "Europe":
                    return $"weather of {country} and states of {states} the current celcious degree is {celciusdegree}";
                case var country1 when country1 is "Philippines":
                case var country2 when states is "Baguio":
                    return $"weather of {countries} and states of {states} the current celcious degree is {celciusdegree}";    
                default:
                    throw new ArgumentException("out");

            }
        }

        public static string FindWeather(Countries countries, statesofliberty states, int celciusdegree)
            => (countries) switch
        {
            Countries.USA => $"The current weather in {countries} is {celciusdegree} state of {states}", 
            Countries.London => $"The current weather in {countries} is {celciusdegree} state of {states}",
            Countries.Europe => $"The current weather in {countries} is {celciusdegree}",
            Countries.Russia => $"The current weather in {countries} is {celciusdegree}",
            _=> throw new ArgumentException("cannot found the location weather"),

        }; 

        public enum Countries
        {
            USA, 
            London, 
            Europe, 
            Russia, 
            China, 
            Korea, 
            Philippines, 
        }

        public enum statesofliberty
        {
            NewYork, Brooklyn, Washington, California, LasVegas, 

        }

    }
}
