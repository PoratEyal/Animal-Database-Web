using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webV6.Data;
using webV6.Models;
using webV6.Services;

namespace WebV6.Tests.FakeRepository
{
    public class Fake_Repository : FakeIRipository
    {
        private IEnumerable<Animal> animalsList;


        public Fake_Repository()
        {
            animalsList = new List<Animal>() { new Animal(), new Animal(), new Animal() };
        }

        public IEnumerable<Animal> Animals
        {
            get { return animalsList; }
        }

    }
}
