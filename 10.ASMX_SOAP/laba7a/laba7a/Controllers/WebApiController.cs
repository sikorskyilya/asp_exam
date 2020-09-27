using laba7a.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace laba7a.Controllers
{
    public class WebApiController : ApiController
    {
        DictionaryData dictionaryData = new DictionaryData();

        [HttpGet]
        public HttpResponseMessage Index()
        {
            HttpResponseMessage rm = new HttpResponseMessage();
            rm.Content = new StringContent(dictionaryData.getAll(), Encoding.UTF8, "application/json");
            return rm;
        }

        [HttpPost]
        public HttpResponseMessage Post(HttpRequestMessage request)
        {
            var body = request.Content;
            string json = body.ReadAsStringAsync().Result;
            dynamic data = JObject.Parse(json);

            dictionaryData.insert(Convert.ToString(data.surname), Convert.ToInt32(data.number));

            HttpResponseMessage rm = new HttpResponseMessage();
            rm.Content = new StringContent("OK");
            return rm;
        }

        [HttpPut]
        public HttpResponseMessage Put(HttpRequestMessage request)
        {
            var body = request.Content;
            string json = body.ReadAsStringAsync().Result;
            dynamic data = JObject.Parse(json);

            dictionaryData.update(Convert.ToInt32(data.id), Convert.ToString(data.surname), Convert.ToInt32(data.number));

            HttpResponseMessage rm = new HttpResponseMessage();
            rm.Content = new StringContent("OK");
            return rm;
        }

        [HttpDelete]
        public HttpResponseMessage Del(HttpRequestMessage request)
        {
            var body = request.Content;
            string json = body.ReadAsStringAsync().Result;
            dynamic data = JObject.Parse(json);

            dictionaryData.delete(Convert.ToInt32(data.id));

            HttpResponseMessage rm = new HttpResponseMessage();
            rm.Content = new StringContent("OK");
            return rm;
        }
    }
}
