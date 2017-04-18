using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee
    {
        public int  Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public char Genre { get; set; }

        public DateTime BirthDay { get; set; }

        public SqlMoney Salary { get; set; }
        
        public string Type { get; set; }


    }
}
