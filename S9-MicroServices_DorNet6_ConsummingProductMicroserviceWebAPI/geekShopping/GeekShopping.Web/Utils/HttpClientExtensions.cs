using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;

namespace GeekShopping.Web.Utils
{
    public static class HttpClientExtensions
    {
        private static MediaTypeHeaderValue contentType = new MediaTypeHeaderValue("Aplication/jason");

        public static async Task<T> ReadContentAs<T>(this HttpResponseMessage response)
        {

            if (!response.IsSuccessStatusCode) throw
                    new Exception($"Algo deu errado na chamada da API: " +
                    $"{response.ReasonPhrase}");

            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<T>(dataAsString, 
                    new JsonSerializerOptions 
                    { PropertyNameCaseInsensitive = true });

        }

        public static Task<HttpResponseMessage> PostAsJason<T>(
                        this HttpClient httpClient, 
                        string url, 
                        T data)
        {
            var dataAsSrting = JsonSerializer.Serialize(data);

            var content = new StringContent(dataAsSrting);

            content.Headers.ContentType = contentType;

            return httpClient.PostAsync(url, content);
        }

        public static Task<HttpResponseMessage> PutAsJason<T>(
                this HttpClient httpClient,
                string url,
                T data)
        {
            var dataAsSrting = JsonSerializer.Serialize(data);

            var content = new StringContent(dataAsSrting);

            content.Headers.ContentType = contentType;

            return httpClient.PutAsync(url, content);
        }
    }
}
