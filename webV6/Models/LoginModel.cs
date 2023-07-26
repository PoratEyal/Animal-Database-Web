namespace webV6.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Incorrect username")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Incorrect password")]
        public string? Password { get; set; }
    }
}
