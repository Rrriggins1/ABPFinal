using Microsoft.EntityFrameworkCore;
namespace ABPFinal
{
	public class ListenerContext : DbContext
	{
		public ListenerContext (DbContextOptions<ListenerContext> options)
			: base(options)
		{
		}
		public DbSet<Listener> Listeners {get; set;} = default!;
	}
}
