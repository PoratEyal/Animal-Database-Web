namespace webV6.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Enter Category name")]
        [Display(Name = "Category name")]
        public string? CategoryName { get; set; }

        public virtual ICollection<Animal>? AnimalCategory { get; set; }
    }
}
