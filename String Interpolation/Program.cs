namespace String_Interpolation
{

    public class Program
    {
        public static string FormatDate(int year = 2022, int month = 10, int day = 29)
        {
            return $"{year}/{month}/{day}";

        }

        static void Main(string[] args)
        {
            Console.WriteLine(FormatDate());

            //Quoted string literals
            string quote = "quote string literals";

            //Verbatum string literals
            string verbatum = @"verbatum string literals";
            string pattern = @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b";
            string quotedString = @"He said, ""Hello!""";
            string multiLineText = @"This is a 
                                    multi-line
                                    string.";
            string filePath = @"C:\Users\John\Documents\file.txt";

            Console.WriteLine(filePath);
            Console.WriteLine(pattern);
            Console.WriteLine(quotedString);

            //Raw string literals
            string raw = """ raw string literals """;

            //String interpolation 
            string interpolation = $"string interpolatfion, {quote}, {verbatum}, {raw}";

            Console.WriteLine(interpolation);

            //String interpolation 
            var singleLine = $"""""This is a {filePath} """"raw string literal"""". It can contain characters like \, ' and ".""""";

            Console.WriteLine(singleLine);

            var articles = """
                according to his lawyer there is a relevant lawyer that could help him
                to figure his problem from murder case in fact his Lawyer is the best in the
                world.
                
                """;

            var patch = @"C:\Users\Dayet\Documents\dayetproject123";
            var facebook = @"facebook.com\dayet123";

            Console.WriteLine(articles);
            Console.WriteLine(patch);
            Console.WriteLine(filePath);


            //build method of string 
            string firstName = "John";
            string lastName = "Doe";
            string fullName = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(fullName);

            var wikipedia = "programming is the study of communication straight to the computers ";

            string primarykey = "fd2452";
            string foreignKey = "234fff";
            const string coupon = "58kg25";

            string script1 = " Yeah! I know i was in hurt ";
            string script2 = "really Nigga?"; 
            string result = string.Format(script1 + script2);

            Console.WriteLine(result.ToLower());
            Console.WriteLine(result.ToUpper());
            Console.WriteLine(result.ToUpperInvariant());

            Console.WriteLine(result.Trim());
        }
    }
}
