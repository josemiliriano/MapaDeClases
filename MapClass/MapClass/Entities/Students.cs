using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MapClass.Entities
{
    public class Students
    {
        [Key]
        public int ID_Student { get; set; }
        [ForeignKey("ID_Person")]
        public int Person_ID { get; set; }
        public string Tuition { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}
