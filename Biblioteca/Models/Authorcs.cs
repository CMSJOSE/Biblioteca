﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Model
{
	[Table("Authors")]
	public class Author
	{
		public int Id { get; set; }
		[Required]
		[StringLength(50)]
		[Column("AuthorName")]

		public string? Name { get; set; }
	}
}
