
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleApp.Models
{
    public class ArticleViewModel
    {
        public string Title { get; set; }
        public string SubText { get; set; }
        public string Text { get; set; }
        public IFormFile Image { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
