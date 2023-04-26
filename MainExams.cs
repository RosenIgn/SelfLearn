using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Learn
{
    public class MainExams
    {
        public string ExamName { get; set; }
        public string ExamGrade { get; set; }

        public List<ExamQuestions> Questions = new List<ExamQuestions>();

        public MainExams(string examName, string examGrade, List<ExamQuestions> questions)
        {
            ExamName = examName;
            ExamGrade = examGrade;
            Questions = questions;
        }
    }
}