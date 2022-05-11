using System;

namespace Domain.Entites
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
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
