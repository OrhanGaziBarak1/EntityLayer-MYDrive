using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public ICollection<User> Users { get; set;}
        public ICollection<UserAuthority> Authorities { get; set;}
        public ICollection<RoleAuthority> RoleAuthorities { get; set;}
    }
}
