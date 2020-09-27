using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        Models.DictionaryData telephoneDictionary = new Models.DictionaryData();

        public string GetAll()
        {
            return telephoneDictionary.getAll();
        }

        public string AddDict(string surname, int number)
        {
            telephoneDictionary.insert(surname, number);
            return "OK";
        }

        public string UpdDict(int id, string surname, int number)
        {
            string status = telephoneDictionary.update(id, surname, number);
            return status;
        }

        public string DelDict(int id)
        {
            string status = telephoneDictionary.delete(id);
            return status;
        }
    }
}
