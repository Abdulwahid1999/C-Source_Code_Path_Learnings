// See https://aka.ms/new-console-template for more information


//logical operators
/*var person = new Operators();

bool b = false & Operators.SecondOperand();
Console.WriteLine(b);
// Output:
// Second operand is evaluated.
// True

bool d = false && Operators.SecondOperand();

Console.WriteLine(d);

bool c = true | true;
Console.WriteLine(c);

bool j = true || Operators.SecondOperand();
Console.WriteLine(j);1

int? compare = 30; 

if(compare is not null)
{
    Console.WriteLine($"compare is not null:{compare}");
}
*/

//bitwise operators
/*
uint initial_Value = 0b_0000_1111;

uint a = initial_Value;
a &= 0b_1001_1101;
Display(a);  // output: 10011000

a = initial_Value;
a |= 0b_0011_0001;
Display(a);  // output: 11111001

a = initial_Value;
a ^= 0b_1000_0000;
Display(a);  // output: 01111000

a = initial_Value;
a <<=10;
Display(a);  // output: 1111100000

a = initial_Value;
a >>= 5;
Display(a);  // output: 00001111

a = initial_Value;
a >>>= 4;
Display(a);  // output: 00001111

void Display(uint x) => Console.WriteLine($"{Convert.ToString(x, toBase: 2).PadLeft(8, '0'),8*//*}");*/

//#1 bitwise operator 

//reference equality and inequality
/*public class ReferenceTypesEquality
{
    public class MyClass
    {
        private int id;
        public MyClass(int id) => this.id = id;
    }

    public static void Main()
    {
        var a = new MyClass(1);
        var b = new MyClass(1);
        var c = a;
        Console.WriteLine(ReferenceEquals(a,b));  // output: False
        Console.WriteLine(ReferenceEquals(a,c));  // output: True
    }
}*/


//record equality
/*public class RecordTypesEquality
{
    public record Point(int X, int Y, string Name);
    public record TaggedNumber(int Number, List<string> Tags);

    public static void Main()
    {
        var p1 = new Point(2, 3, "A");
        var p2 = new Point(2, 3, "A");
        var p3 = new Point(2, 3, "A");
        var p4 = new Point(2, 3, "A");

        Console.WriteLine(p1 == p2);  // output: False
        Console.WriteLine(p1 == p3);  // output: True
        Console.WriteLine(p1 == p4);  // output: True

        var n1 = new TaggedNumber(2, new List<string>() { "A" });
        var n2 = new TaggedNumber(2, new List<string>() { "A" });
        Console.WriteLine(n1 == n2);  // output: False


    }
}*/

//string equality
/*
string s1 = "hello!";
string s2 = "HeLLo!";
Console.WriteLine(s1 == s2.ToLower());  // output: True

string s3 = "Hello!";
Console.WriteLine(s1 == s3.ToLower());  // output: Falses
*/



/*var sumTwoNumbers = new Operators();
var substructNumber = new Operators();
var multiplyNumber = new Operators();
var divideNumber = new Operators();
var remainderNumber = new Operators();


Console.Write("enter value1 : ");
int enterValue1 = Convert.ToInt32(Console.ReadLine());

Console.Write("enter value2 : ");
int enterValue2 = Convert.ToInt32(Console.ReadLine());


if (enterValue1 == enterValue1 && enterValue2 == enterValue2)
{
    multiplyNumber.MultiplyNumbers(enterValue1, enterValue2);
    divideNumber.DivideNumbers(enterValue1, enterValue2);
    remainderNumber.RemainderNumbers(enterValue1, enterValue2);
    sumTwoNumbers.AddNumbers(enterValue1, enterValue2);
    substructNumber.SubstractNumbers(enterValue1, enterValue2);
}
else
{
    Console.WriteLine("error cannot perform any operations");
}

//operation of EQUALITY an INEQUALITY
if (enterValue1 == enterValue1 && enterValue2 == enterValue2)
{
    var equality1 = enterValue1 == enterValue1;
    var equality2 = enterValue2 == 20;

    Console.WriteLine($"the operation of EQUALITY == {equality1} {equality2}");

}

if (enterValue1 != 20 && enterValue2 != 30)
{
    var inequality = enterValue1 != enterValue2;

    Console.WriteLine($"the operation of INEQUALITY != {inequality}");
}
*/

//Logical Operation !, & AND, ^ XOR, OR |, && AND, || OR

//conditional logical AND 
/*int? value1 = 2;
int? value2 = 3;*/

/*if (value1 is 3 && value2 is 3)
{
    Console.WriteLine($"value1:{value1} and value2:{value2}");
}
if (value1 is 2 && value2 is 2)
{
    Console.WriteLine($"value1:{value1} and value2:{value2}");
}
if (value1 is 1 && value2 is 1)
{
    Console.WriteLine($"value1:{value1} and value2:{value2}");
}
if (value1 == null && value2 == null)
{
    Console.WriteLine($"value1:{value1} and value2:{value2}");
}
else
{
    Console.WriteLine("condition cannot be found");
}
*/

//conditional logical operator OR 

/*if (value1 is 3 || value2 is 3)
{
    Console.WriteLine($"value1:{value1} and value2:{value2}");
}
if (value1 is 2 || value2 is 3)
{
    Console.WriteLine($"value1:{value1} and value2:{value2}");
}
if (value1 is 3 || value2 is 1)
{
    Console.WriteLine($"value1:{value1} and value2:{value2}");
}
if (value1 == null || value2 == 3)
{
    Console.WriteLine($"value1:{value1} and value2:{value2}");
}
else
{
    Console.WriteLine("condition cannot be found");
}*/

/*bool isLoginTrue = true;

bool isNotFalse = !isLoginTrue;

Console.WriteLine("is not false : " + isNotFalse);

if (!isLoginTrue)
{
    Console.WriteLine("Logical Negation ! operator " + isLoginTrue);
}
else if (isLoginTrue)
{
    Console.WriteLine($"Logical negation is {isLoginTrue}");
}
*/
//Logical &, |, ^
/*if(value1 is 3 & value2 is 3)
{
    Console.WriteLine("Logical AND operator " + value1 + value2);
}
if(value1 is 1 | value2 is 1)
{
    Console.WriteLine("Logical OR operator | " + value1 + value2);
}
if(value1 is 3 ^ value2 is 3)
{
    Console.WriteLine("logical XOR operator " + value1 + value2);
}
else if(value1 is 2 ^ value2 is 3)
{
    Console.WriteLine("logical XOR operator ");
}*/


//comparison operators
/*
int number1 = 200;
int number2 = 100; 

if(number1 < number2)
{
    Console.WriteLine($"number1 is less than number2");
}
else if(number1 > number2)
{
    Console.WriteLine($"number1 is greater than number2");
}    
else if(number1 <= number2)
{
    Console.WriteLine("number 1 is <, OR = to number2");
}
else if(number1 >= number2)
{
    Console.WriteLine("number 1 is >, OR = to number2");
}
else
{
    Console.WriteLine("condition didn't meet in 4 conditions");
}
Console.ReadKey();*/


//member access operators, dot, square brackets[], parethesis()

/*
var mathematics = new Operators();

int value1 = 20;
int value2 = 10;  

mathematics?.MultiplyNumbers(value1, value2);
mathematics?.DivideNumbers(value1, value2);
mathematics?.RemainderNumbers(value1, value2);
mathematics?.AddNumbers(value1, value2);
mathematics?.SubstractNumbers(value1, value2);


int?[] arrays = new int?[20];
string[] facebookUsersID = new string[100];
decimal card = 3434_3434_555_555; 

Console.WriteLine($"multiply by right hand operands : {mathematics?.MultiplyNumbers(value1, value2)}");
Console.WriteLine($"integer arrays element : {mathematics?.ArrayElements(arrays)}");
Console.WriteLine($"{mathematics?.FacebookUsers(facebookUsersID)}");

Console.WriteLine($"credit card:{mathematics?.CreditCardNumbers(card)}");*/



//Array collection using Collection Expressions C#12
/*int[] collectionNumbers = [1, 2, 3, 4, 5];

var findLowest = collectionNumbers.Min();
var findHighest = collectionNumbers.Max();

if (findLowest.Equals(findLowest))
{
    Console.WriteLine($"lowest number from collection numbers:{findLowest}");
    Console.WriteLine("iterate this");

    foreach (var find in collectionNumbers)
    {
        Console.WriteLine($"collection items:{find}");

    }
}

if (findHighest.Equals(findHighest))
{
    Console.WriteLine($"highest number from collection numbers:{findHighest}");

    foreach (var find in collectionNumbers.Reverse())
    {
        Console.WriteLine($"collection items:{find}");
    }
}
*/

//is expression
/*int i = 23;
object iBoxed = i;
int? jNullable = 7;
if (iBoxed is int a && jNullable is int b)
{
    Console.WriteLine(a + b);  // output 30
}

double x = 123.5;
int numb = (int)x;

string numbers = Convert.ToString(numb);

Console.WriteLine("converted:"+ numbers);

numbers += "i converted this current variable to string type using conversation type casting";

Console.WriteLine($"converted:{numbers}");
*/
//Arithmetic operators
/*
var result = new Operators();

Console.WriteLine("==== Arithmetic Operations ====\n" + " 1.Addition '+'\n 2.Substraction'-'\n 3.Multiplication'*'\n 4.Division'/'\n 5.Remainders'%'\n");
Console.Write("choose above:");
int choices = Convert.ToInt32(Console.ReadLine());

switch (choices)
{
    case 1:
        Console.Write("enter1:");
        var number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter2:");
        var number2 = Convert.ToInt32(Console.ReadLine());

        result.DisplayResult($"Addition:{result.AddNumbers(number1, number2)}");
        break;

    case 2:
        Console.Write("enter1:");
        var sub1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter2:"); 
        var sub2 = Convert.ToInt32(Console.ReadLine()); 

        result.DisplayResult($"Substraction:{result.SubstractNumbers(sub1, sub2)}");
        break;

    case 3:
        Console.Write("enter1:");
        var multiply1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter2:");
        var multiply2 = Convert.ToInt32(Console.ReadLine());

        result.DisplayResult($"Multiplication:{result.MultiplyNumbers(multiply1, multiply2)}");
        break;

    case 4:
        Console.Write("enter1:");
        var division1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("enter2:");
        var division2 = Convert.ToDouble(Console.ReadLine()); 

        result.DisplayResult($"Division:{result.DivideNumbers(division1, division2)}"); 
        break;

    case 5:
        Console.Write("enter1:");
        var remainder1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("enter2:");
        var remainder2 = Convert.ToDecimal(Console.ReadLine());

        result.DisplayResult($"Division:{result.RemainderNumbers(remainder1, remainder2)}");
        break;

    default:
        Console.WriteLine("current unavailable operations");
        break;

}*/

var value1 = 22;
var value2 = 10;


var accessTypes = new OperatorCsharp.Operators();

accessTypes.Name = "dayet";
accessTypes.Age = 10;
accessTypes.Addresses = "housing";
accessTypes.Description1 = "i like coding";

Console.WriteLine($"{accessTypes.Name}, {accessTypes.Age}, {accessTypes.Addresses}, {accessTypes.Description1}");

var operators = new OperatorCsharp.Operators();

Console.WriteLine(operators.AddNumbers(value1, value2));
Console.WriteLine(operators.SubstractNumbers(value1, value2));
Console.WriteLine(operators.MultiplyNumbers(value1, value2));
Console.WriteLine(operators.DivideNumbers(value1, value2));
Console.WriteLine(operators.RemainderNumbers(value1, value2));

var Personel1 = new OperatorCsharp.Operators();

Personel1.Name = "James";
Personel1.Age = 24;
Personel1.Addresses = "GNA";
Personel1.Description = "coing coding coding";


if (Personel1.Name is "dayet" && Personel1.Age is 25 && Personel1.Addresses is "housing" && Personel1.Description is "i like coding")
{
    Console.WriteLine($"successfully evaluated the information name:{Personel1.Name}");
}
else if (Personel1.Name is "James" && Personel1.Age is 24 && Personel1.Addresses is "GNA" && Personel1.Description is "coing coding coding")
{
    Console.WriteLine($"successfully evaluate the information\n name:{Personel1.Name} address:{Personel1.Addresses} description:{Personel1.Description}");
}
else
{
    Console.WriteLine("failed to initialized the objects");
}

var Personel2 = new OperatorCsharp.Operators();

var personel2 = Personel1.Name = "Mark";

Console.WriteLine(ReferenceEquals(Personel2, Personel1));
if (ReferenceEquals(Personel2.Name, Personel1.Name))
{
    Console.WriteLine("they are equals");
}

var employee = new OperatorCsharp.Operators
{
    Name = "dayet",
    Addresses = "housing",
    Age = 25

};

int speed = 100;

string username = "boyet1";
string password = "boyet1";

var authentication = (username is "dayet" && password is "dayet")
    || (username is "boyet" && password is "boyet")
    ? "correct username and password" : "incorrect username and password";

Console.WriteLine(authentication);


string name = "abduwlahid";


//Lambda Expression
/*int[] numbers = {2, 3, 4, 5 };
var squaredNumbers = numbers.Select(x => x * x);
Console.WriteLine(string.Join(" ", squaredNumbers));*/
// Output:
// 4 9 16 25

//Lambda Statement
/*Action<string> greet = name =>
{
    string greeting = $"Hello {name}!";
    string address = $"Housing {name}";
    Console.WriteLine(greeting, address);
};
greet("World");*/
// Output:
// Hello World!

//lambda expression with default value
/*var sum = (int source, int increment = 1) => source + increment;

Console.WriteLine(sum(default)); // 6
Console.WriteLine(sum(5, 2)); // 7*/


//lamda expression sample 1
/*Console.WriteLine(Operators.SumNumbers(20, 30));*/

//lamda expressin sample 2


//Method passing arguments with other methods
/*int number1 = 20;
int number2 = 10;
var message = "sum of a and b";

operators.Display($"{message} {operators.RefactorSum(number1, number2)}");

*/
//arrays with method expression 
/*int[] elements = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

Console.WriteLine(operators.ListElements(elements));*/

//arrays with method expression 
/*string[] listFoods = ["burger", "pizza", "shawarma", "hotdogs"];

Console.WriteLine(operators.ListFoods(listFoods));*/

//list of items; 
/*List<int> listIndex = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

Console.WriteLine(operators.ListIndex(listIndex));

var userCreditCard = new Operators();*/


//Method expression credit card functions 
/*string? card = "5657878876771324";
string? card2 = "565787887677132";
string? card3 = "5657878876771324";
string? card4 = "5657878876771324";

Console.WriteLine(userCreditCard.CreditsGuards(in card));

Console.WriteLine(userCreditCard.CreditsGuards2(card2));*/
//Method expression name exceeding functions
/*string asshole = "dayetdayetss";

var check = (asshole.Length is 10 && asshole.Length <= 10)
           ? $"you increasingly your name length of {asshole.Length}"
           : $"you exceed the limit of the current assign length";

Console.WriteLine(check);
*/


var users = new OperatorCsharp.Operators();

string usernames = "Dayet";
string passwords = "Dayet";

string userid = "Dayet";
string pass = "Dayet";

Console.WriteLine(users.Authentication(usernames, passwords));
Console.WriteLine(users.Authorized(usernames, passwords));


/*var authenticationLogin = (usernames.Length <= 16 && passwords.Length <= 16)
                   && (usernames.Length is not 17 && passwords.Length is not 17)
                   ? "username is fine" : "exceed the limit of username";


Console.WriteLine($"{authenticationLogin}");*/

//Ternary Condition defining the length if null 
string? employeeNames = "Abdulwahid";

var information = employeeNames?.Length;

var checkString = (information > 0) ? information : throw new Exception();

Console.WriteLine($"current string:{checkString}");

int a = 200000000;
int b = 200000000;

int result1 = checked(a + b);
int result2 = unchecked(a + b);

Console.WriteLine($"checked a + b {result1} / unchecked a + b {result2}");


try
{
    Console.Write("enter number: ");
    string inputs = Console.ReadLine();
    int outputs = int.Parse(inputs);
    Console.WriteLine(outputs);

}
catch (Exception ex)
{
    Console.WriteLine($"error found:{ex.Message}");
}

/*
try
{
    //Parse in C# 
    string daterStr = "04-11-1999";

    DateTime datetime = DateTime.Now;

    int time = int.Parse(daterStr);

    Console.WriteLine(datetime);

}
catch(Exception ex)
{
    Console.WriteLine($"error parsing number:{ex.Message}");
}*/