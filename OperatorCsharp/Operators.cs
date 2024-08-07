using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace OperatorCsharp
{
    public class Operators
    {
        [CreditCard]
        private decimal? creditCard;
        private string? username;
        private string? password; 
        public decimal? CreditCardNumber
        {   get { return creditCard /*?? throw new NullReferenceException()*/; }
            set { if(creditCard is 16)
                {
                    if(creditCard == null)
                    {
                        Console.WriteLine("credit card is null");
                    }
                    creditCard = value; 
                };
            }
        }

        public string? Username 
        { 
            get { return username; }
            set { if(username?.Length <= 10)
                {
                    if(username == null)
                    {
                        Console.WriteLine("username is empty");
                    }

                    username = value;

                }
                }
        }

        public string? Password
        {
            get { return password; }
            init { password = value; }
        }
        public int EmployeId { get; set; }

        [MaxLength(20), MinLength(10)]
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Description { get; set; }
        public string? Addresses { get; set; }

        public string Description1 { get; set; }

        public readonly int value1;
        public readonly int value2; 

        public decimal CreditCardNumbers(decimal? creditCardNumber)
        {
            CreditCardNumber = creditCardNumber;

            return CreditCardNumber ?? throw new NullReferenceException();

        }
        public static bool SecondOperand()
        {
            Console.WriteLine("Second operand is evaluated");

            return false;
        }

        public decimal RemainderNumbers(decimal? a, decimal? b)
        {
            var remainder = a % b;

            return remainder ?? throw new Exception();
        }

        public int MultiplyNumbers(int? value1, int? value2)
        {
            var multiply = value1 * value2;

            return multiply ?? throw new NullReferenceException();
        }

        public double DivideNumbers(double value1, double value2)
        {
            var divide = value1 / value2;

            return divide;
        }
        public int RemainderNumbers(int value1, int value2)
        {
            var remainder = value1 % value2;

            return remainder;
        }

        public int AddNumbers(int value1, int value2)
        {
            var sum = value1 + value2;

            return sum;
        }

        public int SubstractNumbers(int value1, int value2)
        {
            var substruct = value1 - value2;

            return substruct;
        }

        public int ArrayElements(int?[] arrays)
        {
            for (int i = 0; i < arrays?.Length; i++)
            {
                Console.WriteLine($"array elements[]{i}");
            }
            return arrays?.Length ?? throw new NullReferenceException();
        }

        public string FacebookUsers(string[]? users)
        {
            string message = "Total count of the facebook:";

            for (int i = 0; i < users?.Length; i++)
            {
                Console.WriteLine($"facebook account ID:{i}");
            }
            return message + users?.Length ?? throw new NullReferenceException();
        }

        public int ConvertToInt32(double doubles)
        {
            return Convert.ToInt32((int)doubles);
        }

        public static void DisplayResult(string message)
        {
            Console.WriteLine(message);
        }


        public static string DisplayName(string? name)
        {
            return name ?? throw new Exception();

        }

        public void Display(string message) => Console.WriteLine(message);

        public static int SumNumbers(int value1, int value2) => value1 + value2;

    /*    public int RefactorSum(int a, int b)
        {
            value1 = a;
            value2 = b;

            var sum = a + b;

            if (sum >= 0)
            {
                return sum;
            }
            return -sum;
        }*/

        public int ListElements(int[] arr)
        {
            int counts = 0; 
            int[] arrays = arr;

            for (int list = 0; list <= 10; list++)
            {
              Console.WriteLine($"{list} elements");   
            }
            return arrays.Length;  
        }

        public string ListFoods(string[] foods)
        {
            string message = "list of orders"; 
            string[] listFoods = foods;

            foreach(string food in listFoods)
            {
                Console.WriteLine($"{food} list foods");
            }

            return message; 
        }

        public int ListIndex(List<int> index)
        {
            var indexs = index;
            foreach(int list in indexs)
            {
                /* Console.WriteLine($"{index[i]} index"); */
                Console.WriteLine($"{list} index");
            }

            return indexs.Count;
        }

        public string CreditsGuards(in string? creditNumbers)
        {
            var authentication = (creditNumbers?.Length is 16) /*& (creditNumbers >= 16)*/
                ? "access granted" : "access denied ";

            if(creditNumbers is "access denied")
            {
                return authentication.Length.ToString("try again later"); 
            }

            return authentication;
            
        }

        public string CreditsGuards2(string? creditNumbers)
        {
            string? digits = creditNumbers;
            if (digits?.Length is 16)
            {
                return digits.Length.ToString("access granted");
            }
            
            return digits?.Length.ToString("access denied") ?? throw new Exception();

        }

        public string Authentication(string username, string password)
        {
            var authentication = (username.Length <= 16 && password.Length <= 16)
                               && (username.Length is not 17 && password.Length is not 17)
                               ? "length is fine" : "exceed the limit of username and password";

            return $"{authentication}";  
        }

        public string Authorized(string username, string password)
        {
            if (username is "Dayet" && password is "Dayet")
            {
                Console.WriteLine("Login success");
            }
            else
            {
                return ("incorrect username or password");
            }

            return $"Username:{username} Password:{password}";
        }

        public List<string> FoodList(List<int> listRecipe)
        { 
           return new List<string>();
        }
        
    }
}
