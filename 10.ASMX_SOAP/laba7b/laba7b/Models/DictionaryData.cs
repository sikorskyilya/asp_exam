using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace laba7b.Models
{
    public class DictionaryData
    {
        private List<Dictionary> dictionaries = new List<Dictionary>();

        public string getAll()
        {
            string jsonString = File.ReadAllText(@"D:\PISEKZ\EKZ\NEW\10.ASMX_SOAP\laba7b\laba7b\App_Data\Data.json");
            return jsonString;
        }

        public List<Dictionary> selectAll()
        {
            string jsonString = File.ReadAllText(@"D:\PISEKZ\EKZ\NEW\10.ASMX_SOAP\laba7b\laba7b\App_Data\Data.json");
            this.dictionaries = JsonConvert.DeserializeObject<List<Dictionary>>(jsonString).ToList();
            return dictionaries.OrderBy(u => u.id).ToList();
        }

        public void insert(string surname, int number)
        {
            this.dictionaries = selectAll();
            int id = 0;
            foreach (Dictionary telephone in dictionaries)
            {
                if (telephone.id > id)
                {
                    id = telephone.id;
                }
            }
            this.dictionaries.Add(new Dictionary { id = id + 1, surname = surname, number = number });
            saveChange(dictionaries);
        }

        public string update(int id, string surname, int number)
        {
            this.dictionaries = selectAll();
            int index = this.dictionaries.IndexOf(this.dictionaries.Find(x => x.id == id));
            if (index != -1)
            {
                dictionaries[index].surname = surname;
                dictionaries[index].number = number;
                saveChange(dictionaries);
                return "OK";
            }
            else
                return "Error";
        }

        public string delete(int id)
        {
            this.dictionaries = selectAll();
            Dictionary removed = this.dictionaries.Find(x => x.id == id);
            if (removed != null)
            {
                this.dictionaries.Remove(removed);
                saveChange(dictionaries);
                return "OK";
            }
            else
                return "Error";
        }

        public void saveChange(List<Dictionary> dictionaries)
        {
            string jsonString = JsonConvert.SerializeObject(dictionaries);
            File.WriteAllText(@"D:\PISEKZ\EKZ\NEW\10.ASMX_SOAP\laba7b\laba7b\App_Data\Data.json", jsonString);
        }
    }
}