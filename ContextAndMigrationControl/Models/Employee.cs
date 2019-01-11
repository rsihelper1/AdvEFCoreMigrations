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
        public string PreventThisFieldsRenameWithReposition { get; set; }
        public string NewFieldForScriptGeneration { get; set; }

      

        public string similartoheighwieth { get; set; }
        public string ManipSnapshot { get; set; }

        public string tryignoring { get; set; }

        public string similartoheighwieth2 { get; set; }
        public string ManipSnapshot2 { get; set; }

        public string tryignoring2 { get; set; }

        public string similartoheighwieth12 { get; set; }
        public string ManipSnapshot12 { get; set; }

        public string tryignoring12 { get; set; }

        public string similartoheighwieth212 { get; set; }
        public string ManipSnapshot212 { get; set; }

        public string simple { get; set; }

        public string simple2 { get; set; }
        public string Addmore { get; set; }

    }
}
