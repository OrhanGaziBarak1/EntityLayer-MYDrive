using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    [Table("UserAuthority")]
    public class UserAuthority
    {
        [Key]
        public int UserAuthorityID { get; set; }
        public bool Read { get; set; }
        public bool Create { get; set; }
        public bool Write { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int RoleID { get; set; }
        public virtual Role Role { get; set; }
    }
}
