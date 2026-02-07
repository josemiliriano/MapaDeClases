using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MapClass.Entities
{
    public class Persons
    {
        [Key]
        public int ID_Person { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public short Age { get; set; }
        public string Email { get; set; }
        public string Identiication { get; set; }
        public bool isActive { get; set; }
        public bool isDelete { get; set; }
        [ForeignKey("ID_Role")]
        public int RoleId { get; set; }

    }
}
