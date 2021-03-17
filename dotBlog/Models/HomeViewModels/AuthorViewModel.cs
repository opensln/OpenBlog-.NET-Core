using dotBlog.Data.Models;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotBlog.Models.HomeViewModels
{
    public class AuthorViewModel
    {
        public ApplicationUser Author { get; set; }

        public IPagedList<Post> Posts { get; set; }

        public string SubHeader { get; set; }

        public string SearchString { get; set; }
        public int PageNumber { get; set; }
    }
}
