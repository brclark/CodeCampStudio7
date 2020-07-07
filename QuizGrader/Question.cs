using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public abstract class Question
    {
        // Which countries in Oceania are big? (CheckBox)
        // Which country has the outback? (MultipleChoiceQuestion)
        // NZ
        // Samoa
        // Guam
        // Australia
        // NZ stands for New Zoo (T/F)

        public string Prompt { get; set; }
        public List<string> Options { get; set; }        

        public Question(string prompt, List<string> options)
        {
            Prompt = prompt;
            Options = options;
        }

        public void PromptQuestion()
        {
            // Display Prompt
            Console.WriteLine(Prompt);
            // Display each option in the Options list
            foreach (string option in Options)
            {
                Console.WriteLine(option);
            }
        }

        public abstract bool GradeQuestion();
    }
}
