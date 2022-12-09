using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using ABPFinal;

namespace ABPFinal.Pages;

public class RyanModel : PageModel
{
    private readonly SongContext _context; //replaces db variable.
    private readonly ListenerContext _context2;
    private readonly ILogger<RyanModel> _logger;
    [BindProperty]
    public List<Song> Songs {get; set;} = default!;
    [BindProperty]
    public List<Listener> Listeners {get; set;} = default!;

    public RyanModel(SongContext context, ListenerContext context2, ILogger<RyanModel> logger)
    {
        _context = context;
        _context2 = context2;
        _logger = logger;
    }

    public IActionResult OnGet()
    {
        if (!ModelState.IsValid){
            return Page();
        }

       Songs = _context.Songs.ToList();
       Listeners = _context2.Listeners.ToList();

       return Page();
    }
}