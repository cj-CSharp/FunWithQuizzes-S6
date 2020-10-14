using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace FunWithQuizes_S6
{
    class MultipleChoice : Question
    {
        public List<string> PossibleAnswers { get; set; }
        public string CorrectAnswer { get; set; }

        public MultipleChoice (string questionAsked, string correctAnswer, List<string> possibleAnswers) : base (questionAsked)
        {
            CorrectAnswer = correctAnswer;
            PossibleAnswers = possibleAnswers;
        }

        public override void DisplayPossibleAnswers()
        { 
            for(int i = 0; i < PossibleAnswers.Count; i++)
            {
                Console.WriteLine((i+1) + " - " + PossibleAnswers[i]);
            }
        }
        public override int GetAnswers()
        {
            Console.WriteLine("Choose the number by the choice you select as the answer");
            int userAnswer = int.Parse(Console.ReadLine());
            userAnswer--;
            if (HasCorrectAnswer(PossibleAnswers[userAnswer])) 
            {
                return 1;
            }
            return 0;
        }

        private bool HasCorrectAnswer(string userAnswer)
        {
            if (CorrectAnswer.Equals(userAnswer))
            {
                return true;
            }
            return false;
        }
            

    }
}
