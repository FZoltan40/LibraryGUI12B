using LibraryGUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI.Datas
{
    internal class Delete
    {
        public object DeleteAuthor(int id)
        {
            LibraryResults results = new LibraryResults();
            using (var context = new librarydbContext())
            {
                var author = context.Authors.Find(id);

                if (author != null)
                {
                    context.Authors.Remove(author);
                    context.SaveChanges();
                    results.Message = "Sikeres törlés";
                    results.Result = author;
                    return results;
                }

                results.Message = "Sikertelen törlés";
                results.Result = author;
                return results;
            }
        }

        public object DeleteCategory(int id)
        {
            LibraryResults results = new LibraryResults();
            using (var context = new librarydbContext())
            {
                var category = context.Categories.Find(id);

                if (category != null)
                {
                    context.Categories.Remove(category);
                    context.SaveChanges();
                    results.Message = "Sikeres törlés";
                    results.Result = category;
                    return results;
                }

                results.Message = "Sikertelen törlés";
                results.Result = category;
                return results;
            }
        }

        public object DeleteBook(int id)
        {
            LibraryResults results = new LibraryResults();
            using (var context = new librarydbContext())
            {
                var book = context.Books.Find(id);

                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    results.Message = "Sikeres törlés";
                    results.Result = book;
                    return results;
                }

                results.Message = "Sikertelen törlés";
                results.Result = book;
                return results;
            }
        }
    }
}
