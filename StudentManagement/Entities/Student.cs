using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Entities
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public Guid StudentId { get; set; }

        [MaxLength(256)]
        public string StudentName { get; set; }

        [MaxLength(256)]
        public string Email { get; set; }

        [MaxLength(256)]
        public string Address { get; set; }
    }
}