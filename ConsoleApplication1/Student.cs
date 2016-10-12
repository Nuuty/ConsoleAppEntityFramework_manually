using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //Navnet på klassen bliver også navnet på tabellen i databasen +s
    public class Student
    {
        //Er som default primary key, identity(1,1) og not null
        public int Id { get; set; }
        [Required] // Required = Not Null
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        public DateTime DateTime { get; set; }
    }
}
