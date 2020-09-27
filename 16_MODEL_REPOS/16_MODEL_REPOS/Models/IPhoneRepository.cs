using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_MODEL_REPOS.Models
{
    interface IPhoneRepository
    {
        List<Phone> GetPhone();
        Phone GetPhoneByID(int phoneId);
    }
}
