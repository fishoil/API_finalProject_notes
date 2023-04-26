using System;
namespace NotesAPI.Models
{
	public class User
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Email { get; set; }
		public List<Note> Notes { get; set; } = new List<Note>();

	}
}

