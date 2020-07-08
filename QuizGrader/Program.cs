using System;
using System.Collections.Generic;

namespace QuizGrader
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz newQuiz = new Quiz();

            Question q1 = new MultipleChoiceQuestion("Australia", "What's the biggest island?",
                new List<string>() { "Australia", "New Zealand", "Guam", "Madagascar" });

            newQuiz.AddQuestion(q1);

            Question q2 = new TrueFalseQuestion("There are 3 quarts in a gallon", "False");

            newQuiz.AddQuestion(q2);


            newQuiz.Administer();
        }
    }
}
