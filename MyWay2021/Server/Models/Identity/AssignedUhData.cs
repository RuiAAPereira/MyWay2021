using System;

namespace MyWay2021.Server.Models.Identity
{
    public class AssignedUhData
    {
        public Guid UhID { get; set; }
        public string Name { get; set; }
        public bool Assigned { get; set; }
    }
}
