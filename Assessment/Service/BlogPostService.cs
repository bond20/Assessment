using Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using Assessment.Interface;

namespace Assessment.Service
{
    public class BlogPostService : IBlogPostService
    {
        private readonly List<BlogPostModel> _blogPosts;

        public BlogPostService()
        {
            // Set the path to your JSON file
            string jsonFilePath = "Path/To/Your/Blog-Posts.json";

            // Load data from the JSON file using Newtonsoft.Json
            var jsonString = File.ReadAllText(jsonFilePath);
            _blogPosts = JsonConvert.DeserializeObject<List<BlogPostModel>>(jsonString);
        }

        public List<BlogPostModel> GetAllBlogPosts()
        {
            return _blogPosts;
        }

        public BlogPostModel GetBlogPost(int id)
        {
            return _blogPosts.FirstOrDefault(post => post.Id == id);
        }

        public BlogPostModel GetBlogPostById(int id)
        {
            return GetBlogPost(id);
        }

        public List<BlogPostModel> GetBlogPosts()
        {
            return _blogPosts;
        }
    }
}