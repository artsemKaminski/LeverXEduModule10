using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeverXEduModule10
{
    public class UserProfile
    {
        public int Id { get; set; }

        public string Address { get; set; }
        public string PhotoLink { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
