using System.Reflection.Metadata.Ecma335;

namespace PropertyPattern
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel HomeAddress { get; set; } = new AddressModel();
    }
   public class AddressModel
    {
        public string Country { get; set; }
        public string State { get; set;}
    }
    public class Program
    {

        private int idAccount;
        private string accountName;
        private string pinNumber; 

        public int IdAccount
        {
            get { return idAccount; }
            init{}
        }

        public string AccountName
        {
            get { return accountName; }
            set { value = AccountName; }
        }

        public string PinNumber
        {
            get { return pinNumber; }
            set { pinNumber = value; }
        }

        public enum RegisteredPinNumber
        {
            PinNumber1 = 111111, 
            PinNumber2 = 222222,
            PinNumber3 = 333333,
            PinNumber4 = 444444,
            PinNumber5 = 555555,
            PinNumber6 = 666666,
            PinNumber7 = 777777,
            PinNumber8 = 888888,
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TakeFive("Hello, world!"));  // output: Hello
            Console.WriteLine(TakeFive("Hi!"));  // output: Hi!
            Console.WriteLine(TakeFive(new[] { '1', '2', '3', '4', '5', '6', '7' }));  // output: 12345
            Console.WriteLine(TakeFive(new[] { 'a', 'b', 'c' }));  // output: abc

            Console.WriteLine(IsConferenceDay(new DateTime(2020, 5, 21)));

            Console.WriteLine(VerifyBankAccounts(RegisteredPinNumber.PinNumber1, VerifiedAccount.Anwar, new DateTime(2022, 4, 2)));
            Console.WriteLine(VerifyBankAccounts(RegisteredPinNumber.PinNumber2, VerifiedAccount.Menner, new DateTime(2022, 5, 3)));
            Console.WriteLine(VerifyBankAccounts(RegisteredPinNumber.PinNumber3, VerifiedAccount.Brown, new DateTime(2022, 3, 4)));
            Console.WriteLine(VerifyBankAccounts(RegisteredPinNumber.PinNumber4, VerifiedAccount.Jacob, new DateTime(2012, 3, 4)));


            var personel = new PersonModel()
            {
                FirstName = "Dayet",
                HomeAddress = new AddressModel()
                {
                    Country = "Norway", 
                }

            }; 
            
            var precentageExchange = 100;
            var dateOfPurchased = new DateTime(2022, 1, 16);

            Console.WriteLine($"successfully purchase the promo plane:%{PromoPlane(personel, precentageExchange, dateOfPurchased)} date issue:{dateOfPurchased}");

        }

        public record Status (string name, string status, string occupation);

        public static double PromoPlane(PersonModel passengerName, int exchange, DateTime dateToPurchased) => (passengerName, dateToPurchased.Month) switch
        {
            ({ FirstName: "Dayet", HomeAddress.Country: "Norway"}, <= 1 ) => exchange - 50,
            ({ FirstName: "Chris", HomeAddress.Country: "London" }, <= 2)=> exchange - 50,
            ({ FirstName: "Megan", HomeAddress.Country: "Philippines"}, <= 3) => exchange - 60,
            ({ FirstName: "Omen" , HomeAddress.Country: "Saudi"}, <= 4) => exchange - 70,
            ({ FirstName: "Lol", HomeAddress.Country: "Nigeria"}, <= 5) => throw new ArgumentException("your promo plane has expired"), 
            _=> throw new ArgumentNullException(nameof(passengerName), nameof(dateToPurchased)),
           
        }; 

        
        static string VerifyBankAccounts(RegisteredPinNumber pins, VerifiedAccount verified, DateTime verifiedDate) =>
            (pins, verified, verifiedDate) switch
            {
                (RegisteredPinNumber.PinNumber1, VerifiedAccount.Anwar, DateTime(2022, 4, 2)) => $"account were issues during:{verifiedDate} and the account name:{verified}",
                (RegisteredPinNumber.PinNumber2, VerifiedAccount.Menner, DateTime(2022, 5, 3)) => $"account were issues during:{verifiedDate} and the account name:{verified}",
                (RegisteredPinNumber.PinNumber3, VerifiedAccount.Brown, DateTime(2022, 3, 4)) => $"account were issues during:{verifiedDate} and the account name:{verified}",
                (RegisteredPinNumber.PinNumber4, VerifiedAccount.Jacob, DateTime(2012, 3, 4)) => $"account were issues during:{verifiedDate} and the account name:{verified}",
                (RegisteredPinNumber.PinNumber5, VerifiedAccount.Chris, DateTime(2013, 12, 4)) => $"account were issues during:{verifiedDate} and the account name:{verified}",
                _ => throw new ArgumentOutOfRangeException(nameof(pins), nameof(verified), nameof(verifiedDate)),
              
            };

        
        public enum VerifiedAccount
        {
            Chris, 
            Jacob, 
            Anwar,
            Brown, 
            Menner,

        }
        static bool IsConferenceDay(DateTime date) => date is { Year: 2020, Month: 5, Day: 19 or 20 or 21 };
        static string TakeFive(object input) => input switch
        {
            string { Length: >= 5 } s => s.Substring(0, 5),
            string s => s,

            ICollection<char> { Count: >= 7 } symbols => new string(symbols.ToArray()),
            ICollection<char> symbols => new string(symbols.ToArray()),

            null => throw new ArgumentNullException(nameof(input)),
            _ => throw new ArgumentException("Not supported input type."),
        };

        public record Point(int X, int Y);
        public record Segment(Point Start, Point End);

        static bool IsAnyEndOnXAxis(Segment segment)  =>
            segment is { Start: { Y: 0 } } or { End: { Y: 0 } };

        static bool IsAnyEndOnXAxiss(Segment segment) =>
            segment is { Start.Y: 0 } or { End.Y: 0 };

    }


}
