using LibraryGUI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI.Datas
{
    public class Read
    {
        public List<Authors> ReadAuthors() 
        {
            using (var context = new librarydbContext())
            {
                var users = context.Authors.ToList();
                return users;
            }
        }
    }
}
