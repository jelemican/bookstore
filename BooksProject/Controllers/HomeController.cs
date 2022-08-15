using BooksProject.DATA;
using BooksProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BooksProject.Controllers
{
    public class HomeController : Controller
    {
        private BooksDbContext _dbContext;
        public static List<Books> thelist {get;set;}
        public HomeController(BooksDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public static void SortByAuthor()
        {
            List<Books> fornow = thelist;
            List<string> temp = new List<string>();
            foreach (Books item in fornow)
            {
                temp.Add(item.author);
            }
            temp.Sort();
            List<Books> res = new List<Books>();
            foreach (string item in temp)
            {
                for (int i = 0; i < fornow.Count; i++)
                {
                    if (item == fornow[i].author)
                    {
                        res.Add(fornow[i]);
                        fornow.RemoveAt(i);
                        break;
                    }
                }
            }
            thelist = res;
        }
        public static void SortByName()
        {
            List<Books> fornow = thelist;
            List<string> temp = new List<string>();
            foreach (Books item in fornow)
            {
                temp.Add(item.book_name);
            }
            temp.Sort();
            List<Books> res = new List<Books>();
            foreach (string item in temp)
            {
                for (int i = 0; i < fornow.Count; i++)
                {
                    if (item == fornow[i].book_name)
                    {
                        res.Add(fornow[i]);
                        fornow.RemoveAt(i);
                        break;
                    }
                }
            }
            thelist = res;
        }
        public static void SortByYear()
        {
            List<Books> fornow = thelist;
            List<int> temp = new List<int>();
            foreach (Books item in fornow)
            {
                temp.Add(item.year_published);
            }
            temp.Sort();
            List<Books> res = new List<Books>();
            foreach (int item in temp)
            {
                for (int i = 0; i < fornow.Count; i++)
                {
                    if (item == fornow[i].year_published)
                    {
                        res.Add(fornow[i]);
                        fornow.RemoveAt(i);
                        break;
                    }
                }
            }
            thelist = res;
        }

        public IActionResult Index(int id)
        {
            if (id == 3)
            {
                
                return View(thelist);
            }
            else if (id == 4)
            {
                HomeController.SortByAuthor();
                return View(thelist);
            }
            else if (id == 5)
            {
                HomeController.SortByName();
                return View(thelist);
            }
            else if (id == 6)
            {
                HomeController.SortByYear();
                return View(thelist);
            }
            else
            {
                thelist = _dbContext.Books.ToList();
                return View(thelist);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            Books itemToRemove = thelist.Single(r => r.id == id);
            thelist.Remove(itemToRemove);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
