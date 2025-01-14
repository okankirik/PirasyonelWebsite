using Microsoft.EntityFrameworkCore;
using PirasyonelWebsite.DAL.Entities;

namespace PirasyonelWebsite.DAL.Context;

public class PirasyonelContext : DbContext
{
	public PirasyonelContext(DbContextOptions<PirasyonelContext> options) : base(options)
	{
	}

    public DbSet<About> abouts { get; set; }
    public DbSet<Carousel> carousels { get; set; }
    public DbSet<Contact> contacts { get; set; }
    public DbSet<SystemStand> systemStands { get; set; }
    public DbSet<WoodenStand> woodenStands { get; set; }
    public DbSet<SocailMedia> socailMedias { get; set; }
}
