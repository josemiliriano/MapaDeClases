using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MapClass.Entities
{
    public class Class
    {
        [Key]
        public int ID_Class { get; set; }
        [ForeignKey("Id_Teacher")]
        public int Teacher_ID { get; set; }
        [ForeignKey("ID_Student")]
        public int Student_ID { get; set; }
        [ForeignKey("ID_SpecilizationSubject")]
        public int Subject_ID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}
