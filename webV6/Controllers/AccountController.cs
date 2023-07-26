namespace webV6.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        //ctor
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username!, model.Password!, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("AdministratorPage", "Home");
                }
            }
            return View();
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("HomePage", "Home");
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(LoginModel model)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = model.Username,
            };

            if(model.Password != null)
            {
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded && ModelState.IsValid)
                {
                    return RedirectToAction("Login", "Account");
                }
            }

            return View("Register");
        }
    }
}
