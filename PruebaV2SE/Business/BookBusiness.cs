using PruebaV2SE.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace PruebaV2SE.Business
{
    public class BookBusiness
    {
        public List<BookEntities> DatosBook()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://fakerestapi.azurewebsites.net/api/v1/Books");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                List<BookEntities> books = JsonConvert.DeserializeObject<List<BookEntities>>(json);
                return books;
            }
        }
    }
}