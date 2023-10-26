using Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Interface
{
    public interface IBlogPostService
    {
        BlogPostModel GetBlogPostById(int id);
        List<BlogPostModel> GetAllBlogPosts();
    }
}
