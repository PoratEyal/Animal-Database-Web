namespace webV6.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new { CategoryId=1, CategoryName = "mammal" },     // יונקים
                new { CategoryId = 2, CategoryName = "reptiles" },  // זוחלים
                new { CategoryId = 3, CategoryName = "poultry" },     // עופות   
                new { CategoryId = 4, CategoryName = "carnivores" },  //טורפים
                new { CategoryId = 5, CategoryName = "dogs" }  //כלבים
                );

            modelBuilder.Entity<Animal>().HasData(
                new { AnimalId=1, AnimalName = "eagle", Age = 4, Description = "Eagles are majestic birds of prey known for their impressive wingspan and sharp talons, often found soaring high above mountains and cliffs, searching for their next meal. They are also highly revered in many cultures as symbols of strength, freedom, and courage.", PictureName = "eagle.png", CategoryId = 3 },
                new { AnimalId = 2, AnimalName = "Snake", Age = 12, Description = "Snakes are legless reptiles with elongated bodies and scaly skin, known for their ability to slither and coil, and are found in various habitats around the world, often hunting for prey such as rodents, birds, and insects.", PictureName = "snake.jpg", CategoryId = 2},
                new { AnimalId = 3, AnimalName = "Lion", Age = 10, Description = "Lions are majestic big cats, known for their golden fur, impressive manes, and powerful roars, and are often found living in prides on the grasslands and savannas of Africa, hunting for prey such as antelopes, zebras, and buffalo.", PictureName = "lion.jpeg", CategoryId = 4},
                new { AnimalId = 4, AnimalName = "Fox", Age = 10, Description = "Foxes are small mammals with bushy tails and sharp senses that can be found in various habitats around the world, including forests, grasslands, and even urban areas.", PictureName = "fox.jpg", CategoryId = 1},
                new { AnimalId = 5, AnimalName = "Panthers", Age = 5, Description = "Panthers are black-furred big cats known for their impressive hunting skills and agility. They inhabit various habitats worldwide and are admired for their strength and beauty in many cultures.", PictureName = "panther.jpg", CategoryId = 4},
                new { AnimalId = 6, AnimalName = "Panda", Age = 14, Description = "Pandas are a beloved species of bear native to China. They are easily recognized by their distinctive black and white fur, and are known for their bamboo-heavy diet.", PictureName = "panda.jpg", CategoryId = 1},
                new { AnimalId = 7, AnimalName = "Tiger", Age = 4, Description = "The tiger (Panthera tigris) is the largest living cat species and a member of the genus Panthera. It is most recognisable for its dark vertical stripes on orange fur with a white underside", PictureName = "tigris.jpg", CategoryId = 4},
                new { AnimalId = 8, AnimalName = "Mandarin duck", Age = 3, Description = "The mandarin duck (Aix galericulata) is a perching duck species native to the East Palearctic. It is medium-sized, at 41–49 cm (16–19 in) long with a 65–75 cm (26–30 in) wingspan.", PictureName = "mandarinDuck.jpg", CategoryId = 3},
                new { AnimalId = 9, AnimalName = "Cheetah", Age = 14, Description = "The cheetah is a large cat native to Africa and Southwest Asia. It is the fastest land animal, capable of running at 80 to 98 km/h, as such has evolved specialized adaptations for speed, including a light build, long thin legs and a long tail", PictureName = "cheetah.jpg", CategoryId = 4},
                new { AnimalId = 10, AnimalName = "Lizard", Age = 4, Description = "Lizards are a widespread group of squamate reptiles, with over 7,000 species, ranging across all continents except Antarctica, as well as most oceanic island chains", PictureName = "lizard.jpg", CategoryId = 2},
                new { AnimalId = 11, AnimalName = "Turtle", Age = 70, Description = "Turtles are an order of reptiles known as Testudines, characterized by a special shell developed mainly from their ribs. Modern turtles are divided into two major groups, the Pleurodira and Cryptodira, which differ in the way the head retracts", PictureName = "turtle.jpg", CategoryId = 2},
                new { AnimalId = 12, AnimalName = "Akita", Age = 10, Description = "The Akita (秋田, Akita, Japanese pronunciation: is a Japanese dog breed of large size. Originating from the mountains of northern Japan, the Akita has a short double coat similar to that of many other northern spitz breeds.", PictureName = "akita.jpg", CategoryId = 5},
                new { AnimalId = 13, AnimalName = "Kai Ken", Age = 7, Description = "The Kai Ken (甲斐犬) is a breed of dog from Japan, where it is a national monument. It is a rare dog even in its native land and is one of the six native Japanese dog breeds protected by the Nihon Ken Hozonkai.", PictureName = "kai_ken.jpg", CategoryId = 5},
                new { AnimalId = 14, AnimalName = "Shiba Inu", Age = 7, Description = "The Shiba Inu (柴犬) is a breed of hunting dog from Japan. A small-to-medium breed, it is the smallest of the six original and distinct spitz breeds of dog native to Japan. Its name literally translates to \"brushwood dog\", as it is used to flush game.", PictureName = "shiba_inu.jpg", CategoryId = 2},
                new { AnimalId = 15, AnimalName = "Leopard", Age = 7, Description = "The leopard is one of the five extant species in the genus Panthera, a member of the cat family, Felidae. It occurs in a wide range in sub-Saharan Africa.", PictureName = "leopard.jpg", CategoryId = 4},
                new { AnimalId = 16, AnimalName = "Owl", Age = 7, Description = "Owls are birds from the order Strigiformes, which includes over 200 species of mostly solitary and nocturnal birds of prey typified by an upright stance, a large, broad head, binocular vision, binaural hearing, sharp talons, and feathers adapted for silent flight", PictureName = "owl.jpg", CategoryId = 3},
                new { AnimalId = 17, AnimalName = "Moose", Age = 7, Description = "The moose (in North America) or elk (in Eurasia) (Alces alces) is a member of the New World deer subfamily and is the only species in the genus Alces. It is the largest and heaviest extant species in the deer family.", PictureName = "Moose.jpg", CategoryId = 1},
                new { AnimalId = 18, AnimalName = "Utonagan", Age = 7, Description = "The Utonagan is a beautiful, large dog with wolf-like features. The muscular, and graceful, Utonagan is a relatively new dog breed and as a hybrid dog, it is not yet recognized by the major Kennel Clubs", PictureName = "utonagan.jpg", CategoryId = 5}
                );

            modelBuilder.Entity<Comment>().HasData(
               new { CommentId=1, AnimalId = 1, CommentText = "very nice" },
               new { CommentId=2, AnimalId = 2, CommentText = " nice" },
               new { CommentId=3, AnimalId = 3, CommentText = "love it" },
               new { CommentId=4, AnimalId = 4, CommentText = "wow" },
               new { CommentId=5, AnimalId = 5, CommentText = "like !!1" },
               new { CommentId=6, AnimalId = 6, CommentText = "best animal" },
               new { CommentId=7, AnimalId = 1, CommentText = "very good" },
               new { CommentId=8, AnimalId = 2, CommentText = "go boston celtics" },
               new { CommentId=9, AnimalId = 3, CommentText = "nice" },
               new { CommentId=10, AnimalId = 3, CommentText = "lets gooo" },
               new { CommentId=11, AnimalId = 4, CommentText = "very good" },
               new { CommentId=12, AnimalId = 5, CommentText = "nice animal" },
               new { CommentId=13, AnimalId = 7, CommentText = "big boss !!!" },
               new { CommentId=14, AnimalId = 13, CommentText = "cool dog" }
               );
        }
    }
}
