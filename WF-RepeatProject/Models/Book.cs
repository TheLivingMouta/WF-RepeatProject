using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WF_RepeatProject.Models
{
	public class Book
	{

		public int Id { get; set; }

		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string Title { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Author { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Category { get; set; }

		[Range(1, 100)]
		[DataType(DataType.Currency)]
		[Required]
		[Column(TypeName = "Decimal(18,2)")]
		public decimal Price { get; set; }

	}
}
