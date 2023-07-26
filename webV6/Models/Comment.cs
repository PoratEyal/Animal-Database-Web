namespace webV6.Models
{
    public class Comment
    {
        [Key]
        [Display(Name = "ID")]
        public int CommentId { get; set; }

        [ForeignKey("AnimalId")]
        public virtual Animal? Animal { get; set; }

        [Required(ErrorMessage = "Enter animal ID")]
        [Display(Name = "Animal ID")]
        public int AnimalId { get; set; }

        [StringLength(40, ErrorMessage = "Max: 40 characters")]
        [Required(ErrorMessage = "Enter comment")]
        [Display(Name = "Comment")]
        public string? CommentText { get; set; }
    }
}
