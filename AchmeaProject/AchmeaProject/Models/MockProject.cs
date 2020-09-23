using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AchmeaProject.Models
{
    public class MockProject
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string Owner { get; set; }

        public MockProject(string name, string status, string owner)
        {
            Name = name;
            Status = status;
            Owner = owner;
        }
    }
}
