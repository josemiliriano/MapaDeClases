using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MapClass.Entities
{
    public class SpecializedSubjects
    {
        [Key]
        public int ID_SpecilizationSubject { get; set; }
        public required string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

    }
}
