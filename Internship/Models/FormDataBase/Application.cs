using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Internship.Models
{
    public class Application
    {
        [Key]
        public int FormId { get; set; }
        public bool Supervisor { get; set; }
        public bool Student { get; set; }
        public bool Dean { get; set; }
        public bool InternationalOffice { get; set; }
    }
}