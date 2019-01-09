using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvEFCoreMigrations.Models
{
    public class AuditBase
    {
        public DateTime AuditModDate { get; set; }
        public DateTime AuditEndDate { get; set; }
    }
}
