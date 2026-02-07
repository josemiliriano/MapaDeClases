using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MapClass.Entities
{    
    public class Employees
    {
        [Key]
        public int ID_Employee { get; set; }
        [ForeignKey("ID_Person")]
        public int Person_ID { get; set; }
        public int Salary { get; set; }
        public DateTime DateOfEntry { get; set; }
        [ForeignKey("ID_Department")]
        public int Department_ID { get; set; }
    }
}
