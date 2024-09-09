using Microsoft.EntityFrameworkCore;

// class to have a bridge between models and the database **(set the sql database up in appsettings.json)
public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
	{
	}

	public DbSet<User> Users { get; set; }
	public DbSet<Product> Products { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Product>()
			.Property(p => p.Price)
			.HasColumnType("decimal(18,2)"); // specify precision and scale

		base.OnModelCreating(modelBuilder);
	}
}
