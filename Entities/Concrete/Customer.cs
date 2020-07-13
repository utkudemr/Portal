using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public long Tc { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public DateTime Dateofbirth { get; set; }
    }
}
