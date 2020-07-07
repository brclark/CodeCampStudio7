using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        public Quiz()
        {
            Questions = new List<Question>();
        }

        public void AddQuestion(Question q)
        {
            Questions.Add(q);
        }

        public void Administer()
        {
            // Walk through list of questions and ask user for responses
            // Call GradeQuestion for each Question in the list to check
            // if the user got the answer correct
            int numCorrect = 0;
            foreach (Question q in Questions)
            {
                q.PromptQuestion();

                bool correct = q.GradeQuestion();
                if (correct)
                {
                    numCorrect++;
                }
            }
            Console.WriteLine("You got " + numCorrect + " correct out of " + Questions.Count);
        }
    }
}
