using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class GapAnalysis
    {
        public int Id { get; set; }

        public int WasteTypeId { get; set; }
        public virtual WasteType WasteType { get; set; }

        public string Url { get; set; }

        public int ValueHold { get; set; }
        public int NonValueHold { get; set; }
        public int NVA { get; set; }

        public int InnovationId { get; set; }
        public Innovation Innovation { get; set; }

    }
}
