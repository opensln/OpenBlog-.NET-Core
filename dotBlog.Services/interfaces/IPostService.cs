using dotBlog.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dotBlog.Services.interfaces
{
    public interface IPostService
    {
        Post GetPost(int postId);

        Task<Post> Add(Post post);

        Task<Comment> Add(Comment comment);

        Task<Post> Update(Post post);

        IEnumerable<Post> GetPosts(ApplicationUser applicationUser);

        IEnumerable<Post> GetPosts(string searchString);

        Comment GetComment(int commentId);
        
    }
}
