using System;
using System.Collections.Generic;

namespace FunWithQuizes_S6
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleChoice question1 = new MultipleChoice("Which orbits the Earth?", "Moon", new List<string> { "Sun", "Moon", "Mars", "Milky Way" });
            TrueFalse question2 = new TrueFalse("SpongeBob lives in a pineapple under the sea.", true);
            Checkbox question3 = new Checkbox("Who are Doug's friends?", new List<string> { "Patti Mayonnaise", "Skeeter" }, new List<string> { "Patti Mayonnaise", "Roger", "Skeeter" }); ;

            List<Question> questionList = new List<Question> { question1, question2, question3 };

            Quiz newQuiz = new Quiz(questionList);

            newQuiz.RunQuiz();
        }
    }
}
