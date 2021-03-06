﻿using imodel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace model
{
    public class Doc : IDoc
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public int InnovationId { get; set; }
        public Innovation Innovation { get; set; }

        public string Url { get; set; }
    }
}
