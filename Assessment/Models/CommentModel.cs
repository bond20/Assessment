using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment.Models
{
    public class CommentModel
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }
    }
}