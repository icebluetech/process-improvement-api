using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class LessonLearned
    {
        public int Id { get; set; }

        public string Worked { get; set; }

        public string NotWorked { get; set; }

        public string Other { get; set; }

        public int InnovationId { get; set; }
        public Innovation Innovation { get; set; }
    }
}
