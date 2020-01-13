using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ArticleApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ArticleApp.Controllers
{
    public class HomeController : Controller
    {
        private ArticleContext articleContext { get; set; }
        private TagContext tagContext { get; set; }

        public HomeController(ArticleContext _articleContext, TagContext _tagContext)
        {
            articleContext = _articleContext;
            tagContext = _tagContext;
        }

        // GET: Home
        public ActionResult Index(string sortOrder, string searchString)
        {
            List<string> orders = new List<string>
            {
                "None",
                "Ascending",
                "Descending"
            };
            ViewBag.Orders = new SelectList(orders);
            ViewData["CurrentFilter"] = searchString;
            IEnumerable<Article> articles = articleContext.Articles;
            if (!String.IsNullOrEmpty(searchString))
            {
               articles = articles.Where(s => s.Title.Contains(searchString)
               || s.Text.Contains(searchString) || s.SubText.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "Ascending":
                    articles = articles.OrderBy(s => s.dateAdded);
                    break;
                case "Descending":
                    articles = articles.OrderByDescending(s => s.dateAdded);
                    break;
                default:
                    articles = articles.OrderBy(s => s.Id);
                    break;
            }
            return View(articles.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            var article = articleContext.Articles.Where(p => p.Id == id).FirstOrDefault();
            return View(article);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            ViewBag.Orders = new MultiSelectList(tagContext.Tags, "Id", "Text");
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ArticleViewModel articleViewModel)
        {
            Article article = new Article
            {
                Title = articleViewModel.Title,
                Text = articleViewModel.Text,
                SubText = articleViewModel.SubText,
                Tags = articleViewModel.Tags,
                dateAdded = DateTime.Now
            };
            if (articleViewModel.Image != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(articleViewModel.Image.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)articleViewModel.Image.Length);
                }
                // установка массива байтов
                article.Image = imageData;
            }
            articleContext.Articles.Add(article);
            articleContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var article = articleContext.Articles.Where(p => p.Id == id).FirstOrDefault();
            ViewBag.Orders = new MultiSelectList(tagContext.Tags, "Id", "Text");
            return View(article);
        }

        // POST: Home/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ArticleViewModel articleViewModel)
        {
            var article = articleContext.Articles.Where(a => a.Id == id).FirstOrDefault();
            article.Title = articleViewModel.Title;
            article.Text = articleViewModel.Text;
            article.SubText = articleViewModel.SubText;
            article.Tags = articleViewModel.Tags;
            article.dateAdded = DateTime.Now;
            if (articleViewModel.Image != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(articleViewModel.Image.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)articleViewModel.Image.Length);
                }
                // установка массива байтов
                article.Image = imageData;
            }
            articleContext.Articles.Update(article);
            await articleContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Home/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: Home/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            var article = await articleContext.Articles.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (article != null) {
                articleContext.Remove(article);
                await articleContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}