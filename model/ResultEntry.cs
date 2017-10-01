using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class ResultEntry
    {
        public int Id { get; set; }

        public int ResultEntryTypeId { get; set; }
        public virtual ResultEntryType ResultEntryType { get; set; }

        public int ResultId { get; set; }
        public virtual Result Result { get; set; }

        public string CurrentState { get; set; }
        public DateTime Date { get; set; }
        public int Goal { get; set; }

        public int Thirty { get; set; }
        public int Sixty { get; set; }
        public int Ninety { get; set; }
}
}
