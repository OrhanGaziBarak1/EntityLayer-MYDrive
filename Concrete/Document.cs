using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    [Table("Document")]
    public class Document
    {
        [Key]
        public int DocumentID { get; set; }
        public string DocumentName { get; set; }
        public string Guid { get; set; }
        public string DocumentType { get; set; }

        public int FolderID { get; set; }
        public Folder Folder { get; set; }

    }
}
