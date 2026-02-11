using LibraryGUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI.Datas
{
    internal class Create
    {
        public object CreateAuthor(string name) 
        {
            using (var context = new librarydbContext())
            {
                var author = new Authors 
                { 
                    AuthorName = name
                };

                context.Authors.Add(author);
                context.SaveChanges();
                return new { message = "Sikeres felvétel", result = author };
            }
           
        }
    }
}
