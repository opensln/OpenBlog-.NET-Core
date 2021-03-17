using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using dotBlog.Data.Models;
using Microsoft.AspNetCore.Http;

namespace dotBlog.Models.PostViewModels
{
    public class CreateViewModel
    {
        [Required, Display (Name = "Header")]
        public IFormFile HeaderImage { get; set; }
        public Post Post { get; set; }
    }
}
