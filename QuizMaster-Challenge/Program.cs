using System;
using System.Collections.Generic;

namespace QuizMaster_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartQuiz();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program completed.");
            }
        }

        public static void StartQuiz()
        {
            List<string> islamicQuestionsAndAnswers = new List<string>()
            {
                "Who is the final prophet in Islam?|Mohammad",
                "What is the holy book of Islam?|Quran",
                "What is the first pillar of Islam?|Shahada",
                "What is the month of fasting in Islam?|Ramadan",
                "What is the direction faced during Islamic prayer?|Qibla"
            };

            int sum = 0;
            // Accessing Islamic questions and answers
            foreach (string item in islamicQuestionsAndAnswers)
            {
                string[] parts = item.Split('|');
                string question = parts[0];
                string answer = parts[1];

                Console.WriteLine("Question: " + question);
                string ansInput = "";
                bool validInput = false;
                while (!validInput)
                {
                    ansInput = Console.ReadLine();
                    if (ansInput.Trim().Length > 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid answer.");
                    }
                }

                if (answer.Equals(ansInput, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Correct!");
                    sum++;
                }
                else
                {
                    Console.WriteLine("Your answer is wrong and the correct answer is : " + answer);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Your final result is {sum}/{islamicQuestionsAndAnswers.Count}");
            Console.WriteLine();
        }
    }
}

