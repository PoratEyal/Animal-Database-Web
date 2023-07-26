namespace webV6.Models
{
    public class Animal
    {
        [Key]
        [Display(Name = "Animal ID")]
        public int AnimalId { get; set; }

        [StringLength(17, MinimumLength = 1)]
        [Required (ErrorMessage = "Enter a name")]
        [Display(Name = "Name")]
        public string? AnimalName { get; set; }

        [Range(1,120, ErrorMessage = "Enter Age between 1-120")]
        [Required(ErrorMessage = "Enter Age")]
        public int Age { get; set; }

        //[Required(ErrorMessage = "Enter a picture of the animal")]
        [Display(Name = "Picture name")]
        public string? PictureName { get; set; }

        [StringLength(270, ErrorMessage = "Max: 250 characters")]
        [Required(ErrorMessage = "Enter decription")]
        public string? Description { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }

        [Required(ErrorMessage = "Choose Category")]
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        public virtual ICollection<Comment>? AnimalComments { get; set; }
    }
}
