using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; } //primary key

        [Column(TypeName = "nvarchar(50)")] //add Column attribute to specify the corresponding SQL Server data type
        [Required(ErrorMessage = "Title is required.")] //validation 
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; } = "Expense";

        [NotMapped]
        public string? TitleWithIcon //show the icon with the title next to each other in the Index.cshtml view
        {
            get
            {
                return this.Icon + " " + this.Title;
            }
        }
    }
}

