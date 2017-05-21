using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Http;
using System.Web.Script.Serialization;
using GetComics.Marvel_Models;

namespace GetComics
{
    class MarvelFacade
    {
        private const string PRIVATE_KEY = "1627e95a2e0db2ade7d87289b17ad47abde656df";
        private const string PUBLIC_KEY = "a88713c7e664210b39c945f1bbeffaf1";

        public async Task<T> getCurrentComics<T>()
        {
            // Get the md5 hash
            string timeStamp = DateTime.Now.Ticks.ToString();

            string hash = CreateHash(timeStamp);
            string url = String.Format("https://gateway.marvel.com:443/v1/public/comics?dateDescriptor=thisWeek&apikey={0}&ts={1}", PUBLIC_KEY, timeStamp);

            // Call the marvel 
            HttpClient _httpClient = new HttpClient();
            var res = await _httpClient.GetAsync(url);
            var jsonString = await res.Content.ReadAsStringAsync();

            var serializer = new JavaScriptSerializer();
            var result = serializer.Deserialize<T> (jsonString);

            return result;


        // Deserialize
    }

        private static string CreateHash(string timeStamp)
        {
            string toBeHashed = timeStamp + PRIVATE_KEY + PUBLIC_KEY;
            return (toBeHashed);
            
        }

        public string Hash(string data)
        {
            MD5 md5 = MD5.Create();
            byte[] toBeHashedBytes = Encoding.ASCII.GetBytes(data);
            byte[] hash = md5.ComputeHash(toBeHashedBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }

    public class Test<T>
    {
        
    }
}
