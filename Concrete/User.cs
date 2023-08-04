using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public int? RoleID { get; set; }
        public virtual Role Role { get; set; }

        public ICollection<UserAuthority> Authorities { get; set; }
    }
}
