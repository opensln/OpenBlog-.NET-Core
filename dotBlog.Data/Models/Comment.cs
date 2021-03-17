using System;
using System.Collections.Generic;
using System.Text;

namespace dotBlog.Data.Models
{
    public class Comment
    {
        public int id { get; set; }

        public Post Post { get; set; } //Really this stores the id from the Post Table (int in this case)

        public ApplicationUser Author{ get; set; } //Really this stores the id from the ApplicationUser Table(string in this case)

        public string Content { get; set; }

        public Comment Parent { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual IEnumerable<Comment> Comments { get; set; }

    }
}
