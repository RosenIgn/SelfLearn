using System.Collections.Generic;

namespace Self_Learn
{
    public class ExamQuestions
    {
        public int ID { get; set; }
        public string QuestionLabel { get; set; }
        public List<ExamAnswers> Answers { get; set; }

        public ExamQuestions(int iD, string questionLabel, List<ExamAnswers> answers)
        {
            ID = iD;
            QuestionLabel = questionLabel;
            Answers = answers;
        }
    }
}