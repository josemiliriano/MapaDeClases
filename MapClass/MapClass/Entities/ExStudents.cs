using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MapClass.Entities
{
    public class ExStudents
    {
        [Key]
        public int ID_ExStudent { get; set; }
        [ForeignKey("ID_Student")]
        public int Studet_ID { get; set; }
        public DateTime GraduationDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}
