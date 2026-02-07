using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MapClass.Entities
{
    public class Roles
    {
        [Key]
        public int ID_Role { get; set; }
        public string NameRole { get; set; }
        public bool isActive { get; set; }
        public bool IsDeleted { get; set; }

    }
}
