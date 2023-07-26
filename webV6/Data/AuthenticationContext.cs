namespace webV6.Data
{
    public class AuthenticationContext : IdentityDbContext<IdentityUser>
    {
        public AuthenticationContext(DbContextOptions<AuthenticationContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<LoginModel>().HasData(
        //        new { Username = "amir", Password ="12345678"},
        //        new { Username = "boston", Password = "acdcacdc" }
        //        );
        //}
    }
}
