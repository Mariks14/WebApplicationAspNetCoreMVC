using Microsoft.EntityFrameworkCore;

namespace WebApplicationAspNetCoreMVC.Models
{
	public class ApplicationContext : DbContext
	{
		public DbSet<Companies> Companies { get; set; } = null!;
		public DbSet<History> History { get; set; } = null!;
		public DbSet<Notes> Notes { get; set; } = null!;
		public DbSet<Employes> Employes { get; set; } = null!;

		public ApplicationContext(DbContextOptions<ApplicationContext> options)
			: base(options)
		{
			Database.EnsureCreated();   // создаем базу данных при первом обращении
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Companies>().HasData(
				new Companies { Id = 1, Name = "Super Mart of the West", Address ="702 SW 8 th street", City = "Bentonville", State = "Arkansas", Phone = "(800) 555-2797" },
				new Companies { Id = 2, Name = "Electronics Depot", Address = "address 2 bulvar t d", City = "Atlanta", State = "Georgia", Phone = "(800) 595-3232" },
				new Companies { Id = 3, Name = "K&S Music", Address = "kakoito address bla bla", City = "Minneapolis", State = "Minnesota", Phone = "(612) 304-6073" },
				new Companies { Id = 4, Name = "Tom`s Club", Address = "500 SW 3 th street Rona", City = "Issaquah", State = "Washington", Phone = "(800) 955-2292" },
				new Companies { Id = 5, Name = "E-Mart", Address = "100 SW 1 th street", City = "Hoffman Estates", State = "Illinoise", Phone = "(847) 286-2500" }

			);

			modelBuilder.Entity<History>().HasData(
				new History { Id = 1, NameCompany = "Super Mart of the West", OrderDate = "11/12/2013", StoreCity = "Las Vegas" },
				new History { Id = 2, NameCompany = "Super Mart of the West", OrderDate = "11/14/2013", StoreCity = "Las Vegas" },
				new History { Id = 3, NameCompany = "Super Mart of the West", OrderDate = "11/18/2013", StoreCity = "San Jose" },
				new History { Id = 4, NameCompany = "Super Mart of the West", OrderDate = "11/22/2013", StoreCity = "Denver" },
				new History { Id = 5, NameCompany = "Super Mart of the West", OrderDate = "11/30/2013", StoreCity = "Seattle" },
				new History { Id = 6, NameCompany = "Electronics Depot", OrderDate = "10/14/2013", StoreCity = "Las Vegas" },
				new History { Id = 7, NameCompany = "K&S Music", OrderDate = "10/12/2013", StoreCity = "Denver" }


				);

			modelBuilder.Entity<Notes>().HasData(
				new Notes {Id =1, NameCompany= "Super Mart of the West", InvoceNumber =35703, Employee="Harv Mudd" },
				new Notes { Id = 2, NameCompany = "Super Mart of the West", InvoceNumber = 35711, Employee = "Jim  Packard" },
				new Notes { Id = 3, NameCompany = "Super Mart of the West", InvoceNumber = 35714, Employee = "Harv Mudd" },
				new Notes { Id = 4, NameCompany = "Super Mart of the West", InvoceNumber = 35983, Employee = "Todd Hoffman" },
				new Notes { Id = 5, NameCompany = "Super Mart of the West", InvoceNumber = 36987, Employee = "Clark Morgan" },
				new Notes { Id = 6, NameCompany = "Electronics Depot", InvoceNumber = 35111, Employee = "Harv Mudd" },
				new Notes { Id = 7, NameCompany = "K&S Music", InvoceNumber = 35154, Employee = "Arthur Morgan" },
                new Notes { Id = 8, NameCompany = "Super Mart of the West", InvoceNumber = 36587, Employee = "John Heart" },
                new Notes { Id = 9, NameCompany = "Super Mart of the West", InvoceNumber = 33987, Employee = "Olivio Peyton" },
                new Notes { Id = 10, NameCompany = "Super Mart of the West", InvoceNumber = 36997, Employee = "Arthur Morgan" }

                );

			modelBuilder.Entity<Employes>().HasData(
				new Employes { Id =1, FirstName="John", LastName="Heart", Title = "Mr.", BirthDate = "3/16/1964", Position="CEO", City= "Las Vegas" },
				new Employes { Id = 2, FirstName = "Olivio", LastName = "Peyton", Title = "Ms", BirthDate = "3/1/1968", Position = "Marketing", City = "Las Vegas" },
				new Employes { Id = 3, FirstName = "Arthur", LastName = "Morgan", Title = "Mr.", BirthDate = "3/16/1977", Position = "Cowboy", City = "Las Vegas" },
				new Employes { Id = 4, FirstName = "Robert", LastName = "Reagon", Title = "Mr.", BirthDate = "3/16/1988", Position = "Programmer", City = "Las Vegas" }


				);

		}
	}
}
