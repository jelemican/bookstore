using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BooksProject.Models
{
    public class Books
    {
        [Key]
        public int id { get; set; }
        public string author { get; set; }
        public string book_name { get; set; }
        public int year_published { get; set; }
    }
}
