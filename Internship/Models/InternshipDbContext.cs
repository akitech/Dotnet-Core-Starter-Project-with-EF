using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Internship.Models
{
    public class InternshipDbContext : DbContext
    {
        DbSet<Internship> Internships { get; set; }
        

    }


    public class Internship
    {
        [Key]
        public int AppId { get; set; }
        public bool Supervisor { get; set; }
        public bool Student { get; set; }
        public bool Dean { get; set; }
        public bool InternationalOffice { get; set; }
    }


}