using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleApp.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubText { get; set; }
        public string Text { get; set; }
        public byte[] Image { get; set; }
        public List<Tag> Tags { get; set; }
        public DateTime dateAdded { get; set; }
    }
}
