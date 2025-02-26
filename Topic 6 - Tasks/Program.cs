namespace Topic_6___Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Topic 6 - Programming Tasks");
            Console.WriteLine("");
            //Part 1
            Console.WriteLine("Task 1");
            Random generator = new Random();
            int min, max;
            Console.WriteLine("Type the max number:");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now give me a number that's lower than the max:");
            min = Convert.ToInt32(Console.ReadLine()); //PUT A LOWER NUMBER
            if (min >= max)
            {
                Console.WriteLine("You did it wrong buddy!");
            }
            else
            {
                Console.WriteLine("If the min is: " + min + " and the max is: " + max + " The number i'll give you will be: ");
                Console.WriteLine(generator.Next(min, max + 1));
                Console.WriteLine("");
            }
            //PART 2
            Console.WriteLine("Task 2");
            Console.WriteLine("");
            int number, answer;
            number = generator.Next(1, 10);
            Console.WriteLine("Enter the right number! Only 1-10");
            answer = Convert.ToInt32(Console.ReadLine());
            if (number == answer)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong, the number was : " + number);
            }
            //PART 3
            Console.WriteLine("");
            Console.WriteLine("Part 3");
            Console.WriteLine("");
            Console.WriteLine("To roll the 2 dice say YES! and find out the amount of moves you got!");
            Console.ReadLine();
            Console.WriteLine(generator.Next(6));
            int dice1 = generator.Next(6);
            Console.WriteLine(generator.Next(6));
            int dice2 = generator.Next(6);
            Console.WriteLine("Then your moves will be:");
            Console.WriteLine(dice1 + dice2);
        }
    }
}
