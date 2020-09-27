using System.Web.Services;
using laba7b;

namespace laba7b
{
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        Models.DictionaryData telephoneDictionary = new Models.DictionaryData();

        [WebMethod(Description = "Get all numbers", EnableSession = true)]
        public string GetAll()
        {
            return telephoneDictionary.getAll();
        }

        [WebMethod(Description = "Add new number", EnableSession = true)]
        public string AddDict(string surname, int number)
        {
            telephoneDictionary.insert(surname, number);
            return "OK";
        }

        [WebMethod(Description = "Update number by id", EnableSession = true)]
        public string UpdDict(int id, string surname, int number)
        {
            string status = telephoneDictionary.update(id, surname, number);
            return status;
        }

        [WebMethod(Description = "Delete number by id", EnableSession = true)]
        public string DelDict(int id)
        {
            string status = telephoneDictionary.delete(id);
            return status;
        }
    }
}
