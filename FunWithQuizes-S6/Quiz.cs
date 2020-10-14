using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizes_S6
{
    class Quiz
    {
        public List<Question> Questions { get; }
        public int Score { get; private set; }  = 0;
        public int PossibleScore { get; private set; }

        public Quiz (List<Question> questions)
        {
            Questions = questions;
            PossibleScore = Questions.Count;
        }

        public void AddQuestion(Question question)
        {
            if(!Questions.Contains(question))
            {
                Questions.Add(question);
                PossibleScore = Questions.Count;
            }
        }

        public void RemoveQuestion(Question question)
        {
            if(Questions.Contains(question))
            {
                Questions.Remove(question);
                PossibleScore = Questions.Count;
            }
        }

        private void AskQuestions ()
        {
            foreach(Question question in Questions)
            {
                question.DisplayQuestion();
                question.DisplayPossibleAnswers();
                int scoreForQuestion = question.GetAnswers();
                Score += scoreForQuestion;
            }
        }

        private void displayResults()
        {
            Console.WriteLine($"You got a score of {Score} out of {PossibleScore}!");
        }

        public void RunQuiz()
        {
            AskQuestions();
            displayResults();
        }

    }
}
