using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    [Table("Folder")]
    public class Folder
    {
        [Key]
        public int FolderID { get; set; }
        public string FolderName { get; set; }
        public int RootFolderID { get; set; }

        public ICollection<RoleAuthority> RoleAuthorities { get; set;}
        public ICollection<Document> Documents { get; set;}
    }
}
