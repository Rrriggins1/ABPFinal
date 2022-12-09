using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ABPFinal;

namespace ABPFinal.Pages.Songs
{
    public class IndexModel : PageModel
    {
        private readonly ABPFinal.SongContext _context;

        public IndexModel(ABPFinal.SongContext context)
        {
            _context = context;
        }

        public IList<Song> Song { get;set; }

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}
        [BindProperty(SupportsGet = true)]
        public string? SearchString {get; set;}


        public async Task OnGetAsync()
        {
            var query = _context.Songs.Select(s => s);

            switch (CurrentSort){
                case "title_asc":
                    query = query.OrderBy(s => s.SongName);
                    break;
                case "title_desc":
                    query = query.OrderByDescending(s => s.SongName);
                    break;
                case "length_asc":
                    query = query.OrderBy(s => s.Length);
                    break;
                case "length_desc":
                    query = query.OrderByDescending(s => s.Length);
                    break;
                case "Genre_asc":
                    query = query.OrderBy(s => s.Genre);
                    break;
                case "Genre_desc":
                    query = query.OrderByDescending(s => s.Genre);
                    break;
                case "Artist_asc":
                    query = query.OrderBy(s => s.Artist);
                    break;
                case "Artist_desc":
                    query = query.OrderByDescending(s => s.Artist);
                    break;
                case "Listener_asc":
                    query = query.OrderBy(s => s.ListenerID);
                    break;
                case "Listener_desc":
                    query = query.OrderByDescending(s => s.ListenerID);
                    break;
                case "search":
                    query = query.Where(f => f.SongName.Contains(SearchString));
                    break;
            }

            Song = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
