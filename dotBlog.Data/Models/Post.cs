﻿using System;
using System.Collections.Generic;
using System.Text;

namespace dotBlog.Data.Models
{
    public class Post
    {

        public int id { get; set; }
        public ApplicationUser Creator { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public bool Published { get; set; }

        public bool Approved { get; set; }

        public ApplicationUser Approver { get; set; }

        public virtual IEnumerable<Comment> Comments { get; set; }

    }
}
