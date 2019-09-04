using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Web.Models
{
    [Table("employee",Schema ="public")]
    public class Employee
    {
        [Key]
        public int id { get; set; }

        [Column("employeecode")]
        public string EmployeeCode { get; set; }

        [Column("fullname")]
        public string FullName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("cellphone")]
        public string Cellphone { get; set; }

        [Column("address")]
        public string Address { get; set; }
    }
}
