using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvEFCoreMigrations.Models
{
    public class Employee : AuditBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string JobTitle { get; set; }

        public string Department { get; set; }

        public int Salary { get; set; }

        public DateTime Hired { get; set; }

        public bool IsActive { get; set; }

        public string duties  { get; set; }
        public string duties2 { get; set; }

        public string tasks { get; set; }

        public string NewFieldForScriptGeneration { get; set; }

        public string heighweight { get; set; }


    }
}
