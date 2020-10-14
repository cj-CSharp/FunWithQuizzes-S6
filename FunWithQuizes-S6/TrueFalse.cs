using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizes_S6
{
    class TrueFalse : Question
    {
        public static List<bool> PossibleAnswers = new List<bool> { true, false };
        public bool CorrectAnswer { get; set; }

        public TrueFalse(string questionAsked, bool correctAnswer) : base(questionAsked)
        {
            CorrectAnswer = correctAnswer;
        }

        public override void DisplayPossibleAnswers()
        {
            Console.WriteLine("Type T for True or Type F for false");
        }
        public override int GetAnswers()
        {
            Console.WriteLine("T - True");
            Console.WriteLine("F - False");
            string userAnswer = Console.ReadLine();
            if(HasCorrectAnswer(userAnswer))
            {
                return 1;
            }
            return 0;
        }
        private bool HasCorrectAnswer(string userAnswer)
        {
            bool answerInBool = false;
            if(userAnswer.ToLower() == "t" || userAnswer.ToLower() == "true")
            {
                answerInBool = true;
            }
            if(CorrectAnswer.Equals(answerInBool))
            {
                return true;
            }
            return false;
        }
    }
}
