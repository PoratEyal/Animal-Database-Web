namespace webV6.Services
{
    public class Repository : IRepository
    {
        private MyDbContext? _data;

        //Ctor
        public Repository(MyDbContext data)
        {
            _data = data;
        }


        // get id of category and return a list of all the animals in this category
        public List<Animal> GetAnimalByCategory(int id)
        {
            var animalList = _data.Animals.Where(a => a.CategoryId == id).ToList();
            if (animalList == null)
                return null;
            return animalList;
        }

        // get id and return tha animal that this is her id
        public Animal GetAnimalByID(int id)
        {
            Animal a = _data.Animals.Where(a => a.AnimalId == id).FirstOrDefault();
            return a;
        }

        // return list of all the comments
        public List<Comment> GetComments()
        {
            return _data.Comments.ToList();
        }

        // return list of all animals
        public List<Animal> ShowAnimal()
        {
            return _data.Animals.ToList();
        }

        // return list of two animals that have the most comments
        public List<Animal> ShowTwoAnimals()
        {
            var list = _data?.Animals.OrderByDescending(a => a.AnimalComments.Count).Take(2).ToList();
            return list;
        }

        // get id of animal and string comment, and add the comment to the animal
        public void AddComment(int id, string comment)
        {
            _data?.Comments.Add(new Models.Comment { CommentText = comment, AnimalId = id });
            _data?.SaveChanges();
        }

        // return list of the animals categories 
        public List<Category> ShowCategories()
        {
            return _data.Categories.ToList();
        }

        // get id of animal and delete the animal from the data base
        public void DeleteAnimal(int id)
        {
            Animal a = _data.Animals.Where(a => a.AnimalId == id).FirstOrDefault();
            if (a != null)
            {
                _data.Animals.Remove(a);
                _data.SaveChangesAsync();
            }
        }

        // get animal and string path of image and add the path to the pictureName property,
        // and add the animal to the DB
        public void AddNewAnimal(Animal animal, string filePath)
        {
            animal.PictureName = filePath;
            _data?.Animals.Add(animal);
            _data?.SaveChanges();
        }

        // get animal, id, and string file path of the picture animal.
        // the func search the animal by his id and update the data in the the of the tha animal and the file path. 
        public void EditAnimal(int id, Animal animal, string filePath)
        {
            var editAnimal = _data?.Animals.FirstOrDefault(a => a.AnimalId == id);

            if (editAnimal != null)
            {
                editAnimal.AnimalName = animal.AnimalName;
                editAnimal.Age = animal.Age;
                editAnimal.CategoryId = animal.CategoryId;
                editAnimal.Description = animal.Description;
                editAnimal.PictureName = filePath;

                _data?.SaveChanges();
            }
        }

        // get animal and id.
        // the func search the animal by his id and update the data in the the of the tha animal without the picture
        public void EditAnimalSamePic(int id, Animal animal)
        {
            var editAnimal = _data?.Animals.FirstOrDefault(a => a.AnimalId == id);

            if(editAnimal != null)
            {
                editAnimal.AnimalName = animal.AnimalName;
                editAnimal.Age = animal.Age;
                editAnimal.CategoryId = animal.CategoryId;
                editAnimal.Description = animal.Description;

                _data?.SaveChanges();
            }
        }

        // get animal name and return the animal that eqauls to this name
        public Animal SearchAnimal(string animalName)
        {
            return _data?.Animals.Where(a => a.AnimalName == animalName).FirstOrDefault();
        }
    }
}
