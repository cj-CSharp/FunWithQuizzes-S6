using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace FunWithQuizes_S6
{
    class Checkbox : Question
    {
        public List<string> PossibleAnswers { get; set; }
        public List<string> CorrectAnswers { get; set; }

        public Checkbox(string questionAsked, List<string> correctAnswers, List<string> possibleAnswers) : base(questionAsked)
        {
            PossibleAnswers = possibleAnswers;
            CorrectAnswers = correctAnswers;
        }

        public override void DisplayPossibleAnswers()
        {
            for(int i = 0; i < PossibleAnswers.Count; i++)
            {
                Console.WriteLine((i + 1) + " - " + PossibleAnswers[i]);
            }
        }

        public override int GetAnswers()
        {
            List<string> userAnswers = new List<string>();
            Console.WriteLine("This question might have multiple answers. Type 'y' to continue.");
            string shouldContinue = Console.ReadLine();
            while(shouldContinue == "y")
            {
                Console.WriteLine("Choose the number next to the answer you want to select");
                string answerNumAsString = Console.ReadLine();
                int answerIndex = int.Parse(answerNumAsString) - 1;
                string oneAnswer = PossibleAnswers[answerIndex];
                if(!userAnswers.Contains(oneAnswer))
                {
                    userAnswers.Add(oneAnswer);
                }

                Console.WriteLine("If you have more answers, type 'y'. If not, type 'n'.");
                shouldContinue = Console.ReadLine();
            }

            if(HasCorrectAnswer(userAnswers))
            {
                return 1;
            }
            return 0;

        }

        private bool HasCorrectAnswer(List<string> userAnswers)
        {
            if(CorrectAnswers.Count != userAnswers.Count)
            {
                return false;
            }
            int correctCount = 0;
            foreach(string userAnswer in userAnswers)
            {
                
                if(CorrectAnswers.Contains(userAnswer))
                {
                    correctCount++;
                }
            }
            if(correctCount == CorrectAnswers.Count)
            {
                return true;
            }
            return false;
        }



    }
}
