using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizes_S6
{
    public abstract class Question
    {
        public string QuestionAsked { get; set; }

        public Question(string questionAsked)
        {
            QuestionAsked = questionAsked;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(QuestionAsked);
        }

        public abstract void DisplayPossibleAnswers();
        public abstract int GetAnswers();
    }
}
