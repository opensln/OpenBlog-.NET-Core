using dotBlog.Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotBlog.Models.PostViewModels
{
    public class EditViewModel
    {
        [Display(Name = "Header")]
        public IFormFile HeaderImage { get; set; }
        public Post Post { get; set; }
    }
}
