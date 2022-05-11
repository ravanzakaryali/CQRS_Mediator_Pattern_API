using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Core.Entites
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsArchive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsModified { get; set; }
    }
}
