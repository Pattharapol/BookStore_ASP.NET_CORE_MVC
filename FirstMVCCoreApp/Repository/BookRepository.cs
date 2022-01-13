using FirstMVCCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCCoreApp.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x=> x.id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }


        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ id=1, Title="MVC", Author="TIKK1", Description = "This is description for MVC book" },
                new BookModel(){ id=2, Title="Dot Net Core", Author="TIKK2", Description = "This is description for Dot Net Core book" },
                new BookModel(){ id=3, Title="C#", Author="TIKK3", Description = "This is description for C# book" },
                new BookModel(){ id=4, Title="JAVA", Author="TIKK4", Description = "This is description for JAVA book" },
                new BookModel(){ id=5, Title="PHP", Author="TIKK5", Description = "This is description for PHP book" },
                new BookModel(){ id=6, Title="Azure DevOps", Author="TIKK6", Description = "This is description for Azure DevOps book" },
            };
        }
    }
}
