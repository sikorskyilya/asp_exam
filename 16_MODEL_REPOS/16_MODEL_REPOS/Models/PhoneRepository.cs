using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _16_MODEL_REPOS.Models
{
    public class PhoneRepository: IPhoneRepository
    {

        private List<Phone> phones = new List<Phone>
            {
                new Phone { Id=1, Manufacturer= "apple", Name="iPhone X", Price=56000 },
                new Phone { Id=2, Manufacturer= "apple", Name="iPhone XZ", Price=41000 },
                new Phone { Id=3, Manufacturer= "microsoft", Name="Galaxy 9", Price=9000 },
                new Phone { Id=4, Manufacturer= "microsoft", Name="Galaxy 10", Price=40000 },
                new Phone { Id=5, Manufacturer= "google", Name="Pixel 2", Price=30000 },
                new Phone { Id=6, Manufacturer= "google", Name="Pixel XL", Price=50000 }
            };


        private List<Phone> Phones { get => phones; set => phones = value; }

        public PhoneRepository()
        {
            
        }
        public List<Phone> GetPhone()
        {
            return phones.ToList();
        }
        public Phone GetPhoneByID(int id)
        {
            return phones.Find(x=> x.Id == id);
        }

    }
}