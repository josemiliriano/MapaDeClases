using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MapClass.Entities
{
    public class Departments
    {
        [Key]
        public int ID_Department { get; set; }
        public string Department_Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}
