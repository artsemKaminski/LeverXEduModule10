using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeverXEduModule10
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual UserProfile Profile { get; set; }
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
