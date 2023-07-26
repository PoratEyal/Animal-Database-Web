namespace webV6.Services
{
    public interface IRepository
    {
        List<Animal> GetAnimalByCategory(int id);
        Animal GetAnimalByID(int id);
        List<Comment> GetComments();
        List<Animal> ShowAnimal();
        List<Category> ShowCategories();
        List<Animal> ShowTwoAnimals();
        void AddComment(int id, string comment);
        void DeleteAnimal(int id);
        void AddNewAnimal(Animal animal, string filePath);
        void EditAnimal(int id, Animal animal, string filePath);
        void EditAnimalSamePic(int id, Animal animal);

        Animal SearchAnimal(string animalName);
    }
}
