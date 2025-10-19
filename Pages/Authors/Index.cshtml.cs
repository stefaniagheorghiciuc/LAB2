using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gheorghiciuc_Stefania_Lab2.Data;
using Gheorghiciuc_Stefania_Lab2.Models;

namespace Gheorghiciuc_Stefania_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Gheorghiciuc_Stefania_Lab2.Data.Gheorghiciuc_Stefania_Lab2Context _context;

        public IndexModel(Gheorghiciuc_Stefania_Lab2.Data.Gheorghiciuc_Stefania_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
