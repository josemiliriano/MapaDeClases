using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MapClass.Entities
{
    public class Teachers
    {
        [Key]
        public int Id_Teacher { get; set; }
        [ForeignKey("ID_Person")]
        public int Person_ID { get; set; }
        [ForeignKey("ID_SpecilizationSubject")]
        public int Speciality_ID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

    }
}
