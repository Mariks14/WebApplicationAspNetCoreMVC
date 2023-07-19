namespace WebApplicationAspNetCoreMVC.Models
{
	public class DBItemModel
	{
	}

	public class Companies
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Phone { get; set; }
	}

	public class History
	{
		public int Id { get; set; }
		public string NameCompany { get; set; }
		public string OrderDate { get; set; }
		public string StoreCity { get; set; }
	}

	public class Notes
	{
		public int Id { get; set; }
		public string NameCompany { get; set; }
		public int InvoceNumber { get; set; }
		public string Employee { get; set; }

	}

	public class Employes
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Title { get; set; }
		public string BirthDate { get; set; }
		public string City { get; set; }
		public string Position { get; set; }
	}
}
