using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MapClass.Entities
{
    public class Course
    {
        [Key]
        public int ID_Course { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete {  get; set; }

    }
}
