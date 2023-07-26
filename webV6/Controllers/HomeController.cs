namespace webV6.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;
        private readonly IFileUploadService fileUploadService;
        private string _filePath;

        //Ctor
        public HomeController(IRepository repository, IFileUploadService fileUploadService)
        {
            _repository = repository;
            this.fileUploadService = fileUploadService;
        }


        // - -   - - - - - - - Home page controller - - - - - - -  - - - - 

        public IActionResult HomePage()
        {
            return View(_repository.ShowTwoAnimals());
        }



        // - -   - - - - - - - Catalog page controllers - - - - - - -  - - - - - - - -



        [HttpGet]
        public IActionResult CatalogPage()
        {
            ViewBag.Categories = _repository.ShowCategories();
            return View(_repository.ShowAnimal());
        }

        [HttpPost]
        public IActionResult CatalogPage(int id)
        {
            ViewBag.Categories = _repository.ShowCategories();
            ViewBag.animalsByCategory  = _repository.GetAnimalByCategory(id);
            return View("CatalogPage");
        }



        // - -   - - - - - - - Animal details page controller - - - - - - -  - - - - 



        [HttpGet]
        public IActionResult AnimalDetails(int id)
        {
            ViewBag.animal = _repository.GetAnimalByID(id);
            //ViewBag.allComments = _repository.GetComments();

            return View(_repository.GetComments());
        }

        [HttpPost]
        public IActionResult AnimalDetails(int id, string CommentText)
        {
            ViewBag.animal = _repository.GetAnimalByID(id);
            //ViewBag.allComments = _repository.GetComments();

            if(ModelState.IsValid)
            {
                _repository.AddComment(id, CommentText);
            }
            return View(_repository.GetComments());
        }



        // - -   - - - - - - - Administrator page controllers - - - - - - -  - - - - 

        [HttpGet]
        public IActionResult AdministratorPage()
        {
            ViewBag.Categories = _repository.ShowCategories();
            return View(_repository.ShowAnimal());
        }

        [HttpPost]
        public IActionResult AdministratorPage(int id)
        {
            ViewBag.Categories = _repository.ShowCategories();
            ViewBag.animalsByCategory = _repository.GetAnimalByCategory(id);
            return View("AdministratorPage");
        }

        [HttpPost]
        public IActionResult SearchAnimal(string AnimalName)
        {
            ViewBag.Categories = _repository.ShowCategories();
            ViewBag.animalsByCategory = _repository.ShowAnimal();
            if (_repository.SearchAnimal(AnimalName) != null)
                return View(_repository.SearchAnimal(AnimalName));
            else
            {
                return View(_repository.SearchAnimal(AnimalName));
                //return View("AdministratorPage");
            }


        }

        [Authorize]
        public IActionResult DeleteAnimal(int id)
        {
            ViewBag.Categories = _repository.ShowCategories();
            ViewBag.animalsByCategory = _repository.ShowAnimal();
            //ViewBag.animalsByCategory = _repository.GetAnimalByCategory(id);
            _repository.DeleteAnimal(id);
            return View("AdministratorPage");
        }

        [Authorize]
        [HttpGet]
        public IActionResult EditAnimal(int id)
        {
            ViewBag.animalsByCategory = _repository.ShowAnimal();
            ViewBag.Categories = _repository.ShowCategories();
            ViewBag.animal = _repository.GetAnimalByID(id);
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> EditAnimal(int id, Animal animal, IFormFile file)
        {
            ViewBag.animalsByCategory = _repository.ShowAnimal();
            ViewBag.Categories = _repository.ShowCategories();
            ViewBag.animal = _repository.GetAnimalByID(id);

            if (file != null)
            {
                _filePath = await fileUploadService.UploadFileasync(file);

                if (ModelState.IsValid)
                {
                    _repository.EditAnimal(id, animal, file.FileName);
                    return View("AdministratorPage");
                }
            }
            else
            {
                if(animal.AnimalName != null && animal.Age != 0 && animal.CategoryId != 0 && animal.Description != null)
                {
                    _repository.EditAnimalSamePic(id, animal);
                    return View("AdministratorPage");
                }
            }

            return View("EditAnimal");
        }

        [Authorize]
        [HttpGet]
        public IActionResult AddNewAnimal()
        {
            ViewBag.Categories = _repository.ShowCategories();
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewAnimal(Animal animal, IFormFile file)
        {
            ViewBag.Categories = _repository.ShowCategories();
            ViewBag.animalsByCategory = _repository.ShowAnimal();


            if (file != null)
                _filePath = await fileUploadService.UploadFileasync(file);
            else
                return View("AddNewAnimal");

            if (ModelState.IsValid)
            {
                _repository.AddNewAnimal(animal, file.FileName);
                return View("AdministratorPage");
            }

            return View("AddNewAnimal");
        }
    }
}
