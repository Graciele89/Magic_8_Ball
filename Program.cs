
using System;
using System.Collections.Generic;
using Magic_8_Ball;

namespace Magic_8_Ball
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Hello, I'm the 8 ball and I have the answers for your doubts:");
            Console.WriteLine();
            Console.WriteLine("What is your question? ");
            Console.WriteLine();

            List<string> listOfPossibleAnswers = new List<string>();

            listOfPossibleAnswers.Add("It is certain!");
            listOfPossibleAnswers.Add("It is decidedly so.");
            listOfPossibleAnswers.Add("Whithout a doubt");
            listOfPossibleAnswers.Add("Yes, definitely");
            listOfPossibleAnswers.Add("You may rely on it");
            listOfPossibleAnswers.Add("As I see it, yes!");
            listOfPossibleAnswers.Add("Most likely");
            listOfPossibleAnswers.Add("Outlook good");
            listOfPossibleAnswers.Add("YES");
            listOfPossibleAnswers.Add("Signs point to yes.");
            listOfPossibleAnswers.Add("Reply hazy, try again!");
            listOfPossibleAnswers.Add("Ask again later, I`m not sure yet");
            listOfPossibleAnswers.Add("Better not tell you now!");
            listOfPossibleAnswers.Add("Cannot predict now!");
            listOfPossibleAnswers.Add("Concentrate and ask again what you really desire");
            listOfPossibleAnswers.Add("Don't count on it.");
            listOfPossibleAnswers.Add("My reply is NO!");
            listOfPossibleAnswers.Add("My  sources say no");
            listOfPossibleAnswers.Add("Outlook not so good");
            listOfPossibleAnswers.Add("very doubtful");

            Random rdm = new Random();

            int answers = rdm.Next(0, 19);
            Console.WriteLine(listOfPossibleAnswers[answers]);
        }
    }
}