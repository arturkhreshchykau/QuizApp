using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic.Models
{
    public class QuestionModel
    {        
        public int QuestionID { get; set; }
        public int TestID { get; set; }
        public string QuestionName { get; set; }
        public bool isOpen { get; set; }
    }
}
