using Microsoft.AspNetCore.Mvc;
using dotBlog.Models.PostViewModels;
using dotBlog.BusinessManagers.Interfaces;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace dotBlog.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly IPostBusinessManager postBusinessManager;

        public PostController(IPostBusinessManager blogBusinessManager)
            {
            this.postBusinessManager = blogBusinessManager;
            }
        [Route("Post/{id}"), AllowAnonymous]
        public async Task<IActionResult> Index(int? id)
        {
            var actionResult = await postBusinessManager.GetPostViewModel(id, User);

            if (actionResult.Result is null)
                return View(actionResult.Value);
            //else single line syntax
            return actionResult.Result;
        }

        public IActionResult Create()
        {
            return View(new CreateViewModel());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var actionResult = await postBusinessManager.GetEditViewModel(id, User);

            if(actionResult.Result is null)
            return View(actionResult.Value);
            //else single line syntax
            return actionResult.Result;
        }



        [HttpPost]
        public async Task<IActionResult> Add(CreateViewModel createBlogViewModel)
        {
            await postBusinessManager.CreatePost(createBlogViewModel, User);
            return RedirectToAction("Create");
        }


        [HttpPost]
        public async Task<IActionResult> Update(EditViewModel editViewModel)
        {
            var actionResult = await postBusinessManager.UpdatePost(editViewModel, User);
            if (actionResult.Result is null)
            return RedirectToAction("Edit", new { editViewModel.Post.id });

            return actionResult.Result;
        }

        [HttpPost]
        public async Task<IActionResult> Comment(PostViewModel postViewModel)
        {
            var actionResult = await postBusinessManager.CreateComment(postViewModel, User);
            if (actionResult.Result is null)
                return RedirectToAction("Index", new { postViewModel.Post.id });

            return actionResult.Result;
        }
    }
}
