namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found

            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names

            Console.WriteLine("Please input the item you would like to search for.");
            string Search = Console.ReadLine();

            //int i = 0;
            bool found = false;
            foreach (string j in fruits)
            {
                if (j == Search)
                {
                    found = true;
                }
                //i++;
            }

            Console.WriteLine(found);
        }
    }
}
