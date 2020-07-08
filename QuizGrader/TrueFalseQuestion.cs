using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public class TrueFalseQuestion : Question
    {
        public string CorrectAnswer { get; set; }
        public string UserResponse { get; set; }

        // Create overloaded constructor for this subclass of Question
        /*
         * Needs to accept (prompt, correctAnswer)
         * Pass a new List object of { "True", "False" } to the Options param
         */
        public TrueFalseQuestion(string prompt, string correctAnswer)
            : base(prompt, new List<string>() { "True", "False" })
        {
            CorrectAnswer = correctAnswer;
            UserResponse = "";
        }

        // Implement GradeQuestion method
        public override bool GradeQuestion()
        {
            while (UserResponse != null)
            {
                Console.WriteLine("Your answer:");

                UserResponse = Console.ReadLine();
            }

            return UserResponse.Equals(CorrectAnswer);
        }
    }
}
