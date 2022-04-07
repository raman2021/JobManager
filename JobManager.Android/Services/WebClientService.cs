using System;
using JobManager.Services;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http;
using Xamarin.Forms;
using JobManager.Droid.Services;

[assembly: Dependency(typeof(WebClientService))]
namespace JobManager.Droid.Services
{

    public class WebClientService : IWebClientService
    {
        public Task<string> GetAsync(string uri)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetString(string uri)
        {
            try
            {

                HttpClient client;
                client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(uri);


                return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
            }
            catch
            {
                return null;
            }

        }

        public async Task<string> PostAsync(string uri, string body, string type)
        {
            try
            {
                HttpClient client;
                client = new HttpClient();

                var content = new StringContent(body.ToString(), Encoding.UTF8, type);

                HttpResponseMessage response = await client.PostAsync(uri, content);
                return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
            }
            catch
            {
                return null;
            }

        }

        public async Task<string> PutAsync(string uri, string body, string type)
        {
            try
            {
                HttpClient client;
                client = new HttpClient();

                var content = new StringContent(body.ToString(), Encoding.UTF8, type);

                HttpResponseMessage response = await client.PutAsync(uri, content);
                return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
            }
            catch
            {
                return null;
            }
        }
    }


}