using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic.Models
{
    public class StatisticModel
    {
        public int StatisticID { get; set; }
        public int UserID { get; set; }
        public int TestID { get; set; }
        public int CorrectAnswer { get; set; }
        public DateTime Passed { get; set; }
    }
}
