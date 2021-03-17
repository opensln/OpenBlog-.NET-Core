using dotBlog.Data;
using dotBlog.Data.Models;
using dotBlog.Services.interfaces;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dotBlog.Services
{
    public class UserService :IUserService 
    {
        private readonly ApplicationDbContext applicationDbContext;

        public UserService(ApplicationDbContext applicationDbContex)
        {
            this.applicationDbContext = applicationDbContex;
        }

        public ApplicationUser Get(string id)
        {
            return applicationDbContext.Users
                .FirstOrDefault(user => user.Id == id);
        }

        public async Task<ApplicationUser> Update(ApplicationUser applicationUser)
        {
            applicationDbContext.Update(applicationUser);
            await applicationDbContext.SaveChangesAsync();
            return applicationUser;
        }
    }
}
