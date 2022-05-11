﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Response
{
    public class GetAllUserBlogQeuryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserId { get; set; }
        public bool IsModified { get; set; }
    }
}