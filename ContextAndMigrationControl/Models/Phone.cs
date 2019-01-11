using System;
using System.Collections.Generic;
using System.Text;

namespace AdvEFCoreMigrations.Models
{
    public class Phone
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int salary { get; set; }

        public bool isactive { get; set; }
        public DateTime Hired { get; set; }
    }
}
