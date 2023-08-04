using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    [Table("RoleAuthority")]
    public class RoleAuthority
    {
        [Key]
        public int RoleAuthorityID { get; set; }

        public int FolderID{ get; set; }
        public virtual Folder Folder { get; set; }

        public int RoleID { get; set; }
        public virtual Role Role { get; set; }
    }
}
