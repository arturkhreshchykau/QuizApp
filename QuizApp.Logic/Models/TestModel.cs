using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic.Models
{
    public  class TestModel
    {
        public int TestID { get; set; }
        public string TestName { get; set; }
        public int CategoryID { get; set; }
        public int? Timer { get; set; }
        public bool isLiveCheck { get; set; }
        public int OwnerID { get; set; }
    }
}
