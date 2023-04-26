using System;
namespace NotesAPI.Models
{
	public class Response
	{
		public int? StatusCode { get; set; }
		public string? StatusDescription { get; set; }
		public List<Note> Notes { get; set; } = new List<Note>();
        public List<User> Users { get; set; } = new List<User>();
    }
}

