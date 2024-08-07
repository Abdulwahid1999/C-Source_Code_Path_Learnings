namespace ParethensizedAndListPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new() { 1, 2, 3 };

            if (numbers is [var first, var second, _])
            {
                Console.WriteLine($"The first element of a three-item list is {first}, {second}.");
            }
            else
            {
                throw new ArgumentException("cannot match the conditions"); 
            }
            // Output:
            // The first element of a three-item list is 1.

            Console.WriteLine(new[] { 1, 2, 3, 4, 5 } is [> 0 or -2, > 0 or -1, ..]);  // True
            Console.WriteLine(new[] { 1, 1 } is [_, _, ..]);  // True
            Console.WriteLine(new[] { 0, 1, 2, 3, 4 } is [> 0, > 0, ..]);  // False
            Console.WriteLine(new[] { 1 } is [1, 2, ..]);  // False

            Console.WriteLine(new[] { 1, 2, 3, 4 } is [.., > 0, > 0]);  // True
            Console.WriteLine(new[] { 2, 4 } is [.., > 0, 2, 4]);  // False
            Console.WriteLine(new[] { 2, 4 } is [.., 2, 4]);  // True

            Console.WriteLine(new[] { 1, 2, 3, 4 } is [>= 0, .., 2 or 4]);  // True
            Console.WriteLine(new[] { 1, 0, 0, 1 } is [1, 0, .., 0, 1]);  // True
            Console.WriteLine(new[] { 1, 0, 1 } is [1, 0, .., 0, 1]);  // False

            Console.WriteLine(numbers);

            void MatchMessage(string message)
            {
                var result = message is ['a' or 'A', .. var s, 'a' or 'A']
                && message is ['c' or 'C', .. var g, 'd' or 'D']
                && message is ['c' or 'C', .. var h, 'd' or 'D']
                && message is ['c' or 'C', .. var w, 'd' or 'D']
                && message is ['c' or 'C', .. var k, 'd' or 'D']

                    ? $"Message {message} matches; inner part is {s}."
                    : $"Message {message} doesn't match.";
                Console.WriteLine(result);
            }

            MatchMessage("aBBA");  // output: Message aBBA matches; inner part is BB.
            MatchMessage("apron");  // output: Message apron doesn't match.

            void Validate(int[] numbers)
            {
                var result = numbers is [< 0, .. { Length: 2 or 4 }, > 0] ? "valid" : "not valid";
                Console.WriteLine(result);
            }

            Validate(new[] { -1, 0, 1 });  // output: not valid
            Validate(new[] { -1, 0, 0, 1 });  // output: valid


            int[] array = { 1, 2, 3, 4 };
            int[] subArray = array[1..4]; // { 2, 3, 4 }

            string str = "Hello World!";
            string subStr = str[7..12]; // "World"
/*
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] subArray1 = array[^4..^1]; // { 2, 3, 4 }
*/
            foreach (var arr in subStr)
            {
                Console.WriteLine(arr);
            }
        }
    }
}
