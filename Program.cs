using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            //Tools.SetUpInputStream(entry);

            string[] questions = { "Eggplants are a type of berry.", "Apples are a vegetable", "England is in Europe.", "The sky is blue.", "The moon is green" };
            bool[] answers = { true, false, true, true, false };
            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning! Amount of answers does not match the amount of questions.");
            }

            int askingIndex = 0;

            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(question);
                Console.Write("True or false? ");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (isBool != true)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool currentResponse = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {currentResponse} | Answer: {answer}");

                if (currentResponse == answer)
                {
                    score++;
                }
                scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of 5 correct!");
        }
    }
}
